using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountGenerator
{
    public partial class NZBankAccountValidator : Form
    {
        public NZBankAccountValidator()
        {
            InitializeComponent();
        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox_FilePath.Text = fdlg.FileName;
            }
        }

        private void button_ValidateFile_Click(object sender, EventArgs e)
        {
            string email;

            string BankAccount;
            string BankID;
            string BankBranch;
            string AccountBase;
            string BankSuffix;
            string BankCode;

            string result;
            string resultMsg;

            string resauceFile = textBox_FilePath.Text;
            if (resauceFile == "")
            {
                MessageBox.Show("Please upload the excel file you want to validate first", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }
            else
            {
                string path = Directory.GetCurrentDirectory();
                string resultFile = path + "cat1_UserBankAccountValidateResult.csv";

                using (CsvFileReader reader = new CsvFileReader(resauceFile))
                {
                    using (CsvFileWriter writer = new CsvFileWriter(resultFile))
                    {
                        CsvRow row = new CsvRow();
                        //Loop the data of cat1_20000_users.csv
                        while (reader.ReadRow(row))
                        {
                            BankAccount = row.ToArray()[0];
                            BankCode = row.ToArray()[1];
                            AccountBase = row.ToArray()[2];
                            BankSuffix = row.ToArray()[3];
                            email = row.ToArray()[4];

                            BankCode = DataGenerator.PaddingLeftWithZero(BankCode, 6);
                            BankID = BankCode.Substring(0, 2);
                            BankBranch = BankCode.Substring(2, 4);

                            BankID = DataGenerator.PaddingLeftWithZero(BankID, 2);
                            BankBranch = DataGenerator.PaddingLeftWithZero(BankBranch, 4);
                            AccountBase = DataGenerator.PaddingLeftWithZero(AccountBase, 8);
                            BankSuffix = DataGenerator.PaddingLeftWithZero(BankSuffix, 4);

                            BankAccount = BankID + BankBranch + AccountBase + BankSuffix;

                            if (BankAccount.Contains("Account"))
                            {
                                CsvRow writeRow = new CsvRow();
                                writeRow.Add("BankAccount");
                                writeRow.Add("BankID");
                                writeRow.Add("BankBranch");
                                writeRow.Add("AccountBase");
                                writeRow.Add("BankSuffix");
                                writeRow.Add("result");
                                writeRow.Add("resultMsg");
                                writeRow.Add("Validate_BankID");
                                writeRow.Add("Validate_BankBranch");
                                writeRow.Add("Validate_BankAccount");
                                writeRow.Add("Validate_BankSuffix");
                                writeRow.Add("Validate_algorithm");
                                writeRow.Add("actualCheckDigit");
                                writeRow.Add("expectCheckDigit");
                                writer.WriteRow(writeRow);

                            }
                            else if (BankAccount == "" || BankID == "" || DataGenerator.IsDigitsOnly(BankAccount) == false || BankAccount.Length <= 13)
                            {
                                result = "false";
                                resultMsg = "Invalid Bank ID";
                                CsvRow writeRow = new CsvRow();
                                writeRow.Add(BankAccount);
                                writeRow.Add(BankID);
                                writeRow.Add(BankBranch);
                                writeRow.Add(AccountBase);
                                writeRow.Add(BankSuffix);
                                writeRow.Add(result);
                                writeRow.Add(resultMsg);
                                writer.WriteRow(writeRow);
                            }
                            else
                            {
                                BankAccount = BankID + BankBranch + AccountBase + BankSuffix;
                                bool resBankID = BankAccountValidator.validateBankID(BankID);
                                bool resBankBranch = BankAccountValidator.validateBankBranch(BankID, BankBranch);
                                bool resBankAccount = BankAccountValidator.validateBankAccountBase(BankID, BankBranch, AccountBase, BankSuffix);
                                string alg = BankAccountValidator.AlgorithmType;
                                string actualCheckDigit = BankAccountValidator.ActualCheckDigit;
                                string expectCheckDigit = BankAccountValidator.ExpectCheckDigit;
                                if (resBankID == false)
                                {
                                    result = "false";
                                    resultMsg = "Invalid Bank ID";
                                }
                                else if (resBankBranch == false)
                                {
                                    result = "false";
                                    resultMsg = "Invalid Bank Branch";
                                }
                                else if (resBankID == true && resBankBranch == true && resBankAccount == true)
                                {

                                    result = "true";
                                    resultMsg = "Valid Bank Account";
                                    string msg = "Valid Bank Account! \r\n " +
                                        "AlgorithmType: " + alg + " \r\n " +
                                        "actualCheckDigit: " + actualCheckDigit + " \r\n " +
                                        "expectCheckDigit: " + expectCheckDigit + " \r\n ";
                                }
                                else
                                {
                                    result = "false";
                                    resultMsg = "Invalid Bank Account";
                                    string msg = "Invalid Bank Account! \r\n " +
                                        "AlgorithmType: " + alg + " \r\n " +
                                        "actualCheckDigit: " + actualCheckDigit + " \r\n " +
                                        "expectCheckDigit: " + expectCheckDigit + " \r\n ";

                                }
                                CsvRow writeRow = new CsvRow();
                                writeRow.Add(BankAccount);
                                writeRow.Add(BankID);
                                writeRow.Add(BankBranch);
                                writeRow.Add(AccountBase);
                                writeRow.Add(BankSuffix);
                                writeRow.Add(result);
                                writeRow.Add(resultMsg);
                                writeRow.Add(BankID);
                                writeRow.Add(BankBranch);
                                writeRow.Add(BankAccount);
                                writeRow.Add(BankSuffix);
                                writeRow.Add(alg);
                                writeRow.Add(actualCheckDigit);
                                writeRow.Add(expectCheckDigit);
                                writer.WriteRow(writeRow);
                            }
                        }
                        textBox_ResultFile.Text = resultFile;
                    }
                }



            }


        }

        private void button_OpenResultFile_Click(object sender, EventArgs e)
        {
            string resultFile = textBox_ResultFile.Text;
            if (resultFile == "")
            {

            }else
            {
                string path = Path.GetDirectoryName(resultFile);
                Process.Start(@resultFile);
            }
        }
    }
}

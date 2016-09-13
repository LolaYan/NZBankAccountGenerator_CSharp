using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox_Suffix_000.Checked = true;
            checkBox_AccountBase_7digits.Checked = true;
            checkSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_GenerateBankAccount_Click(sender, e);
            button_GenerateBankAccountA_Click(sender, e);
            button_GenerateBankAccountB_Click(sender, e);
            button_GenerateBankAccountD_Click(sender, e);
            button_GenerateBankAccountE_Click(sender, e);
            button_GenerateBankAccountF_Click(sender, e);
            button_GenerateBankAccountG_Click(sender, e);
            button_GenerateBankAccountX_Click(sender, e);
        }

        private void button_GenerateBankAccount_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount();
            AccountString.Text = accountStr;
            BankID.Text = BankAccountGenerator.BankIDStr;
            BankBranch.Text = BankAccountGenerator.BankBranchStr;
            AccountBase.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix.Text = BankAccountGenerator.suffixStr;

        }

        private void BankAccoutStr_A_Click(object sender, EventArgs e)
        {


        }

        private void button_GenerateBankAccountA_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount("A");
            BankAccoutStr_A.Text = accountStr;
            BankID_A.Text = BankAccountGenerator.BankIDStr;
            BankBranch_A.Text = BankAccountGenerator.BankBranchStr;
            AccountBase_A.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix_A.Text = BankAccountGenerator.suffixStr;
        }

        private void button_GenerateBankAccountB_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount("B");
            BankAccoutStr_B.Text = accountStr;
            BankID_B.Text = BankAccountGenerator.BankIDStr;
            BankBranch_B.Text = BankAccountGenerator.BankBranchStr;
            AccountBase_B.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix_B.Text = BankAccountGenerator.suffixStr;
        }

        private void button_GenerateBankAccountD_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount("D");
            BankAccoutStr_D.Text = accountStr;
            BankID_D.Text = BankAccountGenerator.BankIDStr;
            BankBranch_D.Text = BankAccountGenerator.BankBranchStr;
            AccountBase_D.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix_D.Text = BankAccountGenerator.suffixStr;
        }

        private void button_GenerateBankAccountE_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount("E");
            BankAccoutStr_E.Text = accountStr;
            BankID_E.Text = BankAccountGenerator.BankIDStr;
            BankBranch_E.Text = BankAccountGenerator.BankBranchStr;
            AccountBase_E.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix_E.Text = BankAccountGenerator.suffixStr;
        }

        private void button_GenerateBankAccountF_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount("F");
            BankAccoutStr_F.Text = accountStr;
            BankID_F.Text = BankAccountGenerator.BankIDStr;
            BankBranch_F.Text = BankAccountGenerator.BankBranchStr;
            AccountBase_F.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix_F.Text = BankAccountGenerator.suffixStr;
        }

        private void button_GenerateBankAccountX_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount("X");
            BankAccoutStr_X.Text = accountStr;
            BankID_X.Text = BankAccountGenerator.BankIDStr;
            BankBranch_X.Text = BankAccountGenerator.BankBranchStr;
            AccountBase_X.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix_X.Text = BankAccountGenerator.suffixStr;
        }

        private void button_GenerateBankAccountG_Click(object sender, EventArgs e)
        {
            checkSettings();
            string accountStr = BankAccountGenerator.getBankAccount("G");
            BankAccoutStr_G.Text = accountStr;
            BankID_G.Text = BankAccountGenerator.BankIDStr;
            BankBranch_G.Text = BankAccountGenerator.BankBranchStr;
            AccountBase_G.Text = BankAccountGenerator.BankAccountBaseStr;
            BankSuffix_G.Text = BankAccountGenerator.suffixStr;
        }


        public void CopyBankAccounttoClipboard(string str)
        {

            MessageBox.Show("Bank Account: " + str, "Copy Account to Clipboard", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

        }

        private void button_CopyBankAccount_Click(object sender, EventArgs e)
        {

            string str = AccountString.Text;

            if (str.Equals("BankAccoutStr"))
            {
                button_GenerateBankAccount_Click(sender, e);

            }
            System.Windows.Forms.Clipboard.SetText(AccountString.Text);

            CopyBankAccounttoClipboard(AccountString.Text);
        }

        private void button_CopyBankAccountA_Click(object sender, EventArgs e)
        {
            string str = BankAccoutStr_A.Text;

            if (str.Equals("BankAccoutStr_A"))
            {
                button_GenerateBankAccountA_Click(sender, e);

            }
            System.Windows.Forms.Clipboard.SetText(BankAccoutStr_A.Text);

            CopyBankAccounttoClipboard(BankAccoutStr_A.Text);
        }


        private void button_CopyBankAccountB_Click(object sender, EventArgs e)
        {
            string str = BankAccoutStr_B.Text;

            if (str.Equals("BankAccoutStr_B"))
            {
                button_GenerateBankAccountB_Click(sender, e);

            }

            System.Windows.Forms.Clipboard.SetText(BankAccoutStr_B.Text);
            CopyBankAccounttoClipboard(BankAccoutStr_B.Text);
        }

        private void button_CopyBankAccountD_Click(object sender, EventArgs e)
        {
            string str = BankAccoutStr_D.Text;

            if (str.Equals("BankAccoutStr_D"))
            {
                button_GenerateBankAccountD_Click(sender, e);

            }
            System.Windows.Forms.Clipboard.SetText(BankAccoutStr_D.Text);

            CopyBankAccounttoClipboard(BankAccoutStr_D.Text);
        }

        private void button_CopyBankAccountE_Click(object sender, EventArgs e)
        {
            string str = BankAccoutStr_E.Text;

            if (str.Equals("BankAccoutStr_E"))
            {
                button_GenerateBankAccountE_Click(sender, e);

            }
            System.Windows.Forms.Clipboard.SetText(BankAccoutStr_E.Text);

            CopyBankAccounttoClipboard(BankAccoutStr_E.Text);
        }

        private void button_CopyBankAccountF_Click(object sender, EventArgs e)
        {
            string str = BankAccoutStr_F.Text;

            if (str.Equals("BankAccoutStr_F"))
            {
                button_GenerateBankAccountF_Click(sender, e);

            }

            System.Windows.Forms.Clipboard.SetText(BankAccoutStr_F.Text);
            CopyBankAccounttoClipboard(BankAccoutStr_F.Text);
        }

        private void button_CopyBankAccountG_Click(object sender, EventArgs e)
        {
            string str = BankAccoutStr_G.Text;

            if (str.Equals("BankAccoutStr_G"))
            {
                button_GenerateBankAccountG_Click(sender, e);

            }
            System.Windows.Forms.Clipboard.SetText(BankAccoutStr_G.Text);
            CopyBankAccounttoClipboard(BankAccoutStr_G.Text);
        }

        private void button_CopyBankAccountX_Click(object sender, EventArgs e)
        {
            string str = BankAccoutStr_X.Text;

            if (str.Equals("BankAccoutStr_X"))
            {
                button_GenerateBankAccountX_Click(sender, e);

            }

            System.Windows.Forms.Clipboard.SetText(BankAccoutStr_X.Text);
            CopyBankAccounttoClipboard(BankAccoutStr_X.Text);
        }

        private void button_CopyAllBankAccount_Click(object sender, EventArgs e)
        {
            string str = AccountString.Text;

            if (str.Equals("BankAccoutStr"))
            {
                button_GenerateBankAccount_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(AccountString.Text);

            }

            str = BankAccoutStr_A.Text;

            if (str.Equals("BankAccoutStr_A"))
            {
                button_GenerateBankAccountA_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(BankAccoutStr_A.Text);

            }
            str = BankAccoutStr_B.Text;

            if (str.Equals("BankAccoutStr_B"))
            {
                button_GenerateBankAccountB_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(BankAccoutStr_B.Text);

            }
            str = BankAccoutStr_D.Text;

            if (str.Equals("BankAccoutStr_D"))
            {
                button_GenerateBankAccountD_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(BankAccoutStr_D.Text);

            }

            str = BankAccoutStr_E.Text;

            if (str.Equals("BankAccoutStr_E"))
            {
                button_GenerateBankAccountE_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(BankAccoutStr_E.Text);

            }
            str = BankAccoutStr_F.Text;

            if (str.Equals("BankAccoutStr_F"))
            {
                button_GenerateBankAccountF_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(BankAccoutStr_F.Text);

            }
            str = BankAccoutStr_G.Text;

            if (str.Equals("BankAccoutStr_G"))
            {
                button_GenerateBankAccountG_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(BankAccoutStr_G.Text);

            }

            str = BankAccoutStr_X.Text;

            if (str.Equals("BankAccoutStr_X"))
            {
                button_GenerateBankAccountX_Click(sender, e);
                System.Windows.Forms.Clipboard.SetText(BankAccoutStr_X.Text);

            }

            string accountInfoAll = "\r\n" + AccountString.Text + "\r\n" + BankAccoutStr_A.Text + "\r\n" + BankAccoutStr_B.Text + "\r\n" + BankAccoutStr_D.Text + "\r\n" + BankAccoutStr_E.Text + "\r\n" + BankAccoutStr_F.Text + "\r\n" + BankAccoutStr_G.Text + "\r\n" + BankAccoutStr_X.Text;

            System.Windows.Forms.Clipboard.SetText(accountInfoAll);
            CopyBankAccounttoClipboard(accountInfoAll);
        }


        public void checkSettings()
        {
            checkAccountBaseSetting();
            checkSuffixSetting();
        }

        public void checkAccountBaseSetting()
        {
            if (checkBox_AccountBase_7digits.Checked == true || checkBox_AccountBase_8digits.Checked == false)
            {
                BankAccountGenerator.accountBaseLengthSetting = "7";
            }

            if (checkBox_AccountBase_8digits.Checked == true || checkBox_AccountBase_7digits.Checked == false)
            {
                BankAccountGenerator.accountBaseLengthSetting = "8";
            }

            if (checkBox_AccountBase_7digits.Checked == true && checkBox_AccountBase_8digits.Checked == true)
            {
                MessageBox.Show("Bank Account Base Length Setting cannot be 7 digits and 8 digits at the same time. \r\n It'll be set back to 7 digits.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                checkBox_AccountBase_8digits.Checked = false;
                BankAccountGenerator.accountBaseLengthSetting = "7";
            }
        }

        public void checkSuffixSetting()
        {
            if (checkBox_Suffix_Random3Digits.Checked == true)
            {
                BankAccountGenerator.suffixSetting = "R3";
            }

            if (checkBox_Suffix_Random4Digits.Checked == true)
            {
                BankAccountGenerator.suffixSetting = "R4";
            }

            if (checkBox_Suffix_0000.Checked == true)
            {
                BankAccountGenerator.suffixSetting = "0000";
            }

            if (checkBox_Suffix_000.Checked == true)
            {
                BankAccountGenerator.suffixSetting = "000";
            }
        }

        private void checkBox_AccountBase_7digits_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_AccountBase_8digits.Checked = false;
        }

        private void checkBox_AccountBase_8digits_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_AccountBase_7digits.Checked = false;
        }

        private void checkBox_Suffix_Random3Digits_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox_Suffix_Random3Digits.Checked = true;
            checkBox_Suffix_Random4Digits.Checked = false;
            checkBox_Suffix_0000.Checked = false;
            checkBox_Suffix_000.Checked = false;
        }

        private void checkBox_Suffix_Random4Digits_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Suffix_Random3Digits.Checked = false;
            //checkBox_Suffix_Random4Digits.Checked = true;
            checkBox_Suffix_0000.Checked = false;
            checkBox_Suffix_000.Checked = false;

        }

        private void checkBox_Suffix_000_CheckedChanged(object sender, EventArgs e)
        {

            checkBox_Suffix_Random3Digits.Checked = false;
            checkBox_Suffix_Random4Digits.Checked = false;
            checkBox_Suffix_0000.Checked = false;
            //checkBox_Suffix_000.Checked = true;
        }

        private void checkBox_Suffix_0000_CheckedChanged(object sender, EventArgs e)
        {

            checkBox_Suffix_Random3Digits.Checked = false;
            checkBox_Suffix_Random4Digits.Checked = false;
            //checkBox_Suffix_0000.Checked = true;
            checkBox_Suffix_000.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "")
            {
                textBox_Email.Text = DataGenerator.generateEmail();
            }
            string email = textBox_Email.Text;
            string password = "password1";

            if (BankID.Text == "" || BankBranch.Text == "" || AccountBase.Text == "" || BankSuffix.Text == "")
            {
                checkSettings();
                string accountStr = BankAccountGenerator.getBankAccount();
                AccountString.Text = accountStr;
                BankID.Text = BankAccountGenerator.BankIDStr;
                BankBranch.Text = BankAccountGenerator.BankBranchStr;
                AccountBase.Text = BankAccountGenerator.BankAccountBaseStr;
                BankSuffix.Text = BankAccountGenerator.suffixStr;
            }
            AccountSignupCAT1.InitDriver();
            AccountSignupCAT1.signUp(email, password);
            AccountSignupCAT1.activateEmail(email);
            AccountSignupCAT1.Login(email, password);
            AccountSignupCAT1.registerBankAccount(BankID.Text, BankBranch.Text, AccountBase.Text, BankSuffix.Text);
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        //Validate Bank Account
        private void button2_Click(object sender, EventArgs e)
        {

            string BankID = textBox_VBankID.Text;
            string BankBranch = textBox_VBankBranch.Text;
            string BankAccount = textBox_VBankAccount.Text;
            string BankSuffix = textBox_VBankSuffix.Text;

            if (BankSuffix == null || BankAccount == null || BankBranch == null || BankID == null)
            {
                string msg = "Please input  \r\n " +
                        "BankID - 2 digits \r\n " +
                        "BankBranch - 4 digits \r\n " +
                        "BankAccount - 7 or 8 digits \r\n " +
                        "BankSuffix - 3 or 4 digits \r\n ";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                bool resBankID = BankAccountValidator.validateBankID(BankID);
                bool resBankBranch = BankAccountValidator.validateBankBranch(BankID, BankBranch);
                bool resBankAccount = BankAccountValidator.validateBankAccountBase(BankID, BankBranch, BankAccount, BankSuffix);
                string alg = BankAccountValidator.AlgorithmType;
                string actualCheckDigit = BankAccountValidator.ActualCheckDigit;
                string expectCheckDigit = BankAccountValidator.ExpectCheckDigit;
                if (resBankID == false)
                {
                    string msg = "Invalid Bank ID - " + BankID;
                    MessageBox.Show("Invalid Bank ID", "Invalid Bank ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else if (resBankBranch == false)
                {
                    string msg = "Invalid Bank Branch - " + BankBranch;
                    MessageBox.Show("Invalid Bank Branch", "Invalid Bank Branch", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else if (resBankID == true && resBankBranch == true && resBankAccount == true)
                {

                    string msg = "Valid Bank Account! \r\n " +
                        "AlgorithmType: " + alg + " \r\n " +
                        "actualCheckDigit: " + actualCheckDigit + " \r\n " +
                        "expectCheckDigit: " + expectCheckDigit + " \r\n ";
                    MessageBox.Show(msg, "Valid Bank Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string msg = "Invalid Bank Account! \r\n " +
                        "AlgorithmType: " + alg + " \r\n " +
                        "actualCheckDigit: " + actualCheckDigit + " \r\n " +
                        "expectCheckDigit: " + expectCheckDigit + " \r\n ";
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                }
            }


        }

        private void label45_Click(object sender, EventArgs e)
        {

        }





    }
}

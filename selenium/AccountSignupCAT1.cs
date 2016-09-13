using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using IBM.Data.DB2;
using System.Data;

namespace BankAccountGenerator
{
    public class AccountSignupCAT1
    {
        public static IWebDriver driver;
        public static string ACTIVATION_ID="0";

        public static IWebDriver InitDriver()
        {
            //this.driver = new ChromeDriver(@DriversLocation);
            driver = new ChromeDriver();
            //Implicitly Wait
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            return driver;
        }

        public static void DestroyDriver()
        {
            driver.Quit();
        }
        public static void signUp(String email, String password)
        {
            driver.Navigate().GoToUrl("https://1.cat.mylotto.co.nz/sign-up/");

            driver.FindElement(By.Id("Form_SignupForm_FirstName")).SendKeys("lola");
            driver.FindElement(By.Id("Form_SignupForm_LastName")).SendKeys("test");

            driver.FindElement(By.XPath("//*[@id='BirthdayDay']//*[.='Day']"))
                    .Click();
            driver.FindElement(By.XPath("//*[@id='BirthdayDay']//li[.='22']"))
                    .Click();
            driver.FindElement(By.XPath("//*[@id='BirthdayMonth']//*[.='Month']"))
                    .Click();
            driver.FindElement(By.XPath("//*[@id='BirthdayMonth']//li[.='August']"))
                    .Click();
            driver.FindElement(By.XPath("//*[@id='BirthdayYear']//*[.='Year']"))
                    .Click();
            driver.FindElement(By.XPath("//*[@id='BirthdayYear']//li[.='1980']"))
                    .Click();

            driver.FindElement(By.Id("Form_SignupForm_Gender_F")).Click();

            driver.FindElement(
                    By.XPath("//*[@id='LocationArea']//div[@class='content']"))
                    .Click();
            driver.FindElement(
                    By.XPath("//*[@id='LocationArea']//li[.='Auckland']")).Click();

            Thread.Sleep(1000);
            // driver.findElement(By.XPath("//*[@id='Location']//div[@class='content']")).Click();
            // driver.findElement(By.XPath("//*[@id='Location']//li[.='Rodney']")).Click();

            driver.FindElement(By.Id("Form_SignupForm_PhoneAreaCode")).SendKeys(
                    "021");
            driver.FindElement(By.Id("Form_SignupForm_PhoneNumber")).SendKeys(
                    "2964399");

            driver.FindElement(By.Id("Form_SignupForm_Email")).SendKeys(email);
            driver.FindElement(By.Id("Form_SignupForm_ConfirmEmail")).SendKeys(
                    email);
            driver.FindElement(By.Id("Form_SignupForm_Password"))
                    .SendKeys(password);
            driver.FindElement(By.Id("Form_SignupForm_ConfirmPassword")).SendKeys(
                    password);

            driver.FindElement(
                    By.XPath("//*[@id='Question']//div[@class='content']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(
                    By.XPath("//*[@id='Question']//li[@data-item-value='2']"))
                    .Click();
            driver.FindElement(By.Id("Form_SignupForm_Answer")).SendKeys("XT");

            driver.FindElement(By.Id("Form_SignupForm_TermsAndConditionsAgreed"))
                    .Click();
            // driver.findElement(By.Id("signupButton")).SendKeys(Keys.SPACE);

            driver.FindElement(By.Id("signupButton")).Click();
        }

        public static string getActivationId(string email)
        {
            string strConn = "Server=192.168.101.87:50000;Database=ESI_DB;UID=gtkinst1;PWD=gtkinst1;";
            string strLottoUserSql = @"SELECT ACTIVATION_ID
                                        FROM NZDEV.ES_SECURITY c
                                        inner join ( 
                                        SELECT 
                                        MAX(INSRT_DT) AS MaxDate
                                        FROM NZDEV.ES_SECURITY 
                                        WHERE NZDEV.ES_SECURITY.USER_NAME = '" + email.ToString() + "')m on c.INSRT_DT = m.MaxDate";
            using (DB2Connection conn = new DB2Connection(strConn))
            {
                DB2Command cmd = new DB2Command(strLottoUserSql, conn);
                try
                {
                    conn.Open();

                    DB2DataAdapter adp = new DB2DataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    if (dt != null)
                    {
                            ACTIVATION_ID = dt.Rows[0][0].ToString();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
            }
            Console.Read();
            return ACTIVATION_ID;        
        }

        public static void activateEmail(string email)
        {
            getActivationId(email);
            driver.Navigate().GoToUrl("https://1.cat.mylotto.co.nz/activation?activationid=" + ACTIVATION_ID);
            Thread.Sleep(2000);

        }

        public static void registerBankAccount(string bankId, string bankBranch, string bankAccountBase, string bankSuffix)
        {
            driver.FindElement(By.Id("Form_saveAccountSetUp_Account1")).SendKeys(
                bankId);
            driver.FindElement(By.Id("Form_saveAccountSetUp_Account2")).SendKeys(
                    bankBranch);
            driver.FindElement(By.Id("Form_saveAccountSetUp_Account3")).SendKeys(
                    bankAccountBase);
            driver.FindElement(By.Id("Form_saveAccountSetUp_Account4")).SendKeys(
                    bankSuffix);
            driver.FindElement(
                    By.Id("Form_saveAccountSetUp_action_saveAccountSetUp")).Click();

        }
        
        public static void Login(String email, String password)
        {
            driver.Navigate().GoToUrl("https://1.cat.mylotto.co.nz");
		    Thread.Sleep(2000);

		    driver.FindElement(By.Id("loginLink")).Click();
		    Thread.Sleep(2000);
            driver.FindElement(By.Id("loginForm_UserName")).Clear();
            driver.FindElement(By.Id("loginForm_UserName")).SendKeys(email);
            
            driver.FindElement(By.Id("loginForm_Password")).Clear();
            driver.FindElement(By.Id("loginForm_Password")).SendKeys(password);
            driver.FindElement(By.Id("loginForm_action_login")).SendKeys(Keys.Enter);
        }
    }
}

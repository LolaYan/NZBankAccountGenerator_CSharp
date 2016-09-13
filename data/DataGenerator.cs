using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountGenerator
{
    public class DataGenerator
    {
        public static string allChar = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	    public static string letterChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string numberChar = "0123456789";

        public static int GetRanNumber(int min, int max)
        {
            Random random = new Random();
            int res = random.Next(min, max);
            return res;
        }


        public static string PaddingLeftWithZero(string num, int length)
        {
            string number = num.ToString().PadLeft(length, '0');
            return number;
        }

        public static string PaddingLeftWithZero(int num, int length)
        {
            string number = PaddingLeftWithZero(num.ToString(),length);
            return number;
        }
        public static string generateRandomString(int length, Random random)
        {
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(allChar[random.Next(allChar.Length)]);
            }
            return result.ToString();
        }
        
        // Generate random gmail email address
        public static String generateEmail()
        {
            Random rnd = new Random();
            int length = 11;
            String ccxl = generateRandomString(length, rnd);
            StringBuilder sb = new StringBuilder("FunctionTest." + ccxl);
            sb.Append("@test.com");
            return sb.ToString();
        }

        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

    }
}

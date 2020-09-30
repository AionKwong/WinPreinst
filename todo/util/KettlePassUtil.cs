using System;
using System.Text;
using System.Numerics;
using System.Globalization;

namespace WinPreinst
{
    class KettlePassUtil
    {
        //private const int RADIX = 16;
        private const string SEED = "0933910847463829827159347601486730416058";

        /**
         * kettle 加密方法
         **/
        public static string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "";
            }
            if (password.Length == 0)
            {
                return "";
            }
            char[] cArray = password.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            try
            {
                BigInteger bi_passwd = new BigInteger(Encoding.Default.GetBytes(reverse.Trim()));
                BigInteger bi_r0 = BigInteger.Parse(SEED);
                BigInteger bi_r1 = bi_r0 ^ bi_passwd;
                return bi_r1.ToString("X").ToLower(new CultureInfo("en-US", false));
            }
            catch (FormatException)
            {
                return "";
            }
            
        }

        /**
         * kettle 解密方法
         **/
        public static string DecryptPassword(string encrypted)
        {
            if (string.IsNullOrEmpty(encrypted))
            {
                return "";
            }
            if (encrypted.Length == 0)
            {
                return "";
            }

            BigInteger bi_confuse = BigInteger.Parse(SEED);
            BigInteger bi_r1 = BigInteger.Parse(encrypted, NumberStyles.HexNumber);
            BigInteger bi_r0 = bi_r1 ^ bi_confuse;
            string desc = Encoding.Default.GetString(bi_r0.ToByteArray());
            char[] cArray = desc.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

             

    }



}

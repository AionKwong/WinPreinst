using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WinPreinst
{
    class DesPassUtil
    {
        private const string def_key = "ssky";

        public static string EncryPassword(string str) {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.GetEncoding("UTF-8").GetBytes(str);

                //建立加密对象的密钥和偏移量    
                //原文使用ASCIIEncoding.ASCII方法的GetBytes方法    
                //使得输入密码必须输入英文文本  
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;
                des.Key = ASCIIEncoding.UTF8.GetBytes(def_key);
                des.IV = ASCIIEncoding.UTF8.GetBytes(def_key);
                
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();

                StringBuilder ret = new StringBuilder();
                foreach (byte b in ms.ToArray())
                {
                    ret.AppendFormat("{0:X2}", b);
                }
                return ret.ToString().ToLower(new CultureInfo("en-US", false));
             } catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        public static string DecryPassword(string decryStr) {
            //    HttpContext.Current.Response.Write(pToDecrypt + "<br>" + sKey);   
            //    HttpContext.Current.Response.End();   
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            byte[] inputByteArray = new byte[decryStr.Length / 2];
            for (int x = 0; x < decryStr.Length / 2; x++)
            {
                int i = (Convert.ToInt32(decryStr.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }

            //des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //  des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
            des.Key = ASCIIEncoding.UTF8.GetBytes(def_key);
            des.IV = ASCIIEncoding.UTF8.GetBytes(def_key);

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            //StringBuilder ret = new StringBuilder();

            // return HttpContext.Current.Server.UrlDecode(System.Text.Encoding.Default.GetString(ms.ToArray()));
            return System.Text.Encoding.UTF8.GetString(ms.ToArray());
        }

        /// <summary>
        /// 默认密钥向量
        /// </summary>
        private static readonly byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(string encryptString)
        {
            try
            {
                string encryptKey = ToDES(def_key);
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch(CryptographicException)
            {
                return encryptString;
            }
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString)
        {
            try
            {
                string decryptKey = ToDES(def_key);
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch(CryptographicException)
            {
                return decryptString;
            }
        }

        //对于用户定义的密钥，小于8位在后面加'a'加满8位，大于8位就取前八位！

        /// <summary>
        /// 将一个不是8位字符串转成8位！！
        /// </summary>
        /// <param name="str"></param>
        public static string ToDES(string str)
        {
            if (str.Length <= 8)
            {
                str = str.ToLower(new CultureInfo("en-US",false)).PadRight(8, '0');//在字符串右边加a加满8位！！！
                return str;
            }
            else
            {
                str = str.Remove(9);//把第九位以后的字符删完！
                return str;
            }
        }
    }

}

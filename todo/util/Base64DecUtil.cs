using System;
using System.IO;
using System.IO.Compression;


namespace WinPreinst.todo.util
{
    class Base64DecUtil
    {
        public static string DecBase64(string base64) 
        {
            string result;
            try {
                byte[] decompressedBytes = Decompress(base64);
                result = System.Text.Encoding.GetEncoding("GBK").GetString(decompressedBytes);
            } catch (Exception e) {
                throw new Exception("输入的不是有效的BASE64字符串。",e);
            }
            return result;
        }

        public static byte[] Decompress(string base64Compressed)
        {
            // 将Base64编码的字符串解码为字节数组
            byte[] compressedBytes = Convert.FromBase64String(base64Compressed);

            // 使用内存流来存储解压缩后的数据
            using (var memoryStream = new MemoryStream(compressedBytes))
            {
                using (var gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    // 创建一个内存流来存储解压缩后的数据
                    using (var outputStream = new MemoryStream())
                    {
                        // 将解压缩的数据复制到outputStream
                        gzipStream.CopyTo(outputStream);

                        // 将解压缩后的数据转换为字节数组并返回
                        return outputStream.ToArray();
                    }
                }
            }
        }


    }
}

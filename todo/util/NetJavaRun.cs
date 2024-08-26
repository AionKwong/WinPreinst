using System;
using System.Diagnostics;
using System.IO;

namespace WinPreinst.todo.util
{
    class NetJavaRun
    {
        private const string fileName = "DesPassWord";

        public const string msg = "使用C#加解密,请设置密码key(长度8位),且加解密必须使用相同的key";

        public const string checkMsg = "请检查执行程序目录下是否存在DesPassWord.class文件";
        private const string Value = "&exit";

        public static String Exec(string type, string execText) {
            // 创建一个新的进程对象
            Process process = new Process();

            // 设置进程的启动信息
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;

            // 启动进程
            process.Start();

            // 向cmd发送命令
            process.StandardInput.WriteLine("java " + fileName + " " + type + " " + execText + " &exit");
            // 读取cmd的输出结果
            string output = process.StandardOutput.ReadToEnd();

            // 关闭进程
            process.Close();

            // 输出结果
            //Console.WriteLine(output);

            return ProcessResult(output);
        }

        public static String ProcessResult(string result) {
            if (string.IsNullOrEmpty(result)) {
                return "";
            }
            int index = result.IndexOf(Value);
            if (index > 0 )
            {
                result = result.Substring(index+5).Trim();
            }
            return result;
        
        }

        public static Boolean CheckFile() {
            string filePath = fileName + ".class";
            return File.Exists(filePath);
        }


    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace GenericConsole
{
    class Program
    {
        private static string batchFileContents = "exit";
        private static bool redirectStandardOutput = true;

        static void Main(string[] args)
        {
            batchFileContents = "";
            batchFileContents += "\r\n";

            batchFileContents = batchFileContents.Replace("$&$", "\"");

            File.WriteAllText(Path.Combine(Path.GetTempPath(), "temp.bat"), batchFileContents);

            Process prc = new Process();
            prc.StartInfo = new ProcessStartInfo(Path.Combine(Path.GetTempPath(), "temp.bat"));

            if (redirectStandardOutput == true)
            {
                prc.StartInfo.UseShellExecute = false;
            }
            else
            {
                prc.StartInfo.UseShellExecute = true;
            }

            prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            prc.StartInfo.RedirectStandardOutput = redirectStandardOutput;

            prc.Start();
            StreamReader sr = null;

            if (redirectStandardOutput == true)
            {
                sr = prc.StandardOutput;
            }
            else
            {
                Console.WriteLine("Executing batch file...");
            }

            while (prc.HasExited == false)
            {
                if (sr != null)
                {
                    string cmdOutput = sr.ReadLine();

                    if (cmdOutput != null && cmdOutput.Length != 0)
                    {
                        Console.WriteLine(cmdOutput);
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("This application was created using the Open Source Software BatToExe!");
            Console.WriteLine("Use BatToExe to convert batch files (*.bat) to executable files (*.exe)");
            Console.WriteLine("Download more free open source software at http://SoftwareByDefault.com");

            File.Delete(Path.Combine(Path.GetTempPath(), "temp.bat"));
        }
    }
}

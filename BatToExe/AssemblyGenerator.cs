using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace SoftwareByDefault.OpenSource.BatToExe
{
    public static class AssemblyGenerator
    {
        public static bool Generate(string batchFile, string outputExe, bool showOutput)
        {
            bool retValue = false;

            //In the directory where BatToExe.exe is located delete possible previous temporary executable files before compiling new assembly
            if(File.Exists(Path.GetFileName(outputExe)) == true)
            {
                File.Delete(Path.GetFileName(outputExe));
            }

            CSharpCodeProvider compiler = new CSharpCodeProvider();
            CompilerParameters comParms = new CompilerParameters();
            
            comParms.GenerateExecutable = true;
            comParms.GenerateInMemory = false;
            comParms.IncludeDebugInformation = false;

            comParms.TempFiles = new TempFileCollection(Path.GetTempPath());
            comParms.MainClass = "GenericConsole.Program";
            comParms.CompilerOptions = "/optimize";
            comParms.OutputAssembly = Path.GetFileName(outputExe);
            comParms.TreatWarningsAsErrors = false;
            
            comParms.ReferencedAssemblies.AddRange(new string[] {"mscorlib.dll", "System.dll", "System.Data.dll", "System.Xml.dll" });

            //Update template source code to reflect batch file contents
            string source = CreateSourceCode(batchFile, showOutput);
            // Move to temp dir so compilation files are safe to write
            Directory.SetCurrentDirectory(Path.GetTempPath());
            //Perform actual compilation
            CompilerResults comRes = compiler.CompileAssemblyFromSource(comParms, source);

            //Check if compilation was successful
            if (comRes.Errors != null && comRes.Errors.Count == 0)
            {
                //Move temporary executable file to user specified output directory
                
                if (File.Exists(outputExe) == true)
                {
                    File.Delete(outputExe);
                }

                File.Move(Path.GetFileName(outputExe), outputExe);
                retValue = true;
            }
            else
            {
                String temp = "Compilation errors:";
                foreach (CompilerError error in comRes.Errors)
                {
                    temp += error.ToString() + "\n";
                }
                File.WriteAllText(outputExe, temp);
            }

            return retValue;
        }

        private static string CreateSourceCode(string batchFile, bool showOutput)
        {
            StringBuilder sourceCode = new StringBuilder(GetGenericSource());
            string batchContent = File.ReadAllText(batchFile);
            //Command Line instructions often contain double quotes -> " <- which prematurely terminates string assignment
            //resulting in compilation errors. As a work around, replace all double quotes with $&$ before compiling. 
            //Before executing command line script apply the same logic in reverse, replace all instances of $&$ with "
            batchContent = batchContent.Replace("\"", "$&$");

            sourceCode.Replace("batchFileContents = \"\";", "batchFileContents = " + "@" + "\"" + batchContent + "\";");

            if (showOutput == false)
            {
                sourceCode.Replace("redirectStandardOutput = true", "redirectStandardOutput = false");
            }

            return sourceCode.ToString();
        }

        /// <summary>
        /// Retrieving source code template, pay special attention!
        /// </summary>
        /// <returns></returns>
        private static string GetGenericSource()
        {
            //The source code template used in run-time compilation forms part of this Visual Studio Solution: GenericConsole.cs
            //GenericConsole.cs has been added as an embedded resource to this project, with Persistence configured as:
            // "Linked at compile time" -- The result being any changes made to the template file aka GenericConsole.cs will 
            //always update the embedded resource

            return BatToExe.Properties.Resources.GenericConsole;
        }
    }
}

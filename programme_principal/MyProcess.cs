using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace programme_principal
{
    class MyProcess
    {


        public void fatherProcess()
        {
            var curentProcess = Process.GetCurrentProcess();
            Console.WriteLine("Process Father name = " + curentProcess.ProcessName);
            Console.WriteLine("Process Father ID = " + curentProcess.Id);
        }


        public void closeFatherProcess()
        {
            var curentProcess = Process.GetCurrentProcess();
            curentProcess.Close();
        }


        public void OpenExplorer()
        {
            Process process = new Process();
            process.StartInfo.FileName = "explorer.exe";
            process.Start();
            Console.WriteLine("Process explorer name = " + process.ProcessName);
            Console.WriteLine("Process NotexplorerePad ID = " + process.Id);  
            process.WaitForExit();
        }


        public void OpenExplorerWithArgument(string argument)    // QUESTION 4
        {
            Process process = new Process();
            process.StartInfo.FileName = "explorer.exe";
            process.StartInfo.Arguments = argument;
            process.Start();
            Console.WriteLine("Process explorer name = " + process.ProcessName);
            Console.WriteLine("Process explorer Pad ID = " + process.Id);   
        }


        public void OpenFirefox()
        {
            Process process2 = new Process();                   
            process2.StartInfo.FileName = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            process2.StartInfo.Arguments = "WWW.google.com";
            process2.Start();
            Console.WriteLine("Process Firefox ID = " + process2.Id);
        }


        public void OpenNotePad()
        {
            Process process = new Process();                   
            process.StartInfo.FileName = "notepad.exe";
            process.Start();
            Console.WriteLine("Process Notepad name = " + process.ProcessName);
            Console.WriteLine("Process NotePad ID = " + process.Id);   
            process.WaitForExit();
        }


        public void OpenFile(string fileName)
        {
            Process process = new Process();
            process.StartInfo.Verb = "open";

            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.Arguments = fileName;

            process.Start();
           
        }



        public void FindFile(string fileName)
        {
            Process process = new Process();
            process.StartInfo.Verb = "find";

            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.Arguments = fileName;

            process.Start();

        }


        public void alert(object obj, System.EventArgs e)    // QUESTION 6
        {
            Console.WriteLine( $"Exit time    : { ((Process)obj).ExitTime}\n" + $"Exit code    : {  ((Process)obj).ExitCode}\n" );

        }
    }
}

using System;
using System.Diagnostics;
using System.Threading;

namespace programme_principal
{
    class Program
    {
        static void Main(string[] args)
        {

            MyProcess process = new MyProcess();



            /*   QUESTION 1 & QUESTION 2
             * 
                  process.OpenExplorer();    
                  process.OpenFirefox();
                  process.OpenExplorerWithArgument("www.google.com");
             */




            /*     QUESTION 3
             * 
             *     Process processus = new Process();                   
                   processus.StartInfo.FileName = "notepad.exe";
                   processus.Start();
                   processus.WaitForExit();


                   if (processus.HasExited)
                   {
                       process.closeFatherProcess();
                   }
            */




            // process.OpenExplorerWithArgument(@"C:\Users\ASUS\");    // QUESTION 4

            // process.OpenFile(@"C:\Test\yanis.txt");                // QUESTION 5





            /*  QUESTION 6
             * 
             *   
                    Process processus = new Process();
                    processus.StartInfo.FileName = "notepad.exe";
                    processus.EnableRaisingEvents = true;
                    processus.Exited += new EventHandler(process.alert);
                    processus.Start();
                    processus.WaitForExit();

             */


















        }


    }
}

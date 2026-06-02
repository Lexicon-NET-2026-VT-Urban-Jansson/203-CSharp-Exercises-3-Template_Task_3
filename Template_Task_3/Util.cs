using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace Template_Task_3
{

    // --------------------------------------------------------------------
    // *** Edit - Urban Janssson ***
    // --------------------------------------------------------------------
    internal class Util
    {
#if DEBUG
        private const bool doDebug = true;
#else
    private const bool doDebug = false;
#endif

        public const string oneLine = "----------------------------------------------------------------";


        // --------------------------------------------------------------------
        public static void WriteCaption(string cap)
        {
            Console.WriteLine(oneLine);
            Console.WriteLine(cap);
            Console.WriteLine(oneLine);
        }

        // --------------------------------------------------------------------
        public static void WriteProduct(string prodCode, bool edited, bool doLine)
        {
            // Skriv ut produkten
            if (edited)
            {
                Console.WriteLine();
                Console.WriteLine("Registreringen är genomförd.");
                Console.WriteLine();
            }
            if (doLine) Console.WriteLine(oneLine);

            Console.WriteLine($"Produkt: {Program.products[prodCode].Name} " +
                $"| Pris: {Program.products[prodCode].Price} kr " +
                $"| Lagersaldo: {Program.products[prodCode].Stock}");

            if (doLine) Console.WriteLine(oneLine);
        }

        // --------------------------------------------------------------------
        public static void DoLog(string log)
        {
            // Logga händelse
            var nowDateTime = DateTime.Now;
            Program.logMessages.Add(nowDateTime.ToString("yyyy-MM-dd HH:mm:ss") + " - " + log);

            // Skriv ut senaste log i Debug
            // if (doDebug) Debug.WriteLine(logMessages[logMessages.Count - 1].ToString());
            //
            // Efter BRA tips från Dimitris!
            if (doDebug) Debug.WriteLine("======== " + Program.logMessages.Last() + " ========");
        }

        // --------------------------------------------------------------------
        public static string GetInput(string cap, string msg)
        {
            WriteCaption(cap);
            Console.Write(msg);

            string getStr = Console.ReadLine()!;
            getStr = getStr.ToUpper().Trim();
            Console.WriteLine();
            return getStr;
        }

        // --------------------------------------------------------------------
        public static string GetCustomer(string cap, string msg)
        {
            WriteCaption(cap);
            Console.Write(msg);

            string getStr = Console.ReadLine()!;
            getStr = getStr.Trim();
            Console.WriteLine();
            return getStr;
        }

        // --------------------------------------------------------------------
        public static void WriteCustomer(string msg, bool edited, bool doLine)
        {
            // Skriv ut produkten
            if (edited)
            {
                Console.WriteLine("Registreringen är genomförd.");
                Console.WriteLine();
            }
            if (doLine) Console.WriteLine(oneLine);
            Console.WriteLine(msg);
            if (doLine) Console.WriteLine(oneLine);
        }

    }
}

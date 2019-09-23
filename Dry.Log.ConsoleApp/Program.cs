using System;
using System.Net;
using Dry.Log;

namespace Dry.Log.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Temp/";
            DryLog dryLog = new DryLog(filePath, DryLogChoice.isFile);
            dryLog.Debug("Hello World!", HttpStatusCode.NotFound.ToString());
            DryLog dryLog1 = new DryLog(filePath, DryLogChoice.isSqlDatabase);
            dryLog1.Fatal("Hello World!", HttpStatusCode.NotFound.ToString());
            DryLog dryLog2 = new DryLog(filePath, DryLogChoice.isExcel);
            dryLog2.Info("Hello World!", HttpStatusCode.NotFound.ToString());

            Console.WriteLine("Hello World!");
        }

    }
}

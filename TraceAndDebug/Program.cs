using System;
using System.Diagnostics;
using static System.Console;
using System.IO;

namespace TraceAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            // write trace and debug into a file
            Trace.Listeners.Add(new TextWriterTraceListener(
                File.CreateText("log.txt")
            ));
            Trace.AutoFlush = true;
            Debug.WriteLine("Debug says, I am here!");
            Trace.WriteLine("Trace says, I am ready to watch");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace ozy_Test
{
    class Program
    {
        static List<MyBuffer> buffer = new List<MyBuffer>();

        static int bufLast;
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                bufLast = int.Parse(args[1]);
            }
            while (true)
            {
                MyBuffer buf = new MyBuffer();
                buffer.Add(buf);
                if (buffer.Count / 120.4f > 100)
                {
                    ProcessNew();
                    Thread.Sleep(10800000);
                }
            }
        }
        static void ProcessNew()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "ozy_Test.exe";
            proc.StartInfo.Arguments = ("-a " + (buffer.Count + bufLast));
            proc.Start();
        }
    }

    class MyBuffer
    {
        byte[] buf = new byte[10240];

    }
}
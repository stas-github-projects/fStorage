using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace fStorage_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch swatch = new Stopwatch();

            fStorage.fStorage_engine fstorage = new fStorage.fStorage_engine();

            swatch.Start();

            swatch.Stop();

            Console.WriteLine("\nElapsed time: {0} MSec, {1} Ticks",swatch.ElapsedMilliseconds,swatch.ElapsedTicks);
            Console.ReadKey();
        }
    }
}

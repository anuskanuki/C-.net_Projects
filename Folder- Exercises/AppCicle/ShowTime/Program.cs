using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShowTime
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();//to show just in one line, always, and don't crate new update lines every time
                Console.WriteLine($"Actual time: {DateTime.Now.ToString("HH:mm:ss.fff")}");//HH:mm:ss.fff is to show only the time, not the date, but, the date will be dd/MM/yyyy
                Thread.Sleep(100);
            }

        }
    }
}

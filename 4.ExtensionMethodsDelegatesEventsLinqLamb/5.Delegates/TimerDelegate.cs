using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Delegates
{
    public delegate void SampleDelegate(int seconds);

    public delegate void TimeChangedEventHandler(object aSender, EventArgs aEventArgs);

    public class TimerDelegate
    {
        public static void TimerTest(int seconds)
        {
            Stopwatch interval = new Stopwatch();
            interval.Start();

            while (true)
            {
                if (interval.ElapsedMilliseconds == seconds * 1000)
                {
                    Console.WriteLine("Message");
                    interval.Restart();
                }
            }
        }
    }
}

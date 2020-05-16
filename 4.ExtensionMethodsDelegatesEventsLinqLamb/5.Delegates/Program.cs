using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate test = new SampleDelegate(TimerDelegate.TimerTest);
            test(2);
        }
    }
}

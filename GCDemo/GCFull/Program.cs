using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GCFull
{
    class Program
    {
        //http://blog.mouhong.me/

        static void Main(string[] args)
        {
            var timer = new Timer(OnTimerTick, null, 0, period: 2000);
            
            Console.ReadKey();

            //timer.Dispose();

            //GC.KeepAlive(timer);
        }

        private static void OnTimerTick(object state)
        {
            Console.WriteLine("Tick tick - [{0}]", DateTime.Now.ToLongTimeString());

            GC.Collect();
        }
    }

}

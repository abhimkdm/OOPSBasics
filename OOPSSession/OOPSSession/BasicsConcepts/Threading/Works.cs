using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOPSSession.BasicsConcepts.Threading
{
   public  class Works
    {
        public Works() {
            Thread thread1 = new Thread(Work1);
            Thread thread2 = new Thread(Work2);
            thread1.Start();
            thread2.Start();
        }

        public void Work1() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work1 " + i);
                Thread.Sleep(200);
            }
        }

        public void Work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work2 " + i);
                Thread.Sleep(200);
            }
        }
    }
}

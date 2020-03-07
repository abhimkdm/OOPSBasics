using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts.abstraction
{
   public abstract class Shape
    {
        //public int L;
        //public int B;
        public abstract int area(int l, int b);

        public void display() {
            Console.WriteLine("Welcome to abstract");
        }
    }
}

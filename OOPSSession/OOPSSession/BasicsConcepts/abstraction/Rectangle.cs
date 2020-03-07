using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts.abstraction
{
    public class Rectangle : Shape
    {
        public override int area(int l , int b)
        {
            return l * b;
        }
    }
}

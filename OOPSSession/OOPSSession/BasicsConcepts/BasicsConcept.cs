using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts
{
    public class BasicsConcept
    {
        public BasicsConcept() {
        }

        public void DotNetConcepts() {
            int[] eveoddNum = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(eveoddNum[0]);

            for (int i = 0; i < eveoddNum.Length; i++)
            {
                if (eveoddNum[i] % 2 == 0)
                {
                    Console.WriteLine("Even : " + eveoddNum[i]);
                }
                else
                {
                    Console.WriteLine("Odd : " + eveoddNum[i]);
                }
            }

            List<string> colors = new List<string>();
            colors.Add("Green");
            colors.Add("Red");
            colors.Add("White");

            Console.WriteLine("----------------");
            Console.WriteLine("List Of Colors");
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}

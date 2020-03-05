using System;
using OOPSSession.OOPs;
using OOPSSession.BasicsConcepts;
using System.Collections.Generic;

namespace OOPSSession
{
    class Program
    {
        static void Main()
        {
            IPerson person = new Person("Prsannna", "p@gmail.com", 989898989);
            person.Display();
            person.Display("Implemented Display Method");

            int[] eveoddNum = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(eveoddNum[0]);

            for (int i = 0; i < eveoddNum.Length; i++)
            {
                if (eveoddNum[i] % 2 == 0)
                {
                    Console.WriteLine("Even : " + eveoddNum[i]);
                }
                else {
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


            Console.ReadKey();
        }   
    }
}

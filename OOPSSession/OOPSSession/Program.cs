using System;
using OOPSSession.OOPs;
using OOPSSession.BasicsConcepts;
using System.Collections.Generic;
using OOPSSession.BasicsConcepts.abstraction;

namespace OOPSSession
{
    class Program
    {
       public delegate void Display();
       public delegate void EvenNum(int i);
       public static void Main()
        {
            //==>> Abstraction
            Shape rectangle = new Rectangle();
            Console.WriteLine(rectangle.area(10,20));
            rectangle.display();

            //==>Static Class
            //Console.WriteLine(BasicStatic.name);

            //==>> Delegates
            //DelegateMembers();

            Console.ReadKey();
        }


        public static void DelegateMembers() {
            //Practice();

            //Display display = new Display(Message);
            //display.Invoke();
            //Message();

            //EvenNum evenNum = new EvenNum(PrintEven);
            //Numbers(evenNum);
        }

        public static void PrintEven(int i) {
            Console.WriteLine(i);
        }
        public static void Numbers(EvenNum evenNum) {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) {
                    evenNum(i);
                }
            }
        }

        public static void Message()
        {
            Console.WriteLine("Welcome to Delegate Session");
        }
        public static void Practice() {
            //IPerson person = new Person("Prsannna", "p@gmail.com", 989898989);
            //person.Display();
            //person.Display("Implemented Display Method");

            //Exception Handling
            //BasicExceptions basicExceptions = new BasicExceptions();
            //basicExceptions.Divide(10, 0);

            //Collections & Generics
            // Generics<string> generics = new Generics<string>();
            //generics.Collection();
            //generics.Compare("madam","madam");
            //Generics<int> Objgenerics = new Generics<int>();
            //Objgenerics.Compare(10, 20);
            //generics.Dictionaries();
        }
    }
}

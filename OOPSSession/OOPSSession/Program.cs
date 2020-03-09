using System;
using OOPSSession.OOPs;
using OOPSSession.BasicsConcepts;
using System.Collections.Generic;
using OOPSSession.BasicsConcepts.abstraction;
using OOPSSession.BasicsConcepts.Files;
using OOPSSession.BasicsConcepts.Threading;
using MyDLL;
using System.Threading;

namespace OOPSSession
{
    class Program  
    {
       public delegate void Display();
       public delegate void EvenNum(int i);
       
       public static void Main()
        {
            //==>> Abstraction
            //Shape rectangle = new Rectangle();
            //Console.WriteLine(rectangle.area(10,20));
            //rectangle.display();

            //==>Static Class
            Console.WriteLine(BasicStatic.name);

            //==>> Delegates
            //DelegateMembers();

            //==> Events
            //Maths objMaths = new Maths();
            //objMaths.Check += objMaths.Even_Click;
            //objMaths.Check += objMaths.Odd_Click;
            //objMaths.CheckNumbers();

            //==> Memomory Management
            //MemomoryManagement();
            //ManageCode();

            //==> Assembly
            //Print print = new Print();

            //==> Serialization

            // Serialization serialization = new Serialization();
            // Deserialization deserialization = new Deserialization();'

            //==> Threading
            Works works = new Works();
            //works.Work1();
            //works.Work2();

            Console.ReadKey();
        }

        public static void ManageCode() {
            string filePath = @"D:\Personal\Session\.NET\Readme.txt";
            string[] lines = { "First", "Second", "Third" };

            //System.IO.File.WriteAllLines(filePath, lines); //Unmanaged

            //System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filePath);
            //foreach (var item in lines)
            //{
            //    streamWriter.WriteLine(item);
            //}


            //Managed Examples
            //using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filePath))
            //{
            //    foreach (var item in lines)
            //    {
            //        streamWriter.WriteLine(item);
            //    }
            //}

            //IDisposable disposable = new Disposable();

            //try
            //{
            //    System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filePath);
            //    foreach (var item in lines)
            //    {
            //        streamWriter.WriteLine(item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally {
            //    disposable.Dispose();
            //}
        }

        private static void MemomoryManagement()
        {
            Console.WriteLine("Current Memory " + GC.GetTotalMemory(false));
            Maths ObjMaths01 = new Maths();
            Maths ObjMaths02 = new Maths();
            Maths ObjMaths03 = new Maths();
            Console.WriteLine("Gen " + GC.GetGeneration(ObjMaths01));
            GC.Collect();
            Console.WriteLine("Gen " + GC.GetGeneration(ObjMaths02));
            GC.Collect();
            Console.WriteLine("Gen " + GC.GetGeneration(ObjMaths03));

            Console.WriteLine("Current Memory " + GC.GetTotalMemory(false));
        }

        public static void DelegateMembers() {
            //Practice();

            //Display display = new Display(Message);
            //display.Invoke();
            //Message();

            //EvenNum evenNum = new EvenNum(PrintEven);
            //Numbers(evenNum);
            //EvenNum oddNum = new EvenNum(PrintOdd);
            //Numbers(oddNum);
        }

        public static void PrintEven(int i) {
            Console.WriteLine(i);
        }

        public static void PrintOdd(int i) {
            Console.WriteLine(i);
        }
        public static void Numbers(EvenNum num) {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    //num(i); //Even
                }
                else if (i % 2 != 0)
                {
                    //num(i); //Odd
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

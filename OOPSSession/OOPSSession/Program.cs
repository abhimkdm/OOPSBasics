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
            //IPerson person = new Person("Prsannna", "p@gmail.com", 989898989);
            //person.Display();
            //person.Display("Implemented Display Method");

            //Exception Handling
            //BasicExceptions basicExceptions = new BasicExceptions();
            //basicExceptions.Divide(10, 0);

            //Collections & Generics
            Generics<string> generics = new Generics<string>();
            //generics.Collection();
            //generics.Compare("madam","madam");
            //Generics<int> Objgenerics = new Generics<int>();
            //Objgenerics.Compare(10, 20);
            generics.Dictionaries();

            Console.ReadKey();
        }   
    }
}

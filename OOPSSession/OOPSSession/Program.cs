using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Prsannna");
            person.Display();

            Console.ReadKey();
        }

        public class Person {
            public string Name;

            public Person(string name) {
                this.Name = name;
            }

            public void Display() {
                Console.WriteLine("Welcome," + Name);
            }
        }
    }
}

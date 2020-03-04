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
            IPerson person = new Person("Prsannna","p@gmail.com",989898989);
            person.Display();
            person.Display("Implemented Display Method");

            Console.ReadKey();
        }

        public interface IPerson {
           void Display(string text);
           void Display();
        }

        public class ContactDetails {
            public string Email;
            protected int MobileNo;
            private string Password;

            public ContactDetails() {
                //this.Password
            }
        }
        public class Person : ContactDetails, IPerson
        {
            public string Name;

            public Person(string name, string email, int mobno) {
                this.Name = name;
                this.Email = email;
                this.MobileNo = mobno;
            }

            public void Display() {
                Console.WriteLine("Welcome," + Name);
                Console.WriteLine("Email," + Email);
                Console.WriteLine("MobNo," + MobileNo);
            }

            public void Display(string text)
            {
                Console.WriteLine(text);
            }
        }
    }
}

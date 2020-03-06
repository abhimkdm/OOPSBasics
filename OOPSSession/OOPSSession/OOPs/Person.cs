using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.OOPs
{
    public class Person : ContactDetails, IPerson
    {
        public string Name;

        public Person(string name, string email, int mobno)
        {
            this.Name = name;
            this.Email = email;
            this.MobileNo = mobno;
        }

        public void Display()
        {
            Console.WriteLine("Welcome," + Name);
            Console.WriteLine("Email," + Email);
            Console.WriteLine("MobNo," + MobileNo);
        }

        public void Display(string text)
        {
            throw new NotImplementedException();
        }
    }
}

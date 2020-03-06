using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts
{
   public class Generics<T>
    {

        public void Compare(T a, T b) {
          Console.WriteLine(a.Equals(b));
        }

        public void Dictionaries() {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>() {
                {"username", "admin"},
                {"password", "manage" }
            };

            foreach (var item in keyValuePairs) {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);

            }
        }

        public void Collection()
        {
            List<string> colors = new List<string>(2);
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

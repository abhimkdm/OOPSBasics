using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts.Files
{
    [Serializable]
    public class Person
    {
        public int id;
        public string name;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
    }
}

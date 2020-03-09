using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts.Files
{
    public class Deserialization
    {
        public Deserialization() {
            string path = @"D:\Personal\Session\.NET\Readme.doc";

            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            BinaryFormatter formater = new BinaryFormatter();

            Person person = (Person)formater.Deserialize(stream);


            Console.WriteLine("Id :" + person.id);

            Console.WriteLine("Name :" + person.name);
        }
    }
}

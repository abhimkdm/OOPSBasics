using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts.Files
{
    public class Serialization
    {
        public Serialization() {

            string path = @"D:\Personal\Session\.NET\Readme.doc";

            Person person = new Person(1, "Abhishek");

            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            BinaryFormatter formater = new BinaryFormatter();

            formater.Serialize(stream, person);

            stream.Close();

            Console.WriteLine("File saved in " + path);

        }
    }
}

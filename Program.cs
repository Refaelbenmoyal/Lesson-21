using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyHonda = new Car()
            {
                model = "Honda",
                brand = "civic",
                year = 2020,
                color = "black",
            };
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car));

            /// using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Create)) // creating new file stream
            /// {
            ///     myXmlSerializer.Serialize(file, "Honda");
            /// }
            Car MyHonda1;


            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                MyHonda1 = myXmlSerializer.Deserialize(file) as Car;

            }
            Car[] pArray =
           {
                new Car("MyHonda"),
                new Car("MyFiat"),
                new Car("MyMazda")
            };
            XmlSerializer myXmlSerializerArray = new XmlSerializer(typeof(Car[]));
           ///  using (Stream file = new FileStream(@"c:\temp\xmlarrayfile.xml", FileMode.Create)) // creating new file stream
           ///{
           /// myXmlSerializerArray.Serialize(file, pArray);

          ///  }
        Car[] p2Array;
            using (Stream file =  new FileStream(@"c:\temp\xmlarrayfile.xml", FileMode.Open)) // creating new file stream
            {
                p2Array = myXmlSerializerArray.Deserialize(file) as Car[];
            } //closing file stream
    
            Console.WriteLine();
        }
    }
}
using System;
using System.IO;
using System.Xml.Serialization;


namespace Xml_saving_grejs
{
    class Program
    {
        static void Main(string[] args)
        {
            //string svar = ""//




            //     Enemy a1 = new Enemy();


            //     Console.WriteLine("Vad för namn ska fienden ha?");
            //     a1.name = Console.ReadLine();

            //     Console.WriteLine("Fienden heter nu " + a1.name );

            //     XmlSerializer enemySerializer = new XmlSerializer(typeof(Enemy));

            //     using (FileStream file = File.Open(@"enemy.xml", FileMode.OpenOrCreate))
            //     {
            //       enemySerializer.Serialize(file, a1);
            //    }


            XmlSerializer enemySerializer = new XmlSerializer(typeof(Enemy));


            Console.WriteLine("Vill du ladda in en gammal xml-fil skriv .ja. Vill du göra en ny skriv nej");
            string svar = Console.ReadLine();


            Enemy a2;

            if (svar == "ja")
            {

                

                using (FileStream file = File.Open(@"enemy.xml", FileMode.OpenOrCreate))
                {
                    a2 = (Enemy)enemySerializer.Deserialize(file);
                }

                Console.WriteLine("Fienden heter nu " + a2.name);

            }

            else if (svar == "nej")
            {

                Console.WriteLine("Vad för namn ska fienden ha?");
                a2 = new Enemy();
                a2.name = Console.ReadLine();

                Console.WriteLine("Fienden heter nu " + a2.name);

                XmlSerializer enemy1Serializer = new XmlSerializer(typeof(Enemy));

                using (FileStream file = File.Open(@"enemy.xml", FileMode.OpenOrCreate))
                {
                    enemy1Serializer.Serialize(file, a2);
                }

            }
            Console.ReadLine();





        }
    }
}

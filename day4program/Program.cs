using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("melina");
            names.Add("Anju");
            names.Add("Mana");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            ////using hash table
            //Hashtable names = new Hashtable();
            //names.Add("Name", "Melina");
            //names.Add("Age", 21);
            //names.Add("isMarried", false);
            //foreach (var item in names.Keys)
            //{
            //    Console.WriteLine(item + ":" + names[item]);
            //}
            //using arrays 
            //ArrayList names = new ArrayList();
            //names.Add("Melina");
            //names.Add(true);
            //names.Add(9846);
            ////string rakhda string matra print hunxa so using var
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
            //collection in c sharp notes
            //constructor ko lagi gareko program
            //animal Animal = new animal();
            //animal cow = new animal("cow");
            //Console.ReadKey();
            //StreamReader sr = new StreamReader("hello.txt");
            //string line=sr.ReadLine();
            //while(line!=null)
            //    {
            //    Console.WriteLine(line);
            //    line=sr.ReadLine();
            //}
            //notes garaune constructor ani garbage collector
            //for printing one line ko lagi esto gareko aba sab print garna lai chahi while use gareko 
            // string line=sr.ReadLine();
            //   Console.WriteLine(line);
            //for writing in the file ho yo program chahi
            //StreamWriter sw = new StreamWriter("Hello.txt");
            //sw.WriteLine("I am a student");
            //sw.WriteLine("I study CSIT in BMC");
            //sw.WriteLine("Learning file handling");
            //sw.WriteLine("I am Melina");
            //sr.Close();
            //Console.ReadKey();
            //yo pani file write garne tarika nai ho tara yo vanda stream garera sajilo xa 
            //  FileStream file = new FileStream("myfile.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            ////  file.WriteByte((byte)10);
            //  Console.WriteLine(file.ReadByte());
            //  file.Close();
            //  Console.ReadKey();
        }
    }
}

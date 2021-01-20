using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Murat",
            //    "Kamil", "Mehmet" };
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[0]);

            List<string> isimler2 = new List<string> {"Engin","Kamil",
            "Kerem","Mehmet"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}

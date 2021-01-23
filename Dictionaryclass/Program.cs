using System;
using System.Collections.Generic;

namespace Dictionaryclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(123, "muhammed");
            Ogrenci.Add(253, "dsfg");
            Ogrenci.Add(623, "melteed");
            Ogrenci.Add(323, "cengiz");
            Ogrenci.Add(423, "mustafa");
            Ogrenci.Add(823, "ali");

            bool varmi = Ogrenci.ContainsKey(323);
            Console.WriteLine("Ögrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch 
            {

                Console.WriteLine("Ögrenci Bulunamadı") ;
            }

        }
    }
}

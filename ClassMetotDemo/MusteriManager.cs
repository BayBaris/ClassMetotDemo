using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri:");
            Console.WriteLine("ID: {0}; Adı: {1} / Soyadı: {2} ",musteri.ID ,musteri.Name,musteri.Surname);
            Console.WriteLine("----------------------------------");

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silinen Muşteri:");
            Console.WriteLine("ID: {0}; Adı: {1} / Soyadı: {2} ", musteri.ID, musteri.Name,musteri.Surname);
            Console.WriteLine("----------------------------------");
        }

        public void ListMusteri(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi");
            Console.WriteLine("---------------------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("ID: {0}" ,musteri.ID);
                Console.WriteLine("Adı: {0} - Soyadı: {1}",musteri.Name,musteri.Surname);
                Console.WriteLine("Yaşı: {0}",musteri.Age);
                Console.WriteLine("-------------------------");
            }

        }
    }
}

using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 21156;
            musteri1.Age = 19;
            musteri1.Name = "Umut Can";
            musteri1.Surname = "Karaoğlan";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 23115;
            musteri2.Age = 33;
            musteri2.Name = "Sait Faik";
            musteri2.Surname = "Abasıyanık";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 45799;
            musteri3.Age = 20;
            musteri3.Name = "Barış";
            musteri3.Surname = "Karakaya";

            Musteri musteri4 = new Musteri();
            musteri4.ID = 75678;
            musteri4.Age = 21;
            musteri4.Name = "Osman";
            musteri4.Surname = "Elalmış";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            int item_key = 0;
            while (item_key != 4)
            {
                Console.WriteLine("işlem Seçiniz:\n" +
                    "1)Add\n" +
                    "2)Delete\n" +
                    "3)List\n" +
                    "4)Exit\n");

                item_key = int.Parse(Console.ReadLine());
                if (item_key == 1)
                {
                    musteriManager.Add(musteri1);
                    musteriManager.Add(musteri2);
                }
                else if (item_key == 2)
                {
                    musteriManager.Delete(musteri3);
                    musteriManager.Delete(musteri4);
                }
                else if (item_key == 3)
                {
                    musteriManager.ListMusteri(musteriler);
                }
                else
                {
                    break;
                }
            }

        }
    }
}

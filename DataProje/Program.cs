using System;
using System.Collections;
using System.Collections.Generic;

namespace DataProje
{

   
 

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            string[] MusteriAd = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", "Songül", "Nuri", "Deniz" };
            int[] urunAd = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            ArrayList arraylist = new ArrayList();
            int musteriSayaci = 0;
            MusteriSınıfı musteriSınıfı;
            List<MusteriSınıfı> genericListe;
            Random rnd = new Random();
            int ListeS = 0;
            while (musteriSayaci < MusteriAd.Length)
            {
                genericListe = new List<MusteriSınıfı>();
                int genericListLegnth = (int)rnd.Next(1, 6);
                for (int j = 0; j < genericListLegnth; j++)
                {
                    musteriSınıfı = new MusteriSınıfı(MusteriAd[musteriSayaci], urunAd[musteriSayaci]);
                    genericListe.Add(musteriSınıfı);
                    musteriSayaci++;

                    if (musteriSayaci == MusteriAd.Length)
                        break;


                }
                ListeS++;
                arraylist.Add(genericListe);


            }

            Yigit Stack = new Yigit(MusteriAd.Length);
            Queue Kuyruk = new Queue(MusteriAd.Length);
            PQueue OKuyruk = new PQueue();
            PQueue OKuyruk1 = new PQueue();
            for (int i = 0; i < MusteriAd.Length; i++)
            {
                musteriSınıfı = new MusteriSınıfı(MusteriAd[i], urunAd[i]);
                Stack.push(musteriSınıfı);
                Kuyruk.Ekle(musteriSınıfı);

            }
            Console.WriteLine("---------------Yığıt Denemesi------------");
            while (!Stack.isEmpty())
            {
                MusteriSınıfı Obje = Stack.pop();
                Console.WriteLine("{0}, {1}", Obje.musteriIsmi, Obje.urunSayisi);



            }
            Console.WriteLine("---------------Kuyruk Denemesi------------");
            double Sure = 0;
            double MusteriSayısı = 0;
            while (!Kuyruk.BosMu())
            {
                MusteriSınıfı Obje = Kuyruk.Sil();
                Console.WriteLine("{0}, {1}", Obje.musteriIsmi, Obje.urunSayisi);
                MusteriSayısı++;
                Sure += Obje.urunSayisi;
                double ortalamaSure = (Sure / MusteriSayısı);
                Console.WriteLine("Ortalama Süre = " + ortalamaSure);


            }
            Console.WriteLine("---------------Bileşik Yapı------------");
            int genericSayac = 0;
            foreach (List<MusteriSınıfı> item in arraylist)
            {
                genericSayac++;
                Console.WriteLine("**********Generic Liste{0}***********", genericSayac);
                foreach (MusteriSınıfı item1 in item)
                {

                    Console.WriteLine("{0}, {1}", item1.musteriIsmi, item1.urunSayisi);

                }
                Console.WriteLine();
            }
            Console.WriteLine("*********Liste Sayısı ve Ortalamaları**********");
            Console.WriteLine("Liste Sayısı = " + ListeS + "   Ortalama Sayısı =  " + (musteriSayaci / ListeS));
            for (int i = 0; i < MusteriAd.Length; i++)
            {
                musteriSınıfı = new MusteriSınıfı(MusteriAd[i], urunAd[i]);
                OKuyruk.Ekle(musteriSınıfı);
                OKuyruk1.Ekle(musteriSınıfı);

            }
            Console.WriteLine("---------------Azalan Sırada Silinen Öncelikli Kuyruk Yapısı------------");
            double Sure1 = 0;
            double MusteriSayısı1 = 0;
            while (!OKuyruk.BosMu())
            {
                MusteriSınıfı Obje2 = OKuyruk.ArtanSil();
                Console.WriteLine("{0}, {1}", Obje2.musteriIsmi, Obje2.urunSayisi);
                MusteriSayısı1++;
                Sure1 += Obje2.urunSayisi;
                double ortalamaSure1 = (Sure1 / MusteriSayısı1);
                Console.WriteLine("Ortalama Süre = " + ortalamaSure1);



            }
            Console.WriteLine("---------------Artan Sırada Silinen Öncelikli Kuyruk Yapısı------------");
            double Sure2 = 0;
            double MusteriSayısı2 = 0;
            while (!OKuyruk1.BosMu())
            {
                MusteriSınıfı Obje2 = OKuyruk1.AzalanSil();
                Console.WriteLine("{0}, {1}", Obje2.musteriIsmi, Obje2.urunSayisi);
                MusteriSayısı2++;
                Sure2 += Obje2.urunSayisi;
                double ortalamaSure2 = (Sure2 / MusteriSayısı2);
                Console.WriteLine("Ortalama Süre = " + ortalamaSure2);

            }

            Console.ReadKey();
        }

    }
}

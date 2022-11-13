using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produckt produckt1 = new Produckt();
            produckt1.Name = "Pc";
            produckt1.Description = "Büyük indirimde";
            produckt1.Fiyat = 1500;

            Produckt produckt2 = new Produckt();
            produckt2.Name = "Tel";
            produckt2.Description = "Yeni model";
            produckt2.Fiyat = 1200;

            Produckt produckt3 = new Produckt();
            produckt3.Name = "Kamera";
            produckt3.Description = "1080p";
            produckt3.Fiyat = 900;

            Produckt[] produckts = new Produckt[] { produckt1, produckt2, produckt3 };

            for (int i = 0; i < produckts.Length; i++)
            {
                Console.WriteLine("Ürünün adı: " + produckts[i].Name);
                Console.WriteLine("Ürünün açıklaması: " + produckts[i].Description);
                Console.WriteLine("Ürünün fiyatı: " + produckts[i].Fiyat);
                Console.WriteLine();
            }
            foreach (Produckt produckt in produckts)
            {
                Console.WriteLine("Ürünün adı: " + produckt.Name + "\n" + "Ürünün açıklaması: " + produckt.Description + "\n" + "Ürünün fiyatı: " + produckt.Fiyat);
                Console.WriteLine();
            }

            int x = 0;
            while (x < produckts.Length)
            {
                Console.WriteLine("Ürünün adı: " + produckts[x].Name);
                Console.WriteLine("Ürünün açıklaması: " + produckts[x].Description);
                Console.WriteLine("Ürünün fiyatı: " + produckts[x].Fiyat);
                Console.WriteLine();
                x++;
            }




            Console.ReadLine();

        }
    }

    class Produckt
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Fiyat { get; set; }

    }
}

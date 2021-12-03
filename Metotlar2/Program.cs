using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);


            //Metot Aşırı Yükleme = Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Kübra", 27);

            //Metot İmzası
            //Metot Adı + Parametre Sayısı + Parametre 

            Console.ReadKey();

        }
    }

    class Metotlar
    {
        public void Topla(int a,int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri1)
        {
            Console.WriteLine(veri1);
        }
        public void EkranaYazdir(int veri1)
        {
            Console.WriteLine(veri1);
        }
        public void EkranaYazdir(string veri1, int veri2)
        {
            Console.WriteLine(veri1);
        }
    }
}

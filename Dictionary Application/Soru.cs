using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Dictionary_Application
{
    class Soru
    {
        private List<string> satirlar;
        private string [] choices = new string[4];
        private Kelime kelime = new Kelime();
        public string soruKelimesi;
         

        public Soru()
        {
            //Sözlükteki bütün kelimeleri satırlar listesine aktardık.
            satirlar = kelime.OkumaIslemi("Sözlük.txt");
        }

        //Bu metod doğru kelimeyi ve sözlükten aldığı rastgele 3 kelimeyi kullanarak şıkları choises dizisine atıyor.
        //Ardından choises dizisini geriye döndürüyor.
        public string [] SoruOlustur(Kelime dogruKelime)
        {
            kelime = dogruKelime;
            int i;
            string[] satirlar = new string[3];

            for ( i = 0; i < this.satirlar.Count; i++)
            {
                satirlar = Regex.Split(this.satirlar[i], @"\s");

                if(satirlar[0] == dogruKelime.kelimeAdi)
                {
                    soruKelimesi = satirlar[1];
                }
            }

            Random random = new Random();
            choices[0] = dogruKelime.kelimeAdi;
            int sayac=1;
            string geciciKelime;
            

            while (sayac < 4)
            {
                bool eslesmeDurumu = false;

                int sira = random.Next(0, this.satirlar.Count);
                satirlar = Regex.Split(this.satirlar[sira], @"\s");

                geciciKelime = satirlar[0];
                
                for (i = 0; i < 3; i++)
                {
                    if (geciciKelime == choices[i])
                    {
                        eslesmeDurumu = true;
                        break;
                    }

                }

                if (eslesmeDurumu == false)
                {
                    choices[sayac] = geciciKelime;
                    sayac++;
                }
            }

            return choices;
        }

        //Bu metod kullanıcının verdiği cevabın doğruluğunu kontrol ediyor.
        public bool CevapKontrol(string cevap)
        {

            if (cevap == kelime.kelimeAdi)
                return true;

            else
            {
                return false;
            }
        }
    }
}

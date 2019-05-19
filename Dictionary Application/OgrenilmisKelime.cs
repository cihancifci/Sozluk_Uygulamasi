using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dictionary_Application
{
    public class OgrenilmisKelime : Kelime
    {
        List<string> tumOgrenilmisKelimeler = new List<string>();

        public OgrenilmisKelime()
        {
            //Öğrenilmiş kelimler dosyasındaki tüm satırları tumOgrenilmisKelimeler listesine atıyoruz
            tumOgrenilmisKelimeler = OkumaIslemi("Öğrenilmiş Kelimeler.txt");

        }

        //Bu metod kullanıcı sadece yılla arama yapmak isterse o yılda öğrendiği kelimeleri bi liste halinde döndürüyor.
        public List<string> KelimeleriBelirle(int yil)
        {
            List<string> kelimeler = new List<string>();
            string[] okunanlar = new string[Regex.Split(tumOgrenilmisKelimeler[0], @"\s").Length];

            for(int i=0; i < tumOgrenilmisKelimeler.Count; i++)
            {
                okunanlar = Regex.Split(tumOgrenilmisKelimeler[i], @"\s");

                if(yil == int.Parse(okunanlar[2].Split('.')[2]))
                {
                    kelimeler.Add(okunanlar[0] + "\t" +okunanlar[2]);

                }
            }
            
            return kelimeler;
        }

        //Bu metod kullanıcı ay ve yıl ile arama yapmak isterse seçtiği ayda öğrendiği kelimeleri bi liste halinde döndürüyor.
        public List<string> KelimeleriBelirle(int ay,int yil)
        {
            List<string> kelimeler = new List<string>();
            string[] okunanlar = new string[Regex.Split(tumOgrenilmisKelimeler[0], @"\s").Length];

            for (int i = 0; i < tumOgrenilmisKelimeler.Count; i++)
            {
                okunanlar = Regex.Split(tumOgrenilmisKelimeler[i], @"\s");

                if (yil == int.Parse(okunanlar[2].Split('.')[2]) && ay == int.Parse(okunanlar[2].Split('.')[1]))
                {
                    kelimeler.Add(okunanlar[0] + "\t" + okunanlar[2]);

                }
            }

            return kelimeler;
        }


        //Bu metod belirlenen yıllar arasında hangisinde daha çok kelime öğrenilmişse o yılda öğrenilen kelime sayısını maximum kelime sayısı olarak belirliyor
        public int MaxSkorBelirle(int baslangicYil,int bitisYil)
        {
            int maxKelimeSayisi = 0;
            int tempKelimeSayisi = 0;
            for(int yilSayac = baslangicYil ; yilSayac<=bitisYil ; yilSayac++)
            {
                tempKelimeSayisi = KelimeleriBelirle(yilSayac).Count;
                if (maxKelimeSayisi < tempKelimeSayisi)
                {
                    maxKelimeSayisi = tempKelimeSayisi;
                }
            }

            return maxKelimeSayisi;


        }

        //Bu metod eğer kullanıcı öğrendiği kelimeyi tekrar öğrenmeye başlamak isterse o kelimeyi öğrenilen kelimeler arasından siliyor
        public void KelimeSil(string kelimeAdi, string dosya_yolu)
        {

            List<string> satirlar = new List<string>();
            satirlar = OkumaIslemi(dosya_yolu);

            int sira = KelimeYeriniBul(kelimeAdi, dosya_yolu, 0) - 1;
            satirlar.RemoveAt(sira);

            DosyayiTemizle(dosya_yolu);

            for (int i = 0; i < satirlar.Count; i++)
            {

                DosyayaEkle(satirlar[i], dosya_yolu);
            }
        }



    }
}

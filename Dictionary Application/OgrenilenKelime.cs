using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Application
{
    public class OgrenilenKelime : Kelime
    {

        public int asama;
        public string tarih;


        //Bu metod eğer o günki tarihte soru varsa dosyadan sorulacak kelimenin bilgilerini getiriyor.
        public int SoruVarsaBilgileriDoldur(string aranan,string dosyaYolu)
        {
            try
            {
                string[] okunanlar = new string[Regex.Split(OkumaIslemi(dosyaYolu)[0], @"\s").Length];

                int sira = 0;

                sira = KelimeYeriniBul(aranan, dosyaYolu, 2);

                if (sira != 0)
                {


                    okunanlar = Regex.Split(OkumaIslemi(dosyaYolu)[sira - 1], @"\s");

                    kelimeAdi = okunanlar[0];
                    asama = int.Parse(okunanlar[1]);
                    tarih = okunanlar[2];

                }

                return sira;
            }

            catch { return 0; }
        }

        //Bu metod eğer kullanıcı sorunun olduğu gün programa girmezse girdiğinde o sorunun aşamalarını sıfırlıyor.
        public void gecmisTarihliOgrenmeGuncelle(string dosyaYolu)
        {
            try
            {
                string[] okunanlar = new string[Regex.Split(OkumaIslemi(dosyaYolu)[0], @"\s").Length];

                List<string> satirlar = new List<string>();

                satirlar = OkumaIslemi(dosyaYolu);

                for (int i = 0; i < satirlar.Count; i++)
                {
                    okunanlar = Regex.Split(satirlar[i], @"\s");

                    tarih = okunanlar[2];

                    if (Convert.ToDateTime(tarih) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {

                        kelimeAdi = okunanlar[0];
                        asama = int.Parse(okunanlar[1]);

                        AsamaveTarihGuncelle(false);

                    }
                }
            }

            catch { }
        }
        //Bu metod öğrenilecek kelimeler dosyasına yazılacak bilgileri belirliyor.
        public override string YazilacaklariBelirle()
        {
            base.YazilacaklariBelirle();

            return kelimeAdi.ToLower() + "\t" + asama + "\t" + tarih;
        }


        //Bu fonksiyon kullanıcının cevabının doğruluğuna göre aşamasını ve tarihini güncelliyor
        public void AsamaveTarihGuncelle(bool cevap)
        {

            if (cevap == true)
            {
                if (asama == 4)
                {
                    
                    MessageBox.Show("Tebrikler! Tüm aşamaları bitirdiniz!");

                    List<string> satirlar = new List<string>();
                    satirlar = OkumaIslemi("Öğrenilecek Kelimeler.txt");

                    int sira = KelimeYeriniBul(kelimeAdi, "Öğrenilecek Kelimeler.txt", 0) - 1;
                    DosyayaEkle(satirlar[sira], "Öğrenilmiş Kelimeler.txt");
                    satirlar.RemoveAt(sira);

                    DosyayiTemizle("Öğrenilecek Kelimeler.txt");

                    for (int i = 0; i < satirlar.Count; i++)
                    {

                        DosyayaEkle(satirlar[i], "Öğrenilecek Kelimeler.txt");
                    }

                }

                else
                {
                    DateTime date = new DateTime();

                    date = Convert.ToDateTime(tarih);

                    if (asama == 1) { date = date.AddDays(6);}
                    else if (asama == 2) { date = date.AddDays(23); }
                    else if (asama == 3) { date = date.AddDays(150); }

                    asama++;

                    KelimeyiDosyadaGuncelle(date);
                    MessageBox.Show("Doğru cevap. Bir sonraki aşamaya geçtiniz.");
                }
                
            }

            else
            {
                asama = 1;
                KelimeyiDosyadaGuncelle(DateTime.Now.AddDays(1));
            }

        }


        //Bu metod değiştirilen tarihi ve aşamayı dosya üzerinde güncelliyor.
        public void KelimeyiDosyadaGuncelle(DateTime date)
        {
            List<string> satirlar = new List<string>();
            satirlar = OkumaIslemi("Öğrenilecek Kelimeler.txt");
            int sira = KelimeYeriniBul(kelimeAdi, "Öğrenilecek Kelimeler.txt", 0) - 1;
            satirlar.RemoveAt(sira);

            tarih = date.ToShortDateString();

            satirlar.Add(YazilacaklariBelirle());

            DosyayiTemizle("Öğrenilecek Kelimeler.txt");

            for (int i = 0; i < satirlar.Count; i++)
            {

                DosyayaEkle(satirlar[i], "Öğrenilecek Kelimeler.txt");
            }
        }

        
    }
}

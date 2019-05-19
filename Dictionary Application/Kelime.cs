using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dictionary_Application
{
    public class Kelime
    {

        public string kelimeAdi;

        public string kelimeKarsiligi;

        public string kelimeTuru;

        

        //Bu metod aranan kelimenin dosyada olup olmadığını kontrol etmektedir.Eğer varsa dosyada kaçıncı satırda olduğunu geriye döndürmektedir.
        //Parametre olarak aranan ögeyi , hangi dosyada aranacağını ve kaçıncı kolonda olduğunu almaktadır.
        public int KelimeYeriniBul(string aranan,string dosyaYolu,int kolonu)
        {
            FileStream dosyaIslemi = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Read);
            bool sonuc = false;
            dosyaIslemi.Seek(0, SeekOrigin.Begin);
            int i = 0;

            StreamReader streamReader = new StreamReader(dosyaIslemi);

            string okunanSatir = streamReader.ReadLine();
            try {
                //Dosyanın her satırını aradaki boşluklardan yararlanarak split fonksiyonu ile böldük.
                int boyut = Regex.Split(okunanSatir, @"\s").Length;
                string[] okunanlar = new string[boyut];

                while (okunanSatir != null)
                {
                    okunanlar = Regex.Split(okunanSatir, @"\s");
                    i++;
                    if (okunanlar[kolonu] == aranan.ToLower())
                    {
                        sonuc = true;
                        break;
                    }

                    okunanSatir = streamReader.ReadLine();

                }

            }
            catch { MessageBox.Show("Kelime bulunamadı!"); }


            
            streamReader.Close();
            dosyaIslemi.Close();

            if(sonuc == true)
            {
                return i;
            }

            else
            {
                return 0;
            }

            

        }
        
        //Bu metod alt sınıflarda ezilmek için kullanılıyor.
        //Alt sınıflar kendi isteğine göre yazılacakları belirliyor.
        public virtual string YazilacaklariBelirle()
        {
            string yazilacaklar = "";
            return yazilacaklar;
        }

        //Bu metod dosyaya veri yazdırırken o verinin daha önce eklenip eklenmediğini kontrol ediyor.
        public void DosyayaEkleKontrollu(Kelime kelime, string dosyaYolu)
        {
            if (Convert.ToBoolean(KelimeYeriniBul(kelime.kelimeAdi,dosyaYolu,0)))
            {
                MessageBox.Show("Kelime zaten var!");

            }
            else
            {

                DosyayaEkle(YazilacaklariBelirle(), dosyaYolu);
                MessageBox.Show("Kelimeyi başarı ile eklediniz!");
            }
                
        }
        //Bu metod gelen yazılacaklar bilgisini gönderilen dosya yoluna yazdırıyor.
        public void DosyayaEkle(string yazilacaklar, string dosyaYolu)
        {

            FileStream dosyaIslemi = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Write);


            StreamWriter streamWriter = new StreamWriter(dosyaIslemi);
            dosyaIslemi.Seek(0, SeekOrigin.End);



            streamWriter.WriteLine(yazilacaklar);

            streamWriter.Flush();

            streamWriter.Close();
            dosyaIslemi.Close();
        }

        //Bu metod gönderilen dosya yolunu okuyor. Ardından o dosyadaki bütün satırları liste olarak döndürüyor.
        public List<string> OkumaIslemi(string dosyaYolu)
        {
            FileStream dosyaIslemi = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Read);
            dosyaIslemi.Seek(0, SeekOrigin.Begin);

            List<string> satirlar = new List<string>();

            StreamReader streamReader = new StreamReader(dosyaIslemi);

            string okunankelime = streamReader.ReadLine();

            while (okunankelime != null)
            {

                satirlar.Add(okunankelime);
                okunankelime = streamReader.ReadLine();
            }

            streamReader.Close();
            dosyaIslemi.Close();

            return satirlar;
           
        }

        //Bu metod dosyadaki bütün verileri siliyor.
        public void DosyayiTemizle(string dosyaYolu)
        {
            File.WriteAllText(dosyaYolu, String.Empty);
        }


    }
}

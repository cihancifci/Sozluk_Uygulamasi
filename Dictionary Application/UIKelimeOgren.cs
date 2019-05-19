using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dictionary_Application
{
    public partial class UIKelimeOgren : MetroForm
    {
        public UIKelimeOgren()
        {
            InitializeComponent();
        }

        //Kelime öğrenme formu ilk açıldığında combobox a sözlükteki kelimeler ekleniyor
        private void KelimeOgren_Load(object sender, EventArgs e)
        {
            cmb_Kelimeler.Items.Clear();

            SozlukKelime sozluk = new SozlukKelime();

            List<string> kelimeler = new List<string>();

            kelimeler = sozluk.OkumaIslemi("Sözlük.txt");


            string[] okunanlar = new string[Regex.Split(kelimeler[0], @"\s").Length];

            for (int i = 0; i < kelimeler.Count; i++)
            {

                okunanlar = Regex.Split(kelimeler[i], @"\s");
                cmb_Kelimeler.Items.Add(okunanlar[0]);
            }
        }

        //Öğrenme tuşuna basıldığında kelime öğrenmeye başlanmamışsa veya öğrenme aşamaları bitirilmemişse öğrenilecek kelimeler dosyasına yazdırılıyor
        //Kelime öğrenmeye başlanmışsa kelimenin zaten öğrenmeye başladığı gösteriliyor.
        //Öğrenme aşamaları bitirilmişse kelimenin yeniden öğrenmeye başlamak istenildiği sorgulanıyor.
        private void Btn_Ogren_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenilmisKelime ogrenilmisKelime = new OgrenilmisKelime();

                OgrenilenKelime ogrkelime = new OgrenilenKelime();


                ogrkelime.kelimeAdi = cmb_Kelimeler.SelectedItem.ToString();


                ogrkelime.asama = 1;


                ogrkelime.tarih = Regex.Split(dtm_Tarih.Value.AddDays(1).ToString(), @"\s")[0];

                if (Convert.ToBoolean(ogrenilmisKelime.KelimeYeriniBul(ogrkelime.kelimeAdi, "Öğrenilmiş Kelimeler.txt", 0)))
                {
                    DialogResult secenek = MessageBox.Show("Bu kelimeyi zaten öğrenmiştiniz.Tekrar öğrenmek ister misiniz?\n(Eğer tekrar öğrenmek isterseniz öğrenilen kelimeler arasından silinecektir !!!)", "Hatırlatma", MessageBoxButtons.YesNo);

                    if (secenek == DialogResult.Yes)
                    {
                        ogrkelime.DosyayaEkleKontrollu(ogrkelime, "Öğrenilecek Kelimeler.txt");
                        ogrenilmisKelime.KelimeSil(cmb_Kelimeler.Text, "Öğrenilmiş Kelimeler.txt");
                    }

                }

                else
                {
                    ogrkelime.DosyayaEkleKontrollu(ogrkelime, "Öğrenilecek Kelimeler.txt");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen kelime seçiniz !");
            }
        }
    }
}

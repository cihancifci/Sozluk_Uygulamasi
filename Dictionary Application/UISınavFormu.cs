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

namespace Dictionary_Application
{
    public partial class UISınavFormu : MetroForm
    {
        string[] choices = new string[4];
        string soruKelimesi;
        Soru sorular = new Soru();
        OgrenilenKelime kelime ;
        bool kapatmaKontrolu;

        public UISınavFormu(OgrenilenKelime k)
        {
            this.kelime = k;
            choices = sorular.SoruOlustur(kelime);
            soruKelimesi = sorular.soruKelimesi;

            InitializeComponent();

            kapatmaKontrolu = true;
        }

        //Sınav formu açıldığında ilgili kelime için soru oluşturuluyor ve sorunun bilgileri ekranda gösteriliyor.
        private void SınavFormu_Load(object sender, EventArgs e)
        {
            lbl_soruKelime.Text = soruKelimesi.ToUpper();
            SiklariHazirla();
            
        }

        //Bu metod şıkları getiriyor ve gelen şıkların yerlerinin karıştırılmasını sağlıyor.
        private void SiklariHazirla()
        {


            List<string> siklar = new List<string>();

            string[] secilmisler = new string[4];
            
            for(int i = 0; i < choices.Length; i++)
            {
                siklar.Add(choices[i]);
            }

            Random random = new Random();

            for(int i =0; i < 4; i++)
            {
                int secilen = random.Next(0, choices.Length-i-1);
                
                secilmisler[i] = siklar[secilen];
                
                siklar.RemoveAt(secilen);
                
            }

            rdo_A.Text = secilmisler[0].ToUpper();
            rdo_B.Text = secilmisler[1].ToUpper();
            rdo_C.Text = secilmisler[2].ToUpper();
            rdo_D.Text = secilmisler[3].ToUpper();
        }

        //Cevaplama tuşuna basıldığında cevabın doğruluğuna göre ilgili kelimenin tarihi ve aşaması düncelleniyor.
        //Eğer ilgili kelime için son aşama biterse ekranda mesaj gösteriliyor.
        private void btn_Cevapla_Click(object sender, EventArgs e)
        {
            kapatmaKontrolu = false;
            string cevap;

            if (rdo_A.Checked) { cevap = rdo_A.Text.ToLower(); }
            else if (rdo_B.Checked) { cevap = rdo_B.Text.ToLower(); }
            else if (rdo_C.Checked) { cevap = rdo_C.Text.ToLower(); }
            else{ cevap = rdo_D.Text.ToLower(); }


            if (sorular.CevapKontrol(cevap))
            {
                
               kelime.AsamaveTarihGuncelle(true);
                this.Close();
            }

            else
            {
                MessageBox.Show("Yanlış cevap. Aşamalarınız sıfırlanacak.");
                kelime.AsamaveTarihGuncelle(false);
                this.Close();
            }

            
        }
        //Eğer kullanıcı cevaplama yapmadan formu kapatmak isterse ilgili kelimenin aşamalarının sıfırlanacağı bilgisi gösteriliyor.
        //Kullanıcı çıkmayı tercih ederse ilgili kelimenin aşaması sıfırlanıyor.
        private void SınavFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kapatmaKontrolu == true)
            {
                DialogResult dialogResult = MessageBox.Show("Eğer çıkarsanız aşamanız sıfırlanacak. Çıkmak istiyor musunuz ?", "Uyarı!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }

                else
                {
                    e.Cancel = false;
                    kelime.AsamaveTarihGuncelle(false);
                }
            }

            else { e.Cancel = false; }
        }


    }
}

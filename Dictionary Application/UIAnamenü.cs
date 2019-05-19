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
using System.IO;
using System.Text.RegularExpressions;

namespace Dictionary_Application
{
    public partial class UIAnamenü : MetroForm
    {
        public UIAnamenü()
        {
            InitializeComponent();
        }
        private bool soruVarligiKontrolu;


        //Ana menü açıldığında eğer kullanıcı ilk kez giriş yapmışsa log.txt dosyası oluşturulup o günün tarihi dosyaya yazılıyor.
        //Eğer sorulacağı günü geçen sorular varsa o soruların aşamaları sıfırlanıyor.
        //Eğer o gün soru veya sorular varsa o soruların gösterilmesi sağlanıyor.
        private void Anamenü_Load(object sender, EventArgs e)
        {
            OgrenilenKelime ogrenilenKelime = new OgrenilenKelime();

            ogrenilenKelime.gecmisTarihliOgrenmeGuncelle("Öğrenilecek Kelimeler.txt");

            soruVarligiKontrolu = true;

            if (!File.Exists("Log.txt"))
            {
                MessageBox.Show("Merhaba! Sözlük uygulamasına hoşgeldiniz!"+Environment.NewLine,"Bilgilendirme Penceresi!");
                File.WriteAllText("Log.txt", DateTime.Now.Year.ToString());
            }
            while (soruVarligiKontrolu)
            {
                Sorulari_Göster();
            }

        }

        //Butona basıldığında ilgili form açılıyor.

        private void tle_KelimeEkle_Click(object sender, EventArgs e)
        {
            UIKelimeEkle kelimeEkle = new UIKelimeEkle();
            kelimeEkle.ShowDialog();
        }

               private void tle_KelimeOgren_Click(object sender, EventArgs e)
        {
            UIKelimeOgren kelimeOgren = new UIKelimeOgren();
            kelimeOgren.ShowDialog();
        }

        private void tle_SozluguAc_Click(object sender, EventArgs e)
        {
            UISozluk uISozluk = new UISozluk();
            uISozluk.ShowDialog();
        }

        private void tle_IstatistikGoruntule_Click(object sender, EventArgs e)
        {
            UIIstatistikler ıstatistikler = new UIIstatistikler();
            ıstatistikler.ShowDialog();
        }

        private void tle_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Bu metod soru varsa sınav formunun açılıp sorunun sorulmasını sağlıyor.
        private void Sorulari_Göster()
        {
            OgrenilenKelime k = new OgrenilenKelime();

            if (Convert.ToBoolean(k.SoruVarsaBilgileriDoldur(DateTime.Now.ToShortDateString(), "Öğrenilecek Kelimeler.txt")))
            {

                UISınavFormu sınavFormu = new UISınavFormu(k);

                sınavFormu.ShowDialog();
            }
            else
            {
                soruVarligiKontrolu = false;
            }

        }


    }
}

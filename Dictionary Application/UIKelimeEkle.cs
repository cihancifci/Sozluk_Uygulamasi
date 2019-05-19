using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dictionary_Application
{
    public partial class UIKelimeEkle : MetroForm
    {


        public UIKelimeEkle()
        {
            InitializeComponent();
        }
        //Kullanıcı kelime ekleme tuşuna bastığında kelime eğer daha önce eklenmemişse ve bilgiler boş değilse kelime sözlüğe ekleniyor.
        private void btn_KelimeEkle_Click(object sender, EventArgs e)
        {
            if (txt_kelimeAdi.Text == "" || txt_kelimeKarsiligi.Text== "" || txt_kelimeTuru.Text== "")
            {
                MessageBox.Show("Lütfen bilgileri doldurun!");
            }
            else
            {
                SozlukKelime eklenecekKelime = new SozlukKelime();

                eklenecekKelime.kelimeAdi = txt_kelimeAdi.Text;
                eklenecekKelime.kelimeKarsiligi = txt_kelimeKarsiligi.Text;
                eklenecekKelime.kelimeTuru = txt_kelimeTuru.Text;

                eklenecekKelime.DosyayaEkleKontrollu(eklenecekKelime, "Sözlük.txt");
                txt_kelimeAdi.Text = "";
                txt_kelimeKarsiligi.Text = "";
                txt_kelimeTuru.Text = "";
            }                
        }
    }
}

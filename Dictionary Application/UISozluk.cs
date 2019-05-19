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
    public partial class UISozluk : MetroForm
    {
        public UISozluk()
        {
            InitializeComponent();
        }

        //Sözlük formu açıldığında sözlük dosyasındaki tüm kelimeler listviewe yazdırılıyor.
        private void UISozluk_Load(object sender, EventArgs e)
        {
            
            SozlukKelime sozlukKelime = new SozlukKelime();

            List<string> kelimeler = new List<string>();
            
            kelimeler = sozlukKelime.OkumaIslemi("Sözlük.txt");
            string[] lines = new string[kelimeler[0].Split('\t').Length];
            for (int i=0; i < kelimeler.Count; i++)
            {
                lines = kelimeler[i].Split('\t');
                lines[0] = char.ToUpper(lines[0][0]) + lines[0].Substring(1);
                lines[1] = char.ToUpper(lines[1][0]) + lines[1].Substring(1);
                lines[2] = char.ToUpper(lines[2][0]) + lines[2].Substring(1);
                var satir = new ListViewItem(lines);

                lstvwKelimeler.Items.Add(satir);
            }



        }
    }
}

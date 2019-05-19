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

namespace Dictionary_Application
{
    public partial class UIIstatistikler : MetroForm
    {
        public UIIstatistikler()
        {
            InitializeComponent();
        }

        //İstatistikler formu açıldığında yılların bulunduğu comboboxa programın açıldığı ilk yıldan bulunulan yıla kadar olan yıllar yazdırılıyor.
        private void Form1_Load(object sender, EventArgs e)
        {
            rdo_SadeceYil.Checked = true;
            int baslangicTarihi = int.Parse(File.ReadAllText("Log.txt"));

            for (int i = baslangicTarihi; i <= DateTime.Now.Year; i++)
            {
                cmb_Yil.Items.Add(i);

            }
            
        }

        private void btn_Goster_Click(object sender, EventArgs e)
        {

            lstvw_OgrenilenKelimeler.Items.Clear();
            lbl_OgrKelimeSayi.Text = "Öğrenilen kelime sayısı: ";


            //Eğer kullanıcı ay ve yıl ile listeleme yapmak isterse kullanıcının seçtiği yıl ve aydaki öğrenilen kelimeler listviewe aktarılıyor.
            //Progress bar öğrenilen kelime sayısına göre ayarlanıyor.
            if (rdo_AyYil.Checked == true)
            {

                OgrenilmisKelime ogrenilmisKelime = new OgrenilmisKelime();
                
                try
                {
                    int baslangicTarihi = int.Parse(File.ReadAllText("Log.txt"));

                    prgrssBarSkor.Maximum = ogrenilmisKelime.MaxSkorBelirle(baslangicTarihi, DateTime.Now.Year);

                    List<string> kelimeler = new List<string>();

                    int ay = cmb_Ay.SelectedIndex + 1;

                    int yil = int.Parse(cmb_Yil.Text);

                    if (ay == 0) { MessageBox.Show("Ayı Seçmediniz!"); }

                    else
                    {
                        try
                        {
                            kelimeler = ogrenilmisKelime.KelimeleriBelirle(ay, yil);

                            string[] lines = new string[kelimeler[0].Split('\t').Length];

                            for (int i = 0; i < kelimeler.Count; i++)
                            {
                                lines = kelimeler[i].Split('\t');
                                lines[0] = char.ToUpper(lines[0][0]) + lines[0].Substring(1);
                                var satir = new ListViewItem(lines);
                                lstvw_OgrenilenKelimeler.Items.Add(satir);
                                

                            }
                            lbl_OgrKelimeSayi.Text += kelimeler.Count.ToString();

                            prgrssBarSkor.Value = kelimeler.Count;
                            
                        }

                        catch
                        {
                            prgrssBarSkor.Value = 0;

                        }
                    }
                }

                catch { MessageBox.Show("Bulunamadı!"); }
            }
            //Eğer kullanıcı sadece yıl ile listeleme yapmak isterse kullanıcının seçtiği yıldaki öğrenilen kelimeler listviewe aktarılıyor.
            //Progress bar öğrenilen kelime sayısına göre ayarlanıyor.
            else if (rdo_SadeceYil.Checked == true)
            {
                lstvw_OgrenilenKelimeler.Items.Clear();
                OgrenilmisKelime ogrenilmisKelime = new OgrenilmisKelime();

                try
                {

                    int baslangicTarihi = int.Parse(File.ReadAllText("Log.txt"));

                    prgrssBarSkor.Maximum = ogrenilmisKelime.MaxSkorBelirle(baslangicTarihi, DateTime.Now.Year);
                    List<string> kelimeler = new List<string>();

                    int yil = int.Parse(cmb_Yil.Text);

                    try
                    {
                        kelimeler = ogrenilmisKelime.KelimeleriBelirle(yil);

                        string[] lines = new string[kelimeler[0].Split('\t').Length];

                        for (int i = 0; i < kelimeler.Count; i++)
                        {
                            lines = kelimeler[i].Split('\t');

                            lines[0] = char.ToUpper(lines[0][0]) + lines[0].Substring(1);
                            var satir = new ListViewItem(lines);
                            lstvw_OgrenilenKelimeler.Items.Add(satir);
                        }


                        lbl_OgrKelimeSayi.Text += kelimeler.Count.ToString();
                        prgrssBarSkor.Value = kelimeler.Count;
                    }




                    catch
                    {
                        prgrssBarSkor.Value = 0;
                    }

                }
                catch { MessageBox.Show("Bulunamadı!"); }
            }

            else { MessageBox.Show("Seçim yapmadınız!"); }


        }

        private void rdo_SadeceYil_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Ay.Visible = false;
        }                

        private void rdo_AyYil_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Ay.Visible = true;
        }
    }
}

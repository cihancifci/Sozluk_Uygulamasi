namespace Dictionary_Application
{
    partial class UIIstatistikler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdo_AyYil = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_SadeceYil = new MetroFramework.Controls.MetroRadioButton();
            this.lbl_OgrenilenKelimeler = new MetroFramework.Controls.MetroLabel();
            this.lbl_OgrKelimeSayi = new MetroFramework.Controls.MetroLabel();
            this.cmb_Yil = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Ay = new MetroFramework.Controls.MetroComboBox();
            this.lbl_TarihSec = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_Goster = new MetroFramework.Controls.MetroButton();
            this.lstvw_OgrenilenKelimeler = new MetroFramework.Controls.MetroListView();
            this.clmn_KelimeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prgrssBarSkor = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // rdo_AyYil
            // 
            this.rdo_AyYil.AutoSize = true;
            this.rdo_AyYil.Location = new System.Drawing.Point(28, 177);
            this.rdo_AyYil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_AyYil.Name = "rdo_AyYil";
            this.rdo_AyYil.Size = new System.Drawing.Size(181, 17);
            this.rdo_AyYil.TabIndex = 22;
            this.rdo_AyYil.Text = "Ay ile yılı seçmek istiyorum.";
            this.rdo_AyYil.UseSelectable = true;
            this.rdo_AyYil.CheckedChanged += new System.EventHandler(this.rdo_AyYil_CheckedChanged);
            // 
            // rdo_SadeceYil
            // 
            this.rdo_SadeceYil.AutoSize = true;
            this.rdo_SadeceYil.Location = new System.Drawing.Point(28, 132);
            this.rdo_SadeceYil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_SadeceYil.Name = "rdo_SadeceYil";
            this.rdo_SadeceYil.Size = new System.Drawing.Size(192, 17);
            this.rdo_SadeceYil.TabIndex = 21;
            this.rdo_SadeceYil.Text = "Sadece yılı seçmek istiyorum.";
            this.rdo_SadeceYil.UseSelectable = true;
            this.rdo_SadeceYil.CheckedChanged += new System.EventHandler(this.rdo_SadeceYil_CheckedChanged);
            // 
            // lbl_OgrenilenKelimeler
            // 
            this.lbl_OgrenilenKelimeler.AutoSize = true;
            this.lbl_OgrenilenKelimeler.Location = new System.Drawing.Point(465, 22);
            this.lbl_OgrenilenKelimeler.Name = "lbl_OgrenilenKelimeler";
            this.lbl_OgrenilenKelimeler.Size = new System.Drawing.Size(133, 20);
            this.lbl_OgrenilenKelimeler.TabIndex = 19;
            this.lbl_OgrenilenKelimeler.Text = "Öğrenilen Kelimeler";
            // 
            // lbl_OgrKelimeSayi
            // 
            this.lbl_OgrKelimeSayi.AutoSize = true;
            this.lbl_OgrKelimeSayi.Location = new System.Drawing.Point(465, 410);
            this.lbl_OgrKelimeSayi.Name = "lbl_OgrKelimeSayi";
            this.lbl_OgrKelimeSayi.Size = new System.Drawing.Size(159, 20);
            this.lbl_OgrKelimeSayi.TabIndex = 17;
            this.lbl_OgrKelimeSayi.Text = "Öğrenilen kelime sayısı: ";
            // 
            // cmb_Yil
            // 
            this.cmb_Yil.FormattingEnabled = true;
            this.cmb_Yil.ItemHeight = 24;
            this.cmb_Yil.Location = new System.Drawing.Point(28, 226);
            this.cmb_Yil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Yil.Name = "cmb_Yil";
            this.cmb_Yil.Size = new System.Drawing.Size(175, 30);
            this.cmb_Yil.TabIndex = 16;
            this.cmb_Yil.UseSelectable = true;
            // 
            // cmb_Ay
            // 
            this.cmb_Ay.FormattingEnabled = true;
            this.cmb_Ay.ItemHeight = 24;
            this.cmb_Ay.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmb_Ay.Location = new System.Drawing.Point(28, 279);
            this.cmb_Ay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Ay.Name = "cmb_Ay";
            this.cmb_Ay.Size = new System.Drawing.Size(175, 30);
            this.cmb_Ay.TabIndex = 15;
            this.cmb_Ay.UseSelectable = true;
            this.cmb_Ay.Visible = false;
            // 
            // lbl_TarihSec
            // 
            this.lbl_TarihSec.AutoSize = true;
            this.lbl_TarihSec.Location = new System.Drawing.Point(23, 90);
            this.lbl_TarihSec.Name = "lbl_TarihSec";
            this.lbl_TarihSec.Size = new System.Drawing.Size(90, 20);
            this.lbl_TarihSec.TabIndex = 14;
            this.lbl_TarihSec.Text = "Tarihi seçiniz:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(85, 407);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 20);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Listele!";
            // 
            // btn_Goster
            // 
            this.btn_Goster.BackgroundImage = global::Dictionary_Application.Properties.Resources.listele;
            this.btn_Goster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Goster.Location = new System.Drawing.Point(43, 334);
            this.btn_Goster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(161, 71);
            this.btn_Goster.TabIndex = 20;
            this.btn_Goster.UseSelectable = true;
            this.btn_Goster.Click += new System.EventHandler(this.btn_Goster_Click);
            // 
            // lstvw_OgrenilenKelimeler
            // 
            this.lstvw_OgrenilenKelimeler.AllowSorting = true;
            this.lstvw_OgrenilenKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn_KelimeAdi,
            this.clmn_Tarih});
            this.lstvw_OgrenilenKelimeler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstvw_OgrenilenKelimeler.FullRowSelect = true;
            this.lstvw_OgrenilenKelimeler.GridLines = true;
            this.lstvw_OgrenilenKelimeler.Location = new System.Drawing.Point(465, 62);
            this.lstvw_OgrenilenKelimeler.Margin = new System.Windows.Forms.Padding(4);
            this.lstvw_OgrenilenKelimeler.Name = "lstvw_OgrenilenKelimeler";
            this.lstvw_OgrenilenKelimeler.OwnerDraw = true;
            this.lstvw_OgrenilenKelimeler.Size = new System.Drawing.Size(309, 308);
            this.lstvw_OgrenilenKelimeler.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstvw_OgrenilenKelimeler.TabIndex = 25;
            this.lstvw_OgrenilenKelimeler.UseCompatibleStateImageBehavior = false;
            this.lstvw_OgrenilenKelimeler.UseSelectable = true;
            this.lstvw_OgrenilenKelimeler.View = System.Windows.Forms.View.Details;
            // 
            // clmn_KelimeAdi
            // 
            this.clmn_KelimeAdi.Text = "Kelime Adı";
            this.clmn_KelimeAdi.Width = 114;
            // 
            // clmn_Tarih
            // 
            this.clmn_Tarih.Text = "Öğrenilen Tarih";
            this.clmn_Tarih.Width = 111;
            // 
            // prgrssBarSkor
            // 
            this.prgrssBarSkor.Location = new System.Drawing.Point(674, 410);
            this.prgrssBarSkor.Name = "prgrssBarSkor";
            this.prgrssBarSkor.Size = new System.Drawing.Size(206, 23);
            this.prgrssBarSkor.TabIndex = 26;
            // 
            // UIIstatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.prgrssBarSkor);
            this.Controls.Add(this.lstvw_OgrenilenKelimeler);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rdo_AyYil);
            this.Controls.Add(this.rdo_SadeceYil);
            this.Controls.Add(this.btn_Goster);
            this.Controls.Add(this.lbl_OgrenilenKelimeler);
            this.Controls.Add(this.lbl_OgrKelimeSayi);
            this.Controls.Add(this.cmb_Yil);
            this.Controls.Add(this.cmb_Ay);
            this.Controls.Add(this.lbl_TarihSec);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UIIstatistikler";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rdo_AyYil;
        private MetroFramework.Controls.MetroRadioButton rdo_SadeceYil;
        private MetroFramework.Controls.MetroButton btn_Goster;
        private MetroFramework.Controls.MetroLabel lbl_OgrenilenKelimeler;
        private MetroFramework.Controls.MetroLabel lbl_OgrKelimeSayi;
        private MetroFramework.Controls.MetroComboBox cmb_Yil;
        private MetroFramework.Controls.MetroComboBox cmb_Ay;
        private MetroFramework.Controls.MetroLabel lbl_TarihSec;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroListView lstvw_OgrenilenKelimeler;
        private System.Windows.Forms.ColumnHeader clmn_KelimeAdi;
        private System.Windows.Forms.ColumnHeader clmn_Tarih;
        private MetroFramework.Controls.MetroProgressBar prgrssBarSkor;
    }
}
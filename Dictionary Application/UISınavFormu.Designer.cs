namespace Dictionary_Application
{
    partial class UISınavFormu
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
            this.lbl_soruKelime = new MetroFramework.Controls.MetroLabel();
            this.rdo_A = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_B = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_C = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_D = new MetroFramework.Controls.MetroRadioButton();
            this.lbl_SoruCumlesi = new MetroFramework.Controls.MetroLabel();
            this.btn_Cevapla = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbl_soruKelime
            // 
            this.lbl_soruKelime.AutoSize = true;
            this.lbl_soruKelime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_soruKelime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_soruKelime.Location = new System.Drawing.Point(213, 60);
            this.lbl_soruKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_soruKelime.Name = "lbl_soruKelime";
            this.lbl_soruKelime.Size = new System.Drawing.Size(146, 25);
            this.lbl_soruKelime.TabIndex = 0;
            this.lbl_soruKelime.Text = "İngilizce Kelime";
            // 
            // rdo_A
            // 
            this.rdo_A.AutoSize = true;
            this.rdo_A.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdo_A.Location = new System.Drawing.Point(56, 206);
            this.rdo_A.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_A.Name = "rdo_A";
            this.rdo_A.Size = new System.Drawing.Size(65, 19);
            this.rdo_A.TabIndex = 1;
            this.rdo_A.Text = "A Şıkkı";
            this.rdo_A.UseSelectable = true;
            // 
            // rdo_B
            // 
            this.rdo_B.AutoSize = true;
            this.rdo_B.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdo_B.Location = new System.Drawing.Point(187, 206);
            this.rdo_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_B.Name = "rdo_B";
            this.rdo_B.Size = new System.Drawing.Size(64, 19);
            this.rdo_B.TabIndex = 2;
            this.rdo_B.Text = "B Şıkkı";
            this.rdo_B.UseSelectable = true;
            // 
            // rdo_C
            // 
            this.rdo_C.AutoSize = true;
            this.rdo_C.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdo_C.Location = new System.Drawing.Point(328, 206);
            this.rdo_C.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_C.Name = "rdo_C";
            this.rdo_C.Size = new System.Drawing.Size(65, 19);
            this.rdo_C.TabIndex = 3;
            this.rdo_C.Text = "C Şıkkı";
            this.rdo_C.UseSelectable = true;
            // 
            // rdo_D
            // 
            this.rdo_D.AutoSize = true;
            this.rdo_D.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdo_D.Location = new System.Drawing.Point(454, 206);
            this.rdo_D.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_D.Name = "rdo_D";
            this.rdo_D.Size = new System.Drawing.Size(66, 19);
            this.rdo_D.TabIndex = 4;
            this.rdo_D.Text = "D Şıkkı";
            this.rdo_D.UseSelectable = true;
            // 
            // lbl_SoruCumlesi
            // 
            this.lbl_SoruCumlesi.AutoSize = true;
            this.lbl_SoruCumlesi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_SoruCumlesi.Location = new System.Drawing.Point(84, 124);
            this.lbl_SoruCumlesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoruCumlesi.Name = "lbl_SoruCumlesi";
            this.lbl_SoruCumlesi.Size = new System.Drawing.Size(425, 25);
            this.lbl_SoruCumlesi.TabIndex = 5;
            this.lbl_SoruCumlesi.Text = "Aşağıdakilerden hangi bu kelimenin Türkçe karşılığıdır?";
            // 
            // btn_Cevapla
            // 
            this.btn_Cevapla.Location = new System.Drawing.Point(244, 280);
            this.btn_Cevapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cevapla.Name = "btn_Cevapla";
            this.btn_Cevapla.Size = new System.Drawing.Size(92, 26);
            this.btn_Cevapla.TabIndex = 6;
            this.btn_Cevapla.Text = "Cevapla!";
            this.btn_Cevapla.UseSelectable = true;
            this.btn_Cevapla.Click += new System.EventHandler(this.btn_Cevapla_Click);
            // 
            // UISınavFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Cevapla);
            this.Controls.Add(this.lbl_SoruCumlesi);
            this.Controls.Add(this.rdo_D);
            this.Controls.Add(this.rdo_C);
            this.Controls.Add(this.rdo_B);
            this.Controls.Add(this.rdo_A);
            this.Controls.Add(this.lbl_soruKelime);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UISınavFormu";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Sınav";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SınavFormu_FormClosing);
            this.Load += new System.EventHandler(this.SınavFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_soruKelime;
        private MetroFramework.Controls.MetroRadioButton rdo_A;
        private MetroFramework.Controls.MetroRadioButton rdo_B;
        private MetroFramework.Controls.MetroRadioButton rdo_C;
        private MetroFramework.Controls.MetroRadioButton rdo_D;
        private MetroFramework.Controls.MetroLabel lbl_SoruCumlesi;
        private MetroFramework.Controls.MetroButton btn_Cevapla;
    }
}
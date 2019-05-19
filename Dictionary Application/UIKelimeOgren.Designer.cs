namespace Dictionary_Application
{
    partial class UIKelimeOgren
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_Tarih = new System.Windows.Forms.DateTimePicker();
            this.Btn_Ogren = new MetroFramework.Controls.MetroButton();
            this.cmb_Kelimeler = new System.Windows.Forms.ComboBox();
            this.lbl_KelimeSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kelimeyi Öğren";
            // 
            // dtm_Tarih
            // 
            this.dtm_Tarih.Enabled = false;
            this.dtm_Tarih.Location = new System.Drawing.Point(371, 62);
            this.dtm_Tarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtm_Tarih.Name = "dtm_Tarih";
            this.dtm_Tarih.Size = new System.Drawing.Size(151, 22);
            this.dtm_Tarih.TabIndex = 24;
            // 
            // Btn_Ogren
            // 
            this.Btn_Ogren.BackgroundImage = global::Dictionary_Application.Properties.Resources.kelimeyiOgren;
            this.Btn_Ogren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Ogren.Location = new System.Drawing.Point(290, 242);
            this.Btn_Ogren.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ogren.Name = "Btn_Ogren";
            this.Btn_Ogren.Size = new System.Drawing.Size(60, 59);
            this.Btn_Ogren.TabIndex = 19;
            this.Btn_Ogren.UseSelectable = true;
            this.Btn_Ogren.Click += new System.EventHandler(this.Btn_Ogren_Click);
            // 
            // cmb_Kelimeler
            // 
            this.cmb_Kelimeler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Kelimeler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Kelimeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Kelimeler.FormattingEnabled = true;
            this.cmb_Kelimeler.Location = new System.Drawing.Point(238, 172);
            this.cmb_Kelimeler.Name = "cmb_Kelimeler";
            this.cmb_Kelimeler.Size = new System.Drawing.Size(188, 33);
            this.cmb_Kelimeler.Sorted = true;
            this.cmb_Kelimeler.TabIndex = 25;
            // 
            // lbl_KelimeSec
            // 
            this.lbl_KelimeSec.AutoSize = true;
            this.lbl_KelimeSec.Location = new System.Drawing.Point(115, 171);
            this.lbl_KelimeSec.Name = "lbl_KelimeSec";
            this.lbl_KelimeSec.Size = new System.Drawing.Size(117, 34);
            this.lbl_KelimeSec.TabIndex = 26;
            this.lbl_KelimeSec.Text = "Öğrenilecek \r\nKelimeyi Seçiniz :";
            // 
            // UIKelimeOgren
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.lbl_KelimeSec);
            this.Controls.Add(this.cmb_Kelimeler);
            this.Controls.Add(this.dtm_Tarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Ogren);
            this.Name = "UIKelimeOgren";
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.KelimeOgren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton Btn_Ogren;
        private System.Windows.Forms.DateTimePicker dtm_Tarih;
        private System.Windows.Forms.ComboBox cmb_Kelimeler;
        private System.Windows.Forms.Label lbl_KelimeSec;
    }
}
namespace Dictionary_Application
{
    partial class UISozluk
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
            this.lstvwKelimeler = new MetroFramework.Controls.MetroListView();
            this.clmnKelimeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnKarsiligi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Karsiligi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstvwKelimeler
            // 
            this.lstvwKelimeler.AllowSorting = true;
            this.lstvwKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnKelimeAdi,
            this.clmnKarsiligi,
            this.clmn_Karsiligi});
            this.lstvwKelimeler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstvwKelimeler.FullRowSelect = true;
            this.lstvwKelimeler.GridLines = true;
            this.lstvwKelimeler.Location = new System.Drawing.Point(55, 82);
            this.lstvwKelimeler.Name = "lstvwKelimeler";
            this.lstvwKelimeler.OwnerDraw = true;
            this.lstvwKelimeler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstvwKelimeler.Size = new System.Drawing.Size(446, 328);
            this.lstvwKelimeler.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstvwKelimeler.TabIndex = 1;
            this.lstvwKelimeler.UseCompatibleStateImageBehavior = false;
            this.lstvwKelimeler.UseSelectable = true;
            this.lstvwKelimeler.View = System.Windows.Forms.View.Details;
            // 
            // clmnKelimeAdi
            // 
            this.clmnKelimeAdi.Text = "Kelime";
            this.clmnKelimeAdi.Width = 161;
            // 
            // clmnKarsiligi
            // 
            this.clmnKarsiligi.Text = "Karşılığı";
            this.clmnKarsiligi.Width = 141;
            // 
            // clmn_Karsiligi
            // 
            this.clmn_Karsiligi.Text = "Türü";
            this.clmn_Karsiligi.Width = 121;
            // 
            // UISozluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvwKelimeler);
            this.Name = "UISozluk";
            this.Text = "Sözlük";
            this.Load += new System.EventHandler(this.UISozluk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lstvwKelimeler;
        private System.Windows.Forms.ColumnHeader clmnKelimeAdi;
        private System.Windows.Forms.ColumnHeader clmnKarsiligi;
        private System.Windows.Forms.ColumnHeader clmn_Karsiligi;
    }
}
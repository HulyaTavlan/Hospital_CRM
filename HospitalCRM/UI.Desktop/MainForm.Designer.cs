namespace UI.Desktop
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNewPatientForm = new System.Windows.Forms.ToolStripMenuItem();
            this.getFindPatientForm = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaGirişÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifDoktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuTakvimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDoktorGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem,
            this.doktorİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getNewPatientForm,
            this.getFindPatientForm,
            this.hastaListesiToolStripMenuItem,
            this.hastaGirişÇıkışToolStripMenuItem});
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.hastaİşlemleriToolStripMenuItem.Text = "&Hasta İşlemleri";
            // 
            // getNewPatientForm
            // 
            this.getNewPatientForm.Name = "getNewPatientForm";
            this.getNewPatientForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.getNewPatientForm.Size = new System.Drawing.Size(201, 22);
            this.getNewPatientForm.Text = "Yeni Hasta Girişi";
            this.getNewPatientForm.Click += new System.EventHandler(this.getNewPatientForm_Click);
            // 
            // getFindPatientForm
            // 
            this.getFindPatientForm.Name = "getFindPatientForm";
            this.getFindPatientForm.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.getFindPatientForm.Size = new System.Drawing.Size(201, 22);
            this.getFindPatientForm.Text = "Hasta Bul";
            this.getFindPatientForm.Click += new System.EventHandler(this.getFindPatientForm_Click);
            // 
            // hastaListesiToolStripMenuItem
            // 
            this.hastaListesiToolStripMenuItem.Name = "hastaListesiToolStripMenuItem";
            this.hastaListesiToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.hastaListesiToolStripMenuItem.Text = "Hasta Listesi";
            // 
            // hastaGirişÇıkışToolStripMenuItem
            // 
            this.hastaGirişÇıkışToolStripMenuItem.Name = "hastaGirişÇıkışToolStripMenuItem";
            this.hastaGirişÇıkışToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.hastaGirişÇıkışToolStripMenuItem.Text = "Hasta Çıkışı";
            // 
            // doktorİşlemleriToolStripMenuItem
            // 
            this.doktorİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktifDoktorlarToolStripMenuItem,
            this.doktorBulToolStripMenuItem,
            this.doktorListesiToolStripMenuItem,
            this.randevuTakvimiToolStripMenuItem,
            this.yeniDoktorGirişiToolStripMenuItem});
            this.doktorİşlemleriToolStripMenuItem.Name = "doktorİşlemleriToolStripMenuItem";
            this.doktorİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.doktorİşlemleriToolStripMenuItem.Text = "Doktor İşlemleri";
            // 
            // aktifDoktorlarToolStripMenuItem
            // 
            this.aktifDoktorlarToolStripMenuItem.Name = "aktifDoktorlarToolStripMenuItem";
            this.aktifDoktorlarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aktifDoktorlarToolStripMenuItem.Text = "Aktif Doktorlar";
            // 
            // doktorBulToolStripMenuItem
            // 
            this.doktorBulToolStripMenuItem.Name = "doktorBulToolStripMenuItem";
            this.doktorBulToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.doktorBulToolStripMenuItem.Text = "Doktor Bul";
            // 
            // doktorListesiToolStripMenuItem
            // 
            this.doktorListesiToolStripMenuItem.Name = "doktorListesiToolStripMenuItem";
            this.doktorListesiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.doktorListesiToolStripMenuItem.Text = "Doktor Listesi";
            // 
            // randevuTakvimiToolStripMenuItem
            // 
            this.randevuTakvimiToolStripMenuItem.Name = "randevuTakvimiToolStripMenuItem";
            this.randevuTakvimiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.randevuTakvimiToolStripMenuItem.Text = "Randevu Takvimi";
            // 
            // yeniDoktorGirişiToolStripMenuItem
            // 
            this.yeniDoktorGirişiToolStripMenuItem.Name = "yeniDoktorGirişiToolStripMenuItem";
            this.yeniDoktorGirişiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yeniDoktorGirişiToolStripMenuItem.Text = "Yeni Doktor Girişi";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 442);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hastane Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getNewPatientForm;
        private System.Windows.Forms.ToolStripMenuItem getFindPatientForm;
        private System.Windows.Forms.ToolStripMenuItem hastaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaGirişÇıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifDoktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuTakvimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniDoktorGirişiToolStripMenuItem;
    }
}


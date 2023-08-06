namespace UI.Desktop.Patient
{
    partial class FindPatient
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
            this.components = new System.ComponentModel.Container();
            this.grid_patients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_patientUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_patientDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grid_patients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_patients
            // 
            this.grid_patients.AllowUserToAddRows = false;
            this.grid_patients.AllowUserToDeleteRows = false;
            this.grid_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_patients.ContextMenuStrip = this.contextMenuStrip1;
            this.grid_patients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_patients.Location = new System.Drawing.Point(0, 0);
            this.grid_patients.Name = "grid_patients";
            this.grid_patients.ReadOnly = true;
            this.grid_patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_patients.Size = new System.Drawing.Size(640, 344);
            this.grid_patients.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_patientUpdate,
            this.btn_patientDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // btn_patientUpdate
            // 
            this.btn_patientUpdate.Name = "btn_patientUpdate";
            this.btn_patientUpdate.Size = new System.Drawing.Size(180, 22);
            this.btn_patientUpdate.Text = "Düzenle";
            this.btn_patientUpdate.Click += new System.EventHandler(this.btn_patientUpdate_Click);
            // 
            // btn_patientDelete
            // 
            this.btn_patientDelete.Name = "btn_patientDelete";
            this.btn_patientDelete.Size = new System.Drawing.Size(180, 22);
            this.btn_patientDelete.Text = "Sil";
            this.btn_patientDelete.Click += new System.EventHandler(this.btn_patientDelete_Click);
            // 
            // FindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 344);
            this.Controls.Add(this.grid_patients);
            this.Name = "FindPatient";
            this.Text = "FindPatient";
            this.Load += new System.EventHandler(this.FindPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_patients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_patients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_patientUpdate;
        private System.Windows.Forms.ToolStripMenuItem btn_patientDelete;
    }
}
namespace UI.Desktop.Patient
{
    partial class NewPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_tckno = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_bloodType = new System.Windows.Forms.ComboBox();
            this.dt_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.chk_drink = new System.Windows.Forms.CheckBox();
            this.chk_smoke = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_others = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_district = new System.Windows.Forms.ComboBox();
            this.cb_cities = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. Kimlik No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(316, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(235, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(154, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Vazgeç";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_tckno
            // 
            this.txt_tckno.Location = new System.Drawing.Point(94, 19);
            this.txt_tckno.MaxLength = 11;
            this.txt_tckno.Name = "txt_tckno";
            this.txt_tckno.Size = new System.Drawing.Size(100, 20);
            this.txt_tckno.TabIndex = 6;
            this.txt_tckno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_tckno.WordWrap = false;
            this.txt_tckno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tckno_KeyDown);
            this.txt_tckno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_tckno_KeyUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_save);
            this.flowLayoutPanel1.Controls.Add(this.btn_clear);
            this.flowLayoutPanel1.Controls.Add(this.btn_cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 331);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 30);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(94, 45);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(100, 20);
            this.txt_firstname.TabIndex = 12;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(94, 71);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(394, 331);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_bloodType);
            this.groupBox1.Controls.Add(this.dt_dateOfBirth);
            this.groupBox1.Controls.Add(this.chk_drink);
            this.groupBox1.Controls.Add(this.chk_smoke);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rb_others);
            this.groupBox1.Controls.Add(this.rb_male);
            this.groupBox1.Controls.Add(this.rb_female);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tckno);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_firstname);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Doğum Tarihi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_bloodType
            // 
            this.cb_bloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bloodType.FormattingEnabled = true;
            this.cb_bloodType.Items.AddRange(new object[] {
            "Seçiniz",
            "A Rh -",
            "A Rh +",
            "B Rh -",
            "B Rh +",
            "AB Rh -",
            "AB Rh +",
            "0 Rh -",
            "0 Rh +"});
            this.cb_bloodType.Location = new System.Drawing.Point(94, 218);
            this.cb_bloodType.Name = "cb_bloodType";
            this.cb_bloodType.Size = new System.Drawing.Size(100, 21);
            this.cb_bloodType.TabIndex = 21;
            // 
            // dt_dateOfBirth
            // 
            this.dt_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dateOfBirth.Location = new System.Drawing.Point(94, 97);
            this.dt_dateOfBirth.Name = "dt_dateOfBirth";
            this.dt_dateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dt_dateOfBirth.TabIndex = 23;
            // 
            // chk_drink
            // 
            this.chk_drink.AutoSize = true;
            this.chk_drink.Location = new System.Drawing.Point(94, 194);
            this.chk_drink.Name = "chk_drink";
            this.chk_drink.Size = new System.Drawing.Size(49, 17);
            this.chk_drink.TabIndex = 20;
            this.chk_drink.Text = "Alkol";
            this.chk_drink.UseVisualStyleBackColor = true;
            // 
            // chk_smoke
            // 
            this.chk_smoke.AutoSize = true;
            this.chk_smoke.Location = new System.Drawing.Point(14, 194);
            this.chk_smoke.Name = "chk_smoke";
            this.chk_smoke.Size = new System.Drawing.Size(56, 17);
            this.chk_smoke.TabIndex = 19;
            this.chk_smoke.Text = "Sigara";
            this.chk_smoke.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kan Grubu";
            // 
            // rb_others
            // 
            this.rb_others.AutoSize = true;
            this.rb_others.Location = new System.Drawing.Point(94, 169);
            this.rb_others.Name = "rb_others";
            this.rb_others.Size = new System.Drawing.Size(63, 17);
            this.rb_others.TabIndex = 17;
            this.rb_others.TabStop = true;
            this.rb_others.Text = "Diğerleri";
            this.rb_others.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(94, 146);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(53, 17);
            this.rb_male.TabIndex = 16;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Erkek";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(94, 123);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(52, 17);
            this.rb_female.TabIndex = 15;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kadın";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cinsiyet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cb_district);
            this.groupBox2.Controls.Add(this.cb_cities);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 192);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "İlçe";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "İl";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_district
            // 
            this.cb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_district.FormattingEnabled = true;
            this.cb_district.Location = new System.Drawing.Point(66, 99);
            this.cb_district.Name = "cb_district";
            this.cb_district.Size = new System.Drawing.Size(100, 21);
            this.cb_district.TabIndex = 26;
            // 
            // cb_cities
            // 
            this.cb_cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cities.FormattingEnabled = true;
            this.cb_cities.Location = new System.Drawing.Point(66, 71);
            this.cb_cities.Name = "cb_cities";
            this.cb_cities.Size = new System.Drawing.Size(100, 21);
            this.cb_cities.TabIndex = 25;
            this.cb_cities.SelectedIndexChanged += new System.EventHandler(this.cb_cities_SelectedIndexChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(66, 19);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 24;
            this.txt_email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adres";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telefon";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(66, 126);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 55);
            this.txt_address.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "E-Posta";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(66, 45);
            this.txt_phone.Mask = "(999) 000-0000";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 15;
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 361);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(410, 400);
            this.Name = "NewPatient";
            this.Text = "Yeni Hasta Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPatient_FormClosing);
            this.Load += new System.EventHandler(this.NewPatient_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_tckno;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_bloodType;
        private System.Windows.Forms.CheckBox chk_drink;
        private System.Windows.Forms.CheckBox chk_smoke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_others;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_phone;
        private System.Windows.Forms.DateTimePicker dt_dateOfBirth;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_district;
        private System.Windows.Forms.ComboBox cb_cities;
    }
}
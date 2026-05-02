namespace FinalProject
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HastaEkle = new System.Windows.Forms.Button();
            this.btn_HastaSil = new System.Windows.Forms.Button();
            this.dtp_RandevuGuncelle = new System.Windows.Forms.DateTimePicker();
            this.btn_RaporGuncelle = new System.Windows.Forms.Button();
            this.btn_IlacGuncelle = new System.Windows.Forms.Button();
            this.btn_Yonlendir = new System.Windows.Forms.Button();
            this.btn_RandevuGuncelle = new System.Windows.Forms.Button();
            this.cmb_Yonlendir = new System.Windows.Forms.ComboBox();
            this.cmb_IlacGuncelle = new System.Windows.Forms.ComboBox();
            this.rtb_RaporGuncelle = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_Report = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Medicine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Kadin = new System.Windows.Forms.RadioButton();
            this.rb_Erkek = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Illness = new System.Windows.Forms.ComboBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(579, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(574, 752);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(734, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA LİSTESİ";
            // 
            // btn_HastaEkle
            // 
            this.btn_HastaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HastaEkle.Location = new System.Drawing.Point(190, 342);
            this.btn_HastaEkle.Name = "btn_HastaEkle";
            this.btn_HastaEkle.Size = new System.Drawing.Size(231, 53);
            this.btn_HastaEkle.TabIndex = 2;
            this.btn_HastaEkle.Text = "Hasta Ekle";
            this.btn_HastaEkle.UseVisualStyleBackColor = true;
            this.btn_HastaEkle.Click += new System.EventHandler(this.btn_HastaEkle_Click);
            // 
            // btn_HastaSil
            // 
            this.btn_HastaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HastaSil.Location = new System.Drawing.Point(348, 331);
            this.btn_HastaSil.Name = "btn_HastaSil";
            this.btn_HastaSil.Size = new System.Drawing.Size(212, 51);
            this.btn_HastaSil.TabIndex = 3;
            this.btn_HastaSil.Text = "Hasta Sil";
            this.btn_HastaSil.UseVisualStyleBackColor = true;
            this.btn_HastaSil.Click += new System.EventHandler(this.btn_HastaSil_Click);
            // 
            // dtp_RandevuGuncelle
            // 
            this.dtp_RandevuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_RandevuGuncelle.Location = new System.Drawing.Point(42, 290);
            this.dtp_RandevuGuncelle.Name = "dtp_RandevuGuncelle";
            this.dtp_RandevuGuncelle.Size = new System.Drawing.Size(288, 30);
            this.dtp_RandevuGuncelle.TabIndex = 4;
            // 
            // btn_RaporGuncelle
            // 
            this.btn_RaporGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RaporGuncelle.Location = new System.Drawing.Point(348, 218);
            this.btn_RaporGuncelle.Name = "btn_RaporGuncelle";
            this.btn_RaporGuncelle.Size = new System.Drawing.Size(212, 53);
            this.btn_RaporGuncelle.TabIndex = 5;
            this.btn_RaporGuncelle.Text = "Rapor Güncelle";
            this.btn_RaporGuncelle.UseVisualStyleBackColor = true;
            this.btn_RaporGuncelle.Click += new System.EventHandler(this.btn_RaporGuncelle_Click);
            // 
            // btn_IlacGuncelle
            // 
            this.btn_IlacGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_IlacGuncelle.Location = new System.Drawing.Point(348, 148);
            this.btn_IlacGuncelle.Name = "btn_IlacGuncelle";
            this.btn_IlacGuncelle.Size = new System.Drawing.Size(212, 53);
            this.btn_IlacGuncelle.TabIndex = 6;
            this.btn_IlacGuncelle.Text = "İlaç Güncelle";
            this.btn_IlacGuncelle.UseVisualStyleBackColor = true;
            this.btn_IlacGuncelle.Click += new System.EventHandler(this.btn_IlacGuncelle_Click);
            // 
            // btn_Yonlendir
            // 
            this.btn_Yonlendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yonlendir.Location = new System.Drawing.Point(348, 58);
            this.btn_Yonlendir.Name = "btn_Yonlendir";
            this.btn_Yonlendir.Size = new System.Drawing.Size(212, 72);
            this.btn_Yonlendir.TabIndex = 7;
            this.btn_Yonlendir.Text = "Farklı Doktora Yöndendir";
            this.btn_Yonlendir.UseVisualStyleBackColor = true;
            this.btn_Yonlendir.Click += new System.EventHandler(this.btn_Yonlendir_Click);
            // 
            // btn_RandevuGuncelle
            // 
            this.btn_RandevuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RandevuGuncelle.Location = new System.Drawing.Point(348, 290);
            this.btn_RandevuGuncelle.Name = "btn_RandevuGuncelle";
            this.btn_RandevuGuncelle.Size = new System.Drawing.Size(212, 35);
            this.btn_RandevuGuncelle.TabIndex = 8;
            this.btn_RandevuGuncelle.Text = "Randevu Güncelle";
            this.btn_RandevuGuncelle.UseVisualStyleBackColor = true;
            this.btn_RandevuGuncelle.Click += new System.EventHandler(this.btn_RandevuGuncelle_Click);
            // 
            // cmb_Yonlendir
            // 
            this.cmb_Yonlendir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Yonlendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Yonlendir.FormattingEnabled = true;
            this.cmb_Yonlendir.Location = new System.Drawing.Point(42, 58);
            this.cmb_Yonlendir.Name = "cmb_Yonlendir";
            this.cmb_Yonlendir.Size = new System.Drawing.Size(288, 33);
            this.cmb_Yonlendir.TabIndex = 9;
            // 
            // cmb_IlacGuncelle
            // 
            this.cmb_IlacGuncelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IlacGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_IlacGuncelle.FormattingEnabled = true;
            this.cmb_IlacGuncelle.Location = new System.Drawing.Point(42, 148);
            this.cmb_IlacGuncelle.Name = "cmb_IlacGuncelle";
            this.cmb_IlacGuncelle.Size = new System.Drawing.Size(288, 33);
            this.cmb_IlacGuncelle.TabIndex = 10;
            // 
            // rtb_RaporGuncelle
            // 
            this.rtb_RaporGuncelle.Location = new System.Drawing.Point(42, 218);
            this.rtb_RaporGuncelle.Name = "rtb_RaporGuncelle";
            this.rtb_RaporGuncelle.Size = new System.Drawing.Size(288, 53);
            this.rtb_RaporGuncelle.TabIndex = 11;
            this.rtb_RaporGuncelle.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "İŞLEMLER";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rtb_Report);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_Medicine);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rb_Kadin);
            this.groupBox1.Controls.Add(this.rb_Erkek);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_HastaEkle);
            this.groupBox1.Controls.Add(this.cmb_Illness);
            this.groupBox1.Controls.Add(this.txt_Age);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Surname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 415);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kayıt Formu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(105, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Rapor";
            // 
            // rtb_Report
            // 
            this.rtb_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_Report.Location = new System.Drawing.Point(190, 299);
            this.rtb_Report.Name = "rtb_Report";
            this.rtb_Report.Size = new System.Drawing.Size(231, 37);
            this.rtb_Report.TabIndex = 14;
            this.rtb_Report.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(128, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "İlaç";
            // 
            // cmb_Medicine
            // 
            this.cmb_Medicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Medicine.FormattingEnabled = true;
            this.cmb_Medicine.Location = new System.Drawing.Point(190, 261);
            this.cmb_Medicine.Name = "cmb_Medicine";
            this.cmb_Medicine.Size = new System.Drawing.Size(231, 30);
            this.cmb_Medicine.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Randevu Günü";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(190, 225);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(231, 30);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hastalık";
            // 
            // rb_Kadin
            // 
            this.rb_Kadin.AutoSize = true;
            this.rb_Kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_Kadin.Location = new System.Drawing.Point(312, 156);
            this.rb_Kadin.Name = "rb_Kadin";
            this.rb_Kadin.Size = new System.Drawing.Size(77, 24);
            this.rb_Kadin.TabIndex = 18;
            this.rb_Kadin.TabStop = true;
            this.rb_Kadin.Text = "Kadın";
            this.rb_Kadin.UseVisualStyleBackColor = true;
            // 
            // rb_Erkek
            // 
            this.rb_Erkek.AutoSize = true;
            this.rb_Erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_Erkek.Location = new System.Drawing.Point(219, 156);
            this.rb_Erkek.Name = "rb_Erkek";
            this.rb_Erkek.Size = new System.Drawing.Size(77, 24);
            this.rb_Erkek.TabIndex = 17;
            this.rb_Erkek.TabStop = true;
            this.rb_Erkek.Text = "Erkek";
            this.rb_Erkek.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(89, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cinsiyet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(130, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Yaş";
            // 
            // cmb_Illness
            // 
            this.cmb_Illness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Illness.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Illness.FormattingEnabled = true;
            this.cmb_Illness.Location = new System.Drawing.Point(190, 189);
            this.cmb_Illness.Name = "cmb_Illness";
            this.cmb_Illness.Size = new System.Drawing.Size(231, 30);
            this.cmb_Illness.TabIndex = 10;
            // 
            // txt_Age
            // 
            this.txt_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Age.Location = new System.Drawing.Point(190, 120);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(231, 30);
            this.txt_Age.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Surname.Location = new System.Drawing.Point(190, 85);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(231, 30);
            this.txt_Surname.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(140, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ad";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Name.Location = new System.Drawing.Point(190, 49);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(231, 30);
            this.txt_Name.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(42, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 54);
            this.label11.TabIndex = 14;
            this.label11.Text = "Silmek için lütfen önce hasta seçiniz!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(427, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(427, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(427, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(427, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(427, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 25);
            this.label16.TabIndex = 28;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(427, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 25);
            this.label17.TabIndex = 29;
            this.label17.Text = "*";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1192, 827);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_RaporGuncelle);
            this.Controls.Add(this.cmb_IlacGuncelle);
            this.Controls.Add(this.cmb_Yonlendir);
            this.Controls.Add(this.btn_RandevuGuncelle);
            this.Controls.Add(this.btn_Yonlendir);
            this.Controls.Add(this.btn_IlacGuncelle);
            this.Controls.Add(this.btn_RaporGuncelle);
            this.Controls.Add(this.dtp_RandevuGuncelle);
            this.Controls.Add(this.btn_HastaSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HastaEkle;
        private System.Windows.Forms.Button btn_HastaSil;
        private System.Windows.Forms.DateTimePicker dtp_RandevuGuncelle;
        private System.Windows.Forms.Button btn_RaporGuncelle;
        private System.Windows.Forms.Button btn_IlacGuncelle;
        private System.Windows.Forms.Button btn_Yonlendir;
        private System.Windows.Forms.Button btn_RandevuGuncelle;
        private System.Windows.Forms.ComboBox cmb_Yonlendir;
        private System.Windows.Forms.ComboBox cmb_IlacGuncelle;
        private System.Windows.Forms.RichTextBox rtb_RaporGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Kadin;
        private System.Windows.Forms.RadioButton rb_Erkek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Illness;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Medicine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_Report;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
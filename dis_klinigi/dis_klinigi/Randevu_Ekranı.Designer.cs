namespace dis_klinigi
{
    partial class Randevu_Ekranı
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu_Ekranı));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            mtxtmtelno = new MaskedTextBox();
            txtmsoyadi = new TextBox();
            txtmadi = new TextBox();
            lbltelno = new Label();
            lblmsoyad = new Label();
            lblmad = new Label();
            txtmtc = new ComboBox();
            lblmtc = new Label();
            groupBox3 = new GroupBox();
            mtxtdrtelno = new MaskedTextBox();
            txtdrsoyad = new TextBox();
            label4 = new Label();
            lbldrsoyad = new Label();
            txtdrad = new ComboBox();
            lbldrad = new Label();
            groupBox4 = new GroupBox();
            txtsaat = new ComboBox();
            lblsaat = new Label();
            lbltarih = new Label();
            date = new DateTimePicker();
            txttucret = new TextBox();
            label3 = new Label();
            txttad = new ComboBox();
            lbltad = new Label();
            btngeri = new Button();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            Kaydet = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtara = new TextBox();
            label6 = new Label();
            btnhasta = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 378);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1452, 374);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Randevu Defteri";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1447, 350);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mtxtmtelno);
            groupBox2.Controls.Add(txtmsoyadi);
            groupBox2.Controls.Add(txtmadi);
            groupBox2.Controls.Add(lbltelno);
            groupBox2.Controls.Add(lblmsoyad);
            groupBox2.Controls.Add(lblmad);
            groupBox2.Controls.Add(txtmtc);
            groupBox2.Controls.Add(lblmtc);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(10, 43);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(455, 224);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hasta Seç";
            // 
            // mtxtmtelno
            // 
            mtxtmtelno.BackColor = Color.Navy;
            mtxtmtelno.BorderStyle = BorderStyle.FixedSingle;
            mtxtmtelno.Font = new Font("Segoe UI", 11F);
            mtxtmtelno.ForeColor = Color.White;
            mtxtmtelno.Location = new Point(156, 170);
            mtxtmtelno.Margin = new Padding(3, 2, 3, 2);
            mtxtmtelno.Mask = "(999) 000-0000";
            mtxtmtelno.Name = "mtxtmtelno";
            mtxtmtelno.ReadOnly = true;
            mtxtmtelno.Size = new Size(275, 27);
            mtxtmtelno.TabIndex = 7;
            // 
            // txtmsoyadi
            // 
            txtmsoyadi.BackColor = Color.Navy;
            txtmsoyadi.BorderStyle = BorderStyle.FixedSingle;
            txtmsoyadi.Font = new Font("Segoe UI", 11F);
            txtmsoyadi.ForeColor = Color.White;
            txtmsoyadi.Location = new Point(156, 128);
            txtmsoyadi.Margin = new Padding(3, 2, 3, 2);
            txtmsoyadi.Name = "txtmsoyadi";
            txtmsoyadi.ReadOnly = true;
            txtmsoyadi.Size = new Size(275, 27);
            txtmsoyadi.TabIndex = 6;
            // 
            // txtmadi
            // 
            txtmadi.BackColor = Color.Navy;
            txtmadi.BorderStyle = BorderStyle.FixedSingle;
            txtmadi.Font = new Font("Segoe UI", 11F);
            txtmadi.ForeColor = Color.White;
            txtmadi.Location = new Point(156, 89);
            txtmadi.Margin = new Padding(3, 2, 3, 2);
            txtmadi.Name = "txtmadi";
            txtmadi.ReadOnly = true;
            txtmadi.Size = new Size(275, 27);
            txtmadi.TabIndex = 5;
            // 
            // lbltelno
            // 
            lbltelno.AutoSize = true;
            lbltelno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbltelno.Location = new Point(5, 170);
            lbltelno.Name = "lbltelno";
            lbltelno.Size = new Size(137, 20);
            lbltelno.TabIndex = 2;
            lbltelno.Text = "Telefon Numarası:";
            // 
            // lblmsoyad
            // 
            lblmsoyad.AutoSize = true;
            lblmsoyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblmsoyad.Location = new Point(75, 129);
            lblmsoyad.Name = "lblmsoyad";
            lblmsoyad.Size = new Size(63, 20);
            lblmsoyad.TabIndex = 4;
            lblmsoyad.Text = "Soyadı :";
            // 
            // lblmad
            // 
            lblmad.AutoSize = true;
            lblmad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblmad.Location = new Point(98, 90);
            lblmad.Name = "lblmad";
            lblmad.Size = new Size(41, 20);
            lblmad.TabIndex = 3;
            lblmad.Text = "Adı :";
            // 
            // txtmtc
            // 
            txtmtc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtmtc.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtmtc.BackColor = Color.White;
            txtmtc.Font = new Font("Segoe UI", 11F);
            txtmtc.FormattingEnabled = true;
            txtmtc.Location = new Point(156, 47);
            txtmtc.Margin = new Padding(3, 2, 3, 2);
            txtmtc.Name = "txtmtc";
            txtmtc.Size = new Size(275, 28);
            txtmtc.TabIndex = 2;
            txtmtc.SelectedIndexChanged += txtmtc_SelectedIndexChanged;
            // 
            // lblmtc
            // 
            lblmtc.AutoSize = true;
            lblmtc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblmtc.Location = new Point(34, 48);
            lblmtc.Name = "lblmtc";
            lblmtc.Size = new Size(105, 20);
            lblmtc.TabIndex = 1;
            lblmtc.Text = "Hasta TC NO :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(mtxtdrtelno);
            groupBox3.Controls.Add(txtdrsoyad);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lbldrsoyad);
            groupBox3.Controls.Add(txtdrad);
            groupBox3.Controls.Add(lbldrad);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(471, 43);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(452, 224);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Doktor Seç";
            // 
            // mtxtdrtelno
            // 
            mtxtdrtelno.BackColor = Color.Navy;
            mtxtdrtelno.BorderStyle = BorderStyle.FixedSingle;
            mtxtdrtelno.Font = new Font("Segoe UI", 11F);
            mtxtdrtelno.ForeColor = Color.White;
            mtxtdrtelno.Location = new Point(163, 131);
            mtxtdrtelno.Margin = new Padding(3, 2, 3, 2);
            mtxtdrtelno.Mask = "(999) 000-0000";
            mtxtdrtelno.Name = "mtxtdrtelno";
            mtxtdrtelno.ReadOnly = true;
            mtxtdrtelno.Size = new Size(275, 27);
            mtxtdrtelno.TabIndex = 8;
            // 
            // txtdrsoyad
            // 
            txtdrsoyad.BackColor = Color.Navy;
            txtdrsoyad.BorderStyle = BorderStyle.FixedSingle;
            txtdrsoyad.Font = new Font("Segoe UI", 11F);
            txtdrsoyad.ForeColor = Color.White;
            txtdrsoyad.Location = new Point(163, 90);
            txtdrsoyad.Margin = new Padding(3, 2, 3, 2);
            txtdrsoyad.Name = "txtdrsoyad";
            txtdrsoyad.ReadOnly = true;
            txtdrsoyad.Size = new Size(275, 27);
            txtdrsoyad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(13, 132);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 2;
            label4.Text = "Telefon Numarası:";
            // 
            // lbldrsoyad
            // 
            lbldrsoyad.AutoSize = true;
            lbldrsoyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbldrsoyad.Location = new Point(29, 91);
            lbldrsoyad.Name = "lbldrsoyad";
            lbldrsoyad.Size = new Size(116, 20);
            lbldrsoyad.TabIndex = 3;
            lbldrsoyad.Text = "Doktor Soyadı :";
            // 
            // txtdrad
            // 
            txtdrad.Font = new Font("Segoe UI", 11F);
            txtdrad.FormattingEnabled = true;
            txtdrad.Location = new Point(163, 48);
            txtdrad.Margin = new Padding(3, 2, 3, 2);
            txtdrad.Name = "txtdrad";
            txtdrad.Size = new Size(275, 28);
            txtdrad.TabIndex = 2;
            txtdrad.SelectedIndexChanged += txtdrad_SelectedIndexChanged;
            // 
            // lbldrad
            // 
            lbldrad.AutoSize = true;
            lbldrad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbldrad.Location = new Point(52, 49);
            lbldrad.Name = "lbldrad";
            lbldrad.Size = new Size(94, 20);
            lbldrad.TabIndex = 1;
            lbldrad.Text = "Doktor Adı :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtsaat);
            groupBox4.Controls.Add(lblsaat);
            groupBox4.Controls.Add(lbltarih);
            groupBox4.Controls.Add(date);
            groupBox4.Controls.Add(txttucret);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txttad);
            groupBox4.Controls.Add(lbltad);
            groupBox4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(928, 43);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(514, 224);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tedavi, Tedavi Günü Ve saati";
            // 
            // txtsaat
            // 
            txtsaat.Font = new Font("Segoe UI", 11F);
            txtsaat.FormattingEnabled = true;
            txtsaat.Location = new Point(181, 166);
            txtsaat.Margin = new Padding(3, 2, 3, 2);
            txtsaat.Name = "txtsaat";
            txtsaat.Size = new Size(99, 28);
            txtsaat.TabIndex = 9;
            txtsaat.SelectedIndexChanged += txtsaat_SelectedIndexChanged;
            // 
            // lblsaat
            // 
            lblsaat.AutoSize = true;
            lblsaat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblsaat.ForeColor = Color.Transparent;
            lblsaat.Location = new Point(51, 169);
            lblsaat.Name = "lblsaat";
            lblsaat.Size = new Size(104, 20);
            lblsaat.TabIndex = 8;
            lblsaat.Text = "Tedavi Saati  :";
            // 
            // lbltarih
            // 
            lbltarih.AutoSize = true;
            lbltarih.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbltarih.ForeColor = Color.Transparent;
            lbltarih.Location = new Point(51, 132);
            lbltarih.Name = "lbltarih";
            lbltarih.Size = new Size(109, 20);
            lbltarih.TabIndex = 7;
            lbltarih.Text = "Tedavi Tarihi  :";
            // 
            // date
            // 
            date.Location = new Point(181, 131);
            date.Margin = new Padding(3, 2, 3, 2);
            date.Name = "date";
            date.Size = new Size(275, 27);
            date.TabIndex = 6;
            date.ValueChanged += date_ValueChanged;
            // 
            // txttucret
            // 
            txttucret.BackColor = Color.Navy;
            txttucret.BorderStyle = BorderStyle.FixedSingle;
            txttucret.Font = new Font("Segoe UI", 11F);
            txttucret.ForeColor = Color.White;
            txttucret.Location = new Point(181, 90);
            txttucret.Margin = new Padding(3, 2, 3, 2);
            txttucret.Name = "txttucret";
            txttucret.ReadOnly = true;
            txttucret.Size = new Size(275, 27);
            txttucret.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(31, 94);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 3;
            label3.Text = "Tedavinin Ücreti :";
            // 
            // txttad
            // 
            txttad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txttad.AutoCompleteSource = AutoCompleteSource.ListItems;
            txttad.Font = new Font("Segoe UI", 11F);
            txttad.FormattingEnabled = true;
            txttad.Location = new Point(181, 48);
            txttad.Margin = new Padding(3, 2, 3, 2);
            txttad.Name = "txttad";
            txttad.Size = new Size(275, 28);
            txttad.TabIndex = 2;
            txttad.SelectedIndexChanged += txttad_SelectedIndexChanged;
            // 
            // lbltad
            // 
            lbltad.AutoSize = true;
            lbltad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbltad.ForeColor = Color.Transparent;
            lbltad.Location = new Point(5, 49);
            lbltad.Name = "lbltad";
            lbltad.Size = new Size(155, 20);
            lbltad.TabIndex = 1;
            lbltad.Text = "Uygulanacak Tedavi :";
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Navy;
            btngeri.BackgroundImage = (Image)resources.GetObject("btngeri.BackgroundImage");
            btngeri.BackgroundImageLayout = ImageLayout.Stretch;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(1405, 8);
            btngeri.Margin = new Padding(3, 2, 3, 2);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(33, 28);
            btngeri.TabIndex = 12;
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Navy;
            btnsil.BackgroundImage = (Image)resources.GetObject("btnsil.BackgroundImage");
            btnsil.BackgroundImageLayout = ImageLayout.Stretch;
            btnsil.FlatAppearance.BorderSize = 0;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnsil.ForeColor = SystemColors.Control;
            btnsil.Location = new Point(1308, 292);
            btnsil.Margin = new Padding(3, 2, 3, 2);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(134, 64);
            btnsil.TabIndex = 38;
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btndüzenle
            // 
            btndüzenle.BackColor = Color.Navy;
            btndüzenle.BackgroundImage = (Image)resources.GetObject("btndüzenle.BackgroundImage");
            btndüzenle.BackgroundImageLayout = ImageLayout.Stretch;
            btndüzenle.FlatAppearance.BorderSize = 0;
            btndüzenle.FlatStyle = FlatStyle.Flat;
            btndüzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btndüzenle.Location = new Point(1129, 292);
            btndüzenle.Margin = new Padding(3, 2, 3, 2);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(134, 64);
            btndüzenle.TabIndex = 37;
            btndüzenle.UseVisualStyleBackColor = false;
            btndüzenle.Click += btndüzenle_Click;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.Navy;
            btnekle.BackgroundImage = (Image)resources.GetObject("btnekle.BackgroundImage");
            btnekle.BackgroundImageLayout = ImageLayout.Stretch;
            btnekle.FlatAppearance.BorderSize = 0;
            btnekle.FlatStyle = FlatStyle.Flat;
            btnekle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnekle.Location = new Point(948, 292);
            btnekle.Margin = new Padding(3, 2, 3, 2);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(134, 64);
            btnekle.TabIndex = 36;
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // Kaydet
            // 
            Kaydet.AutoSize = true;
            Kaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Kaydet.ForeColor = Color.White;
            Kaydet.Location = new Point(974, 358);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(56, 19);
            Kaydet.TabIndex = 9;
            Kaydet.Text = "Kaydet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1166, 358);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 39;
            label1.Text = "Düzenle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1358, 358);
            label2.Name = "label2";
            label2.Size = new Size(25, 19);
            label2.TabIndex = 40;
            label2.Text = "Sil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(634, 279);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 41;
            label5.Text = "Randevu Ara";
            // 
            // txtara
            // 
            txtara.BackColor = Color.Navy;
            txtara.BorderStyle = BorderStyle.FixedSingle;
            txtara.Font = new Font("Segoe UI", 11F);
            txtara.ForeColor = Color.White;
            txtara.Location = new Point(471, 314);
            txtara.Margin = new Padding(3, 2, 3, 2);
            txtara.Name = "txtara";
            txtara.Size = new Size(435, 27);
            txtara.TabIndex = 42;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(10, 279);
            label6.Name = "label6";
            label6.Size = new Size(365, 38);
            label6.TabIndex = 43;
            label6.Text = "Hasta Eklemeden Bu Sayfaya Geldiyseniz Lütfen İlk Başta \r\nHasta Ekleyniz Ve ardından Bu Sayfaya Tekrardan Dönün!!!\r\n";
            // 
            // btnhasta
            // 
            btnhasta.BackColor = Color.Navy;
            btnhasta.BackgroundImage = (Image)resources.GetObject("btnhasta.BackgroundImage");
            btnhasta.BackgroundImageLayout = ImageLayout.Stretch;
            btnhasta.FlatAppearance.BorderSize = 0;
            btnhasta.FlatStyle = FlatStyle.Flat;
            btnhasta.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnhasta.ForeColor = Color.PaleGreen;
            btnhasta.ImageAlign = ContentAlignment.TopCenter;
            btnhasta.Location = new Point(10, 318);
            btnhasta.Margin = new Padding(3, 2, 3, 2);
            btnhasta.Name = "btnhasta";
            btnhasta.Size = new Size(152, 58);
            btnhasta.TabIndex = 44;
            btnhasta.UseVisualStyleBackColor = false;
            btnhasta.Click += btnhasta_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(188, 330);
            label7.Name = "label7";
            label7.Size = new Size(89, 40);
            label7.TabIndex = 45;
            label7.Text = "Hasta Kayıt\r\nSayfası\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(63, 11);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 47;
            label8.Text = "Randevu ";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(1358, 7);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(33, 28);
            button1.TabIndex = 48;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Randevu_Ekranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1452, 752);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(btnhasta);
            Controls.Add(label6);
            Controls.Add(txtara);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Kaydet);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(btngeri);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Randevu_Ekranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu_Ekranı";
            FormClosing += Randevu_Ekranı_FormClosing;
            Load += Randevu_Ekranı_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label lblmtc;
        private Label lblmad;
        private ComboBox txtmtc;
        private TextBox txtmsoyadi;
        private TextBox txtmadi;
        private Label lbltelno;
        private Label lblmsoyad;
        private GroupBox groupBox3;
        private TextBox txtdrsoyad;
        private Label label4;
        private Label lbldrsoyad;
        private ComboBox txtdrad;
        private Label lbldrad;
        private MaskedTextBox mtxtmtelno;
        private MaskedTextBox mtxtdrtelno;
        private GroupBox groupBox4;
        private TextBox txttucret;
        private Label label3;
        private ComboBox txttad;
        private Label lbltad;
        private ComboBox txtsaat;
        private Label lblsaat;
        private Label lbltarih;
        private DateTimePicker date;
        private Button btngeri;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
        private Label Kaydet;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtara;
        private Label label6;
        private Button btnhasta;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private Button button1;
    }
}
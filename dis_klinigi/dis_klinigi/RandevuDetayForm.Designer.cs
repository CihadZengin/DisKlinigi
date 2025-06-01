namespace dis_klinigi
{
    partial class RandevuDetayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuDetayForm));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            btnBorcuKaydet = new Button();
            lblToplamBorc = new Label();
            lblHastaTC = new Label();
            groupBox3 = new GroupBox();
            lblHastaCinsiyeti = new Label();
            lblHastaTelefon = new Label();
            lblHastaAdiSoyadi = new Label();
            btnOdemeIslemleri = new Button();
            btngeri = new Button();
            btnodemegeçmişi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnYazdir = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 349);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tedavi Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.DimGray;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(975, 341);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(1002, 349);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 373);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İlaç Detayları";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.GridColor = Color.DimGray;
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(507, 341);
            dataGridView2.TabIndex = 0;
            // 
            // btnBorcuKaydet
            // 
            btnBorcuKaydet.BackgroundImage = (Image)resources.GetObject("btnBorcuKaydet.BackgroundImage");
            btnBorcuKaydet.BackgroundImageLayout = ImageLayout.Stretch;
            btnBorcuKaydet.FlatAppearance.BorderSize = 0;
            btnBorcuKaydet.FlatStyle = FlatStyle.Flat;
            btnBorcuKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBorcuKaydet.Location = new Point(1029, 59);
            btnBorcuKaydet.Name = "btnBorcuKaydet";
            btnBorcuKaydet.Size = new Size(158, 100);
            btnBorcuKaydet.TabIndex = 3;
            btnBorcuKaydet.UseVisualStyleBackColor = true;
            btnBorcuKaydet.Click += btnBorcuKaydet_Click;
            // 
            // lblToplamBorc
            // 
            lblToplamBorc.AutoSize = true;
            lblToplamBorc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblToplamBorc.ForeColor = Color.White;
            lblToplamBorc.Location = new Point(25, 308);
            lblToplamBorc.Name = "lblToplamBorc";
            lblToplamBorc.Size = new Size(59, 23);
            lblToplamBorc.TabIndex = 12;
            lblToplamBorc.Text = "label4";
            // 
            // lblHastaTC
            // 
            lblHastaTC.AutoSize = true;
            lblHastaTC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHastaTC.Location = new Point(48, 47);
            lblHastaTC.Name = "lblHastaTC";
            lblHastaTC.Size = new Size(113, 28);
            lblHastaTC.TabIndex = 13;
            lblHastaTC.Text = "lblHastaTC";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblHastaCinsiyeti);
            groupBox3.Controls.Add(lblHastaTelefon);
            groupBox3.Controls.Add(lblHastaAdiSoyadi);
            groupBox3.Controls.Add(lblHastaTC);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(15, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(984, 243);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta Bilgileri";
            // 
            // lblHastaCinsiyeti
            // 
            lblHastaCinsiyeti.AutoSize = true;
            lblHastaCinsiyeti.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHastaCinsiyeti.Location = new Point(538, 48);
            lblHastaCinsiyeti.Name = "lblHastaCinsiyeti";
            lblHastaCinsiyeti.Size = new Size(171, 28);
            lblHastaCinsiyeti.TabIndex = 16;
            lblHastaCinsiyeti.Text = "lblHastaCinsiyeti";
            // 
            // lblHastaTelefon
            // 
            lblHastaTelefon.AutoSize = true;
            lblHastaTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHastaTelefon.Location = new Point(538, 169);
            lblHastaTelefon.Name = "lblHastaTelefon";
            lblHastaTelefon.Size = new Size(160, 28);
            lblHastaTelefon.TabIndex = 15;
            lblHastaTelefon.Text = "lblHastaTelefon";
            // 
            // lblHastaAdiSoyadi
            // 
            lblHastaAdiSoyadi.AutoSize = true;
            lblHastaAdiSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHastaAdiSoyadi.Location = new Point(48, 169);
            lblHastaAdiSoyadi.Name = "lblHastaAdiSoyadi";
            lblHastaAdiSoyadi.Size = new Size(185, 28);
            lblHastaAdiSoyadi.TabIndex = 14;
            lblHastaAdiSoyadi.Text = "lblHastaAdiSoyadi";
            // 
            // btnOdemeIslemleri
            // 
            btnOdemeIslemleri.BackgroundImage = (Image)resources.GetObject("btnOdemeIslemleri.BackgroundImage");
            btnOdemeIslemleri.BackgroundImageLayout = ImageLayout.Stretch;
            btnOdemeIslemleri.FlatAppearance.BorderSize = 0;
            btnOdemeIslemleri.FlatStyle = FlatStyle.Flat;
            btnOdemeIslemleri.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOdemeIslemleri.Location = new Point(1343, 60);
            btnOdemeIslemleri.Name = "btnOdemeIslemleri";
            btnOdemeIslemleri.Size = new Size(143, 100);
            btnOdemeIslemleri.TabIndex = 15;
            btnOdemeIslemleri.UseVisualStyleBackColor = true;
            btnOdemeIslemleri.Click += btnOdemeIslemleri_Click;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Navy;
            btngeri.BackgroundImage = (Image)resources.GetObject("btngeri.BackgroundImage");
            btngeri.BackgroundImageLayout = ImageLayout.Stretch;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(1486, 12);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(38, 38);
            btngeri.TabIndex = 16;
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // btnodemegeçmişi
            // 
            btnodemegeçmişi.BackgroundImage = (Image)resources.GetObject("btnodemegeçmişi.BackgroundImage");
            btnodemegeçmişi.BackgroundImageLayout = ImageLayout.Stretch;
            btnodemegeçmişi.FlatAppearance.BorderSize = 0;
            btnodemegeçmişi.FlatStyle = FlatStyle.Flat;
            btnodemegeçmişi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnodemegeçmişi.Location = new Point(1343, 216);
            btnodemegeçmişi.Name = "btnodemegeçmişi";
            btnodemegeçmişi.Size = new Size(143, 100);
            btnodemegeçmişi.TabIndex = 17;
            btnodemegeçmişi.UseVisualStyleBackColor = true;
            btnodemegeçmişi.Click += btnodemegeçmişi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(1068, 162);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 18;
            label1.Text = "Hesapla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(1359, 163);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 19;
            label2.Text = "Ödeme Yap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1343, 319);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 20;
            label3.Text = "Ödeme Geçmişi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1079, 320);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 22;
            label4.Text = "Yazdır";
            // 
            // btnYazdir
            // 
            btnYazdir.BackgroundImage = (Image)resources.GetObject("btnYazdir.BackgroundImage");
            btnYazdir.BackgroundImageLayout = ImageLayout.Stretch;
            btnYazdir.FlatAppearance.BorderSize = 0;
            btnYazdir.FlatStyle = FlatStyle.Flat;
            btnYazdir.Location = new Point(1029, 215);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(158, 100);
            btnYazdir.TabIndex = 21;
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(1433, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 49;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RandevuDetayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1536, 734);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnYazdir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnodemegeçmişi);
            Controls.Add(btngeri);
            Controls.Add(btnOdemeIslemleri);
            Controls.Add(groupBox3);
            Controls.Add(lblToplamBorc);
            Controls.Add(btnBorcuKaydet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RandevuDetayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandevuDetayForm";
            Load += RandevuDetayForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button btnBorcuKaydet;
        private Label lblToplamBorc;
        private Label lblHastaTC;
        private GroupBox groupBox3;
        private Label lblHastaCinsiyeti;
        private Label lblHastaTelefon;
        private Label lblHastaAdiSoyadi;
        private Button btnOdemeIslemleri;
        private Button btngeri;
        private Button btnodemegeçmişi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnYazdir;
        private Button button1;
    }
}
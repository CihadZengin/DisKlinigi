namespace dis_klinigi
{
    partial class recete_ver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recete_ver));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            txtmsoyadi = new TextBox();
            txtmadi = new TextBox();
            lblmsoyad = new Label();
            lblmad = new Label();
            txtmtc = new ComboBox();
            lblmtc = new Label();
            groupBox3 = new GroupBox();
            txtdetay = new RichTextBox();
            txtikosul = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtiadi = new ComboBox();
            btngeri = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            txtara = new TextBox();
            lblara = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 591);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1225, 401);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recete Detayları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1219, 369);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtmsoyadi);
            groupBox2.Controls.Add(txtmadi);
            groupBox2.Controls.Add(lblmsoyad);
            groupBox2.Controls.Add(lblmad);
            groupBox2.Controls.Add(txtmtc);
            groupBox2.Controls.Add(lblmtc);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(43, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 246);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hasta Seç";
            // 
            // txtmsoyadi
            // 
            txtmsoyadi.BackColor = Color.Navy;
            txtmsoyadi.BorderStyle = BorderStyle.FixedSingle;
            txtmsoyadi.Font = new Font("Segoe UI", 11F);
            txtmsoyadi.ForeColor = Color.White;
            txtmsoyadi.Location = new Point(166, 169);
            txtmsoyadi.Name = "txtmsoyadi";
            txtmsoyadi.ReadOnly = true;
            txtmsoyadi.Size = new Size(314, 32);
            txtmsoyadi.TabIndex = 6;
            // 
            // txtmadi
            // 
            txtmadi.BackColor = Color.Navy;
            txtmadi.BorderStyle = BorderStyle.FixedSingle;
            txtmadi.Font = new Font("Segoe UI", 11F);
            txtmadi.ForeColor = Color.White;
            txtmadi.Location = new Point(166, 117);
            txtmadi.Name = "txtmadi";
            txtmadi.ReadOnly = true;
            txtmadi.Size = new Size(314, 32);
            txtmadi.TabIndex = 5;
            // 
            // lblmsoyad
            // 
            lblmsoyad.AutoSize = true;
            lblmsoyad.Location = new Point(59, 172);
            lblmsoyad.Name = "lblmsoyad";
            lblmsoyad.Size = new Size(82, 25);
            lblmsoyad.TabIndex = 4;
            lblmsoyad.Text = "Soyadı :";
            // 
            // lblmad
            // 
            lblmad.AutoSize = true;
            lblmad.Location = new Point(85, 120);
            lblmad.Name = "lblmad";
            lblmad.Size = new Size(52, 25);
            lblmad.TabIndex = 3;
            lblmad.Text = "Adı :";
            // 
            // txtmtc
            // 
            txtmtc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtmtc.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtmtc.Font = new Font("Segoe UI", 11F);
            txtmtc.FormattingEnabled = true;
            txtmtc.Location = new Point(166, 61);
            txtmtc.Name = "txtmtc";
            txtmtc.Size = new Size(314, 33);
            txtmtc.TabIndex = 2;
            txtmtc.SelectedIndexChanged += txtmtc_SelectedIndexChanged;
            // 
            // lblmtc
            // 
            lblmtc.AutoSize = true;
            lblmtc.Location = new Point(12, 64);
            lblmtc.Name = "lblmtc";
            lblmtc.Size = new Size(133, 25);
            lblmtc.TabIndex = 1;
            lblmtc.Text = "Hasta TC NO :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtdetay);
            groupBox3.Controls.Add(txtikosul);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtiadi);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(576, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(616, 523);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta Seç";
            // 
            // txtdetay
            // 
            txtdetay.BackColor = Color.Navy;
            txtdetay.BorderStyle = BorderStyle.FixedSingle;
            txtdetay.Font = new Font("Segoe UI", 11F);
            txtdetay.ForeColor = Color.White;
            txtdetay.Location = new Point(203, 167);
            txtdetay.Name = "txtdetay";
            txtdetay.ReadOnly = true;
            txtdetay.Size = new Size(384, 291);
            txtdetay.TabIndex = 6;
            txtdetay.Text = "";
            // 
            // txtikosul
            // 
            txtikosul.BackColor = Color.Navy;
            txtikosul.BorderStyle = BorderStyle.FixedSingle;
            txtikosul.Font = new Font("Segoe UI", 11F);
            txtikosul.ForeColor = Color.White;
            txtikosul.Location = new Point(203, 112);
            txtikosul.Name = "txtikosul";
            txtikosul.ReadOnly = true;
            txtikosul.Size = new Size(314, 32);
            txtikosul.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 169);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 2;
            label1.Text = "Detaylar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 114);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 4;
            label2.Text = "Kullanım Koşulları:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 61);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "İlaç Adı :";
            // 
            // txtiadi
            // 
            txtiadi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtiadi.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtiadi.Font = new Font("Segoe UI", 11F);
            txtiadi.FormattingEnabled = true;
            txtiadi.Location = new Point(203, 56);
            txtiadi.Name = "txtiadi";
            txtiadi.Size = new Size(314, 33);
            txtiadi.TabIndex = 2;
            txtiadi.SelectedIndexChanged += txtiadi_SelectedIndexChanged;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Navy;
            btngeri.BackgroundImage = (Image)resources.GetObject("btngeri.BackgroundImage");
            btngeri.BackgroundImageLayout = ImageLayout.Stretch;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(1171, 12);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(38, 38);
            btngeri.TabIndex = 37;
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(75, 21);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 46;
            label4.Text = "Reçete";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(471, 429);
            label5.Name = "label5";
            label5.Size = new Size(33, 25);
            label5.TabIndex = 52;
            label5.Text = "Sil";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(255, 429);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 51;
            label6.Text = "Düzenle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(84, 429);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 50;
            label7.Text = "Ekle";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Navy;
            btnsil.BackgroundImage = (Image)resources.GetObject("btnsil.BackgroundImage");
            btnsil.BackgroundImageLayout = ImageLayout.Stretch;
            btnsil.FlatAppearance.BorderSize = 0;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnsil.Location = new Point(410, 340);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(148, 85);
            btnsil.TabIndex = 49;
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
            btndüzenle.Location = new Point(218, 340);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(153, 85);
            btndüzenle.TabIndex = 48;
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
            btnekle.Location = new Point(35, 340);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(153, 85);
            btnekle.TabIndex = 47;
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // txtara
            // 
            txtara.BackColor = Color.Navy;
            txtara.BorderStyle = BorderStyle.FixedSingle;
            txtara.Font = new Font("Segoe UI", 11F);
            txtara.ForeColor = Color.White;
            txtara.Location = new Point(84, 537);
            txtara.Name = "txtara";
            txtara.Size = new Size(420, 32);
            txtara.TabIndex = 54;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblara.ForeColor = Color.White;
            lblara.Location = new Point(239, 486);
            lblara.Name = "lblara";
            lblara.Size = new Size(111, 25);
            lblara.TabIndex = 53;
            lblara.Text = "Reçete Ara ";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(1114, 11);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 55;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // recete_ver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1225, 992);
            Controls.Add(button1);
            Controls.Add(txtara);
            Controls.Add(lblara);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btngeri);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recete_ver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "recete_ver";
            Load += recete_ver_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox txtmsoyadi;
        private TextBox txtmadi;
        private Label lblmsoyad;
        private Label lblmad;
        private ComboBox txtmtc;
        private Label lblmtc;
        private GroupBox groupBox3;
        private TextBox txtikosul;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtiadi;
        private RichTextBox txtdetay;
        private Button btngeri;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
        private TextBox txtara;
        private Label lblara;
        private Button button1;
    }
}
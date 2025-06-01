namespace dis_klinigi
{
    partial class Doktorlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorlar));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtsoyadi = new TextBox();
            lblsoyadi = new Label();
            txtadi = new TextBox();
            lbladi = new Label();
            label3 = new Label();
            grpcinsiyet = new GroupBox();
            radiok = new RadioButton();
            radioe = new RadioButton();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            btngeri = new Button();
            txtara = new TextBox();
            lblara = new Label();
            txtmail = new TextBox();
            lblmail = new Label();
            label1 = new Label();
            mtxttelno = new MaskedTextBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpcinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 469);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1099, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktorlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView1.Size = new Size(1093, 358);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // txtsoyadi
            // 
            txtsoyadi.BackColor = Color.Navy;
            txtsoyadi.BorderStyle = BorderStyle.FixedSingle;
            txtsoyadi.Font = new Font("Segoe UI", 11F);
            txtsoyadi.ForeColor = Color.White;
            txtsoyadi.Location = new Point(112, 171);
            txtsoyadi.Name = "txtsoyadi";
            txtsoyadi.Size = new Size(316, 32);
            txtsoyadi.TabIndex = 10;
            // 
            // lblsoyadi
            // 
            lblsoyadi.AutoSize = true;
            lblsoyadi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblsoyadi.ForeColor = Color.White;
            lblsoyadi.Location = new Point(183, 133);
            lblsoyadi.Name = "lblsoyadi";
            lblsoyadi.Size = new Size(170, 25);
            lblsoyadi.TabIndex = 9;
            lblsoyadi.Text = "Doktorun Soyadı ";
            // 
            // txtadi
            // 
            txtadi.BackColor = Color.Navy;
            txtadi.BorderStyle = BorderStyle.FixedSingle;
            txtadi.Font = new Font("Segoe UI", 11F);
            txtadi.ForeColor = Color.White;
            txtadi.Location = new Point(112, 85);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(316, 32);
            txtadi.TabIndex = 8;
            // 
            // lbladi
            // 
            lbladi.AutoSize = true;
            lbladi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbladi.ForeColor = Color.White;
            lbladi.Location = new Point(198, 42);
            lbladi.Name = "lbladi";
            lbladi.Size = new Size(140, 25);
            lbladi.TabIndex = 7;
            lbladi.Text = "Doktorun Adı ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(135, 223);
            label3.Name = "label3";
            label3.Size = new Size(265, 25);
            label3.TabIndex = 11;
            label3.Text = "Doktorun Telefon Numarası ";
            // 
            // grpcinsiyet
            // 
            grpcinsiyet.Controls.Add(radiok);
            grpcinsiyet.Controls.Add(radioe);
            grpcinsiyet.Font = new Font("Segoe UI", 10F);
            grpcinsiyet.Location = new Point(653, 171);
            grpcinsiyet.Name = "grpcinsiyet";
            grpcinsiyet.Size = new Size(316, 59);
            grpcinsiyet.TabIndex = 13;
            grpcinsiyet.TabStop = false;
            // 
            // radiok
            // 
            radiok.AutoSize = true;
            radiok.ForeColor = Color.White;
            radiok.Location = new Point(144, 19);
            radiok.Name = "radiok";
            radiok.Size = new Size(74, 27);
            radiok.TabIndex = 13;
            radiok.TabStop = true;
            radiok.Text = "Kadın";
            radiok.UseVisualStyleBackColor = true;
            // 
            // radioe
            // 
            radioe.AutoSize = true;
            radioe.ForeColor = Color.White;
            radioe.Location = new Point(16, 19);
            radioe.Name = "radioe";
            radioe.Size = new Size(71, 27);
            radioe.TabIndex = 12;
            radioe.TabStop = true;
            radioe.Text = "Erkek";
            radioe.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Navy;
            btnsil.BackgroundImage = (Image)resources.GetObject("btnsil.BackgroundImage");
            btnsil.BackgroundImageLayout = ImageLayout.Stretch;
            btnsil.FlatAppearance.BorderSize = 0;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnsil.Location = new Point(903, 316);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(153, 85);
            btnsil.TabIndex = 31;
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
            btndüzenle.Location = new Point(480, 316);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(153, 85);
            btndüzenle.TabIndex = 30;
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
            btnekle.Location = new Point(50, 316);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(153, 85);
            btnekle.TabIndex = 29;
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Navy;
            btngeri.BackgroundImage = (Image)resources.GetObject("btngeri.BackgroundImage");
            btngeri.BackgroundImageLayout = ImageLayout.Stretch;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(1045, 7);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(38, 38);
            btngeri.TabIndex = 32;
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // txtara
            // 
            txtara.BackColor = Color.Navy;
            txtara.BorderStyle = BorderStyle.FixedSingle;
            txtara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtara.ForeColor = Color.White;
            txtara.Location = new Point(624, 441);
            txtara.Name = "txtara";
            txtara.Size = new Size(316, 32);
            txtara.TabIndex = 34;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblara.ForeColor = Color.White;
            lblara.Location = new Point(722, 404);
            lblara.Name = "lblara";
            lblara.Size = new Size(120, 25);
            lblara.TabIndex = 33;
            lblara.Text = "Doktor Bul :";
            // 
            // txtmail
            // 
            txtmail.BackColor = Color.Navy;
            txtmail.BorderStyle = BorderStyle.FixedSingle;
            txtmail.Font = new Font("Segoe UI", 11F);
            txtmail.ForeColor = Color.White;
            txtmail.Location = new Point(653, 84);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(316, 32);
            txtmail.TabIndex = 36;
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblmail.ForeColor = Color.White;
            lblmail.Location = new Point(698, 42);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(227, 25);
            lblmail.TabIndex = 35;
            lblmail.Text = "Doktorun Gmail Adresi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(731, 133);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 37;
            label1.Text = "Doktor Cinsiyet :";
            // 
            // mtxttelno
            // 
            mtxttelno.BackColor = Color.Navy;
            mtxttelno.BorderStyle = BorderStyle.FixedSingle;
            mtxttelno.Font = new Font("Segoe UI", 11F);
            mtxttelno.ForeColor = Color.White;
            mtxttelno.Location = new Point(112, 259);
            mtxttelno.Mask = "(999) 000-0000";
            mtxttelno.Name = "mtxttelno";
            mtxttelno.Size = new Size(316, 32);
            mtxttelno.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 407);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 39;
            label2.Text = "Ekle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(511, 404);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 40;
            label5.Text = "Düzenle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(951, 407);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 41;
            label4.Text = "   Sil";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 18);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 42;
            label6.Text = "Doktorlar";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(987, 6);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 57;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Doktorlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1099, 859);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(mtxttelno);
            Controls.Add(label1);
            Controls.Add(txtmail);
            Controls.Add(lblmail);
            Controls.Add(txtara);
            Controls.Add(lblara);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(grpcinsiyet);
            Controls.Add(btnekle);
            Controls.Add(label3);
            Controls.Add(txtsoyadi);
            Controls.Add(lblsoyadi);
            Controls.Add(txtadi);
            Controls.Add(lbladi);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doktorlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktorlar";
            Load += Doktorlar_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpcinsiyet.ResumeLayout(false);
            grpcinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtsoyadi;
        private Label lblsoyadi;
        private TextBox txtadi;
        private Label lbladi;
        private Label label3;
        private GroupBox grpcinsiyet;
        private RadioButton radiok;
        private RadioButton radioe;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
        private Button btngeri;
        private TextBox txtara;
        private Label lblara;
        private TextBox txtmail;
        private Label lblmail;
        private Label label1;
        private MaskedTextBox mtxttelno;
        private Label label2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label6;
        private Button button1;
    }
}
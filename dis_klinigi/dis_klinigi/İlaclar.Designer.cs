namespace dis_klinigi
{
    partial class İlaclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlaclar));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtkullanimi = new TextBox();
            lblkullanimi = new Label();
            txtadi = new TextBox();
            lbladi = new Label();
            rtxtilacdetay = new RichTextBox();
            label1 = new Label();
            txtara = new TextBox();
            lblara = new Label();
            btngeri = new Button();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 434);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlaçlar";
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
            dataGridView1.Size = new Size(1076, 322);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // txtkullanimi
            // 
            txtkullanimi.BackColor = Color.Navy;
            txtkullanimi.BorderStyle = BorderStyle.FixedSingle;
            txtkullanimi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtkullanimi.ForeColor = Color.White;
            txtkullanimi.Location = new Point(77, 174);
            txtkullanimi.Name = "txtkullanimi";
            txtkullanimi.Size = new Size(337, 32);
            txtkullanimi.TabIndex = 14;
            // 
            // lblkullanimi
            // 
            lblkullanimi.AutoSize = true;
            lblkullanimi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblkullanimi.ForeColor = Color.White;
            lblkullanimi.Location = new Point(175, 131);
            lblkullanimi.Name = "lblkullanimi";
            lblkullanimi.Size = new Size(135, 25);
            lblkullanimi.TabIndex = 13;
            lblkullanimi.Text = "İlaç Kullanımı ";
            // 
            // txtadi
            // 
            txtadi.BackColor = Color.Navy;
            txtadi.BorderStyle = BorderStyle.FixedSingle;
            txtadi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtadi.ForeColor = Color.White;
            txtadi.Location = new Point(77, 85);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(337, 32);
            txtadi.TabIndex = 12;
            // 
            // lbladi
            // 
            lbladi.AutoSize = true;
            lbladi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbladi.ForeColor = Color.White;
            lbladi.Location = new Point(202, 50);
            lbladi.Name = "lbladi";
            lbladi.Size = new Size(82, 25);
            lbladi.TabIndex = 11;
            lbladi.Text = "İlaç Adı ";
            // 
            // rtxtilacdetay
            // 
            rtxtilacdetay.BackColor = Color.Navy;
            rtxtilacdetay.BorderStyle = BorderStyle.FixedSingle;
            rtxtilacdetay.Font = new Font("Segoe UI", 11F);
            rtxtilacdetay.ForeColor = Color.White;
            rtxtilacdetay.Location = new Point(648, 59);
            rtxtilacdetay.Name = "rtxtilacdetay";
            rtxtilacdetay.Size = new Size(422, 266);
            rtxtilacdetay.TabIndex = 15;
            rtxtilacdetay.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(506, 64);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 16;
            label1.Text = "İlaç Detayları :";
            // 
            // txtara
            // 
            txtara.BackColor = Color.Navy;
            txtara.BorderStyle = BorderStyle.FixedSingle;
            txtara.Font = new Font("Segoe UI", 10F);
            txtara.ForeColor = Color.White;
            txtara.Location = new Point(702, 398);
            txtara.Name = "txtara";
            txtara.Size = new Size(337, 30);
            txtara.TabIndex = 18;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblara.ForeColor = Color.White;
            lblara.Location = new Point(829, 360);
            lblara.Name = "lblara";
            lblara.Size = new Size(83, 25);
            lblara.TabIndex = 17;
            lblara.Text = "İlaç Ara ";
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Navy;
            btngeri.BackgroundImage = (Image)resources.GetObject("btngeri.BackgroundImage");
            btngeri.BackgroundImageLayout = ImageLayout.Stretch;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(1028, 7);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(38, 38);
            btngeri.TabIndex = 36;
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
            btnsil.Location = new Point(403, 252);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(148, 85);
            btnsil.TabIndex = 35;
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
            btndüzenle.Location = new Point(211, 252);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(153, 85);
            btndüzenle.TabIndex = 34;
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
            btnekle.Location = new Point(28, 252);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(153, 85);
            btnekle.TabIndex = 33;
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 341);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 41;
            label2.Text = "Ekle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(248, 341);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 42;
            label5.Text = "Düzenle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(464, 341);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 43;
            label4.Text = "Sil";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 18);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 44;
            label3.Text = "İlaçlar";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(970, 6);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 45;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // İlaclar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1082, 788);
            Controls.Add(button1);
            Controls.Add(txtara);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(lblara);
            Controls.Add(label1);
            Controls.Add(rtxtilacdetay);
            Controls.Add(txtkullanimi);
            Controls.Add(lblkullanimi);
            Controls.Add(txtadi);
            Controls.Add(lbladi);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "İlaclar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İlaclar";
            Load += İlaclar_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtkullanimi;
        private Label lblkullanimi;
        private TextBox txtadi;
        private Label lbladi;
        private RichTextBox rtxtilacdetay;
        private Label label1;
        private TextBox txtara;
        private Label lblara;
        private Button btngeri;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
        private Label label2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
    }
}
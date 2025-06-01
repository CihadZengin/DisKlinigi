namespace dis_klinigi
{
    partial class Tedaviler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedaviler));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            lbltedaviad = new Label();
            lblfiyat = new Label();
            txtadi = new TextBox();
            txtfiyat = new TextBox();
            lblara = new Label();
            txtara = new TextBox();
            btngeri = new Button();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 383);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tedaviler";
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
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(747, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // lbltedaviad
            // 
            lbltedaviad.AutoSize = true;
            lbltedaviad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbltedaviad.ForeColor = Color.White;
            lbltedaviad.Location = new Point(179, 89);
            lbltedaviad.Name = "lbltedaviad";
            lbltedaviad.Size = new Size(108, 25);
            lbltedaviad.TabIndex = 1;
            lbltedaviad.Text = "Tedavi Adı ";
            // 
            // lblfiyat
            // 
            lblfiyat.AutoSize = true;
            lblfiyat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblfiyat.ForeColor = Color.White;
            lblfiyat.Location = new Point(170, 187);
            lblfiyat.Name = "lblfiyat";
            lblfiyat.Size = new Size(125, 25);
            lblfiyat.TabIndex = 2;
            lblfiyat.Text = "Tedavi Fiyatı ";
            // 
            // txtadi
            // 
            txtadi.BackColor = Color.Navy;
            txtadi.BorderStyle = BorderStyle.FixedSingle;
            txtadi.Font = new Font("Segoe UI", 11F);
            txtadi.ForeColor = Color.White;
            txtadi.Location = new Point(72, 127);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(327, 32);
            txtadi.TabIndex = 3;
            // 
            // txtfiyat
            // 
            txtfiyat.BackColor = Color.Navy;
            txtfiyat.BorderStyle = BorderStyle.FixedSingle;
            txtfiyat.Font = new Font("Segoe UI", 11F);
            txtfiyat.ForeColor = Color.White;
            txtfiyat.Location = new Point(72, 225);
            txtfiyat.Name = "txtfiyat";
            txtfiyat.Size = new Size(327, 32);
            txtfiyat.TabIndex = 4;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblara.ForeColor = Color.White;
            lblara.Location = new Point(222, 334);
            lblara.Name = "lblara";
            lblara.Size = new Size(109, 25);
            lblara.TabIndex = 5;
            lblara.Text = "Tedavi Ara ";
            // 
            // txtara
            // 
            txtara.BackColor = Color.Navy;
            txtara.BorderStyle = BorderStyle.FixedSingle;
            txtara.Font = new Font("Segoe UI", 11F);
            txtara.ForeColor = Color.White;
            txtara.Location = new Point(130, 376);
            txtara.Name = "txtara";
            txtara.Size = new Size(293, 32);
            txtara.TabIndex = 6;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Navy;
            btngeri.BackgroundImage = (Image)resources.GetObject("btngeri.BackgroundImage");
            btngeri.BackgroundImageLayout = ImageLayout.Stretch;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(699, 12);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(38, 38);
            btngeri.TabIndex = 25;
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
            btnsil.Location = new Point(481, 305);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(153, 85);
            btnsil.TabIndex = 24;
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
            btndüzenle.Location = new Point(481, 172);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(153, 85);
            btndüzenle.TabIndex = 23;
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
            btnekle.Location = new Point(481, 40);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(153, 85);
            btnekle.TabIndex = 22;
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(531, 127);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 40;
            label2.Text = " Ekle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(515, 260);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 41;
            label5.Text = "Düzenle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(541, 393);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 42;
            label4.Text = "Sil";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 43;
            label1.Text = "Tedaviler";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(650, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 56;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Tedaviler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(753, 797);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(txtara);
            Controls.Add(lblara);
            Controls.Add(txtfiyat);
            Controls.Add(txtadi);
            Controls.Add(lblfiyat);
            Controls.Add(lbltedaviad);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tedaviler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tedaviler";
            Load += Tedaviler_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lbltedaviad;
        private Label lblfiyat;
        private TextBox txtadi;
        private TextBox txtfiyat;
        private Label lblara;
        private TextBox txtara;
        private Button btngeri;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
        private Label label2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}
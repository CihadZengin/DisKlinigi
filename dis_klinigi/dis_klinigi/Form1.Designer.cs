namespace dis_klinigi
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            lblkadi = new Label();
            lblsifre = new Label();
            txtkullanici = new TextBox();
            txtsifre = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblbos = new Label();
            lbldis = new Label();
            btnkapat = new Button();
            btnMinimize = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnekle = new Button();
            chcsifre = new CheckBox();
            btngiris = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            btnMinimize.SuspendLayout();
            SuspendLayout();
            // 
            // lblkadi
            // 
            lblkadi.AutoSize = true;
            lblkadi.Font = new Font("MV Boli", 13F, FontStyle.Bold);
            lblkadi.ForeColor = Color.White;
            lblkadi.Location = new Point(172, 56);
            lblkadi.Name = "lblkadi";
            lblkadi.Size = new Size(165, 29);
            lblkadi.TabIndex = 0;
            lblkadi.Text = "Kullanıcı Adı ";
            // 
            // lblsifre
            // 
            lblsifre.AutoSize = true;
            lblsifre.Font = new Font("MV Boli", 13F, FontStyle.Bold);
            lblsifre.ForeColor = Color.White;
            lblsifre.Location = new Point(214, 193);
            lblsifre.Name = "lblsifre";
            lblsifre.Size = new Size(80, 29);
            lblsifre.TabIndex = 1;
            lblsifre.Text = "Şifre ";
            lblsifre.Click += lblsifre_Click;
            // 
            // txtkullanici
            // 
            txtkullanici.BackColor = Color.Navy;
            txtkullanici.BorderStyle = BorderStyle.FixedSingle;
            txtkullanici.Font = new Font("Segoe UI", 13F);
            txtkullanici.ForeColor = Color.White;
            txtkullanici.Location = new Point(103, 91);
            txtkullanici.Name = "txtkullanici";
            txtkullanici.Size = new Size(303, 36);
            txtkullanici.TabIndex = 2;
            // 
            // txtsifre
            // 
            txtsifre.BackColor = Color.Navy;
            txtsifre.BorderStyle = BorderStyle.FixedSingle;
            txtsifre.Font = new Font("Segoe UI", 13F);
            txtsifre.ForeColor = Color.White;
            txtsifre.Location = new Point(103, 227);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(303, 36);
            txtsifre.TabIndex = 3;
            txtsifre.KeyDown += txtsifre_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblbos);
            panel1.Controls.Add(lbldis);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 454);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblbos
            // 
            lblbos.AutoSize = true;
            lblbos.Font = new Font("MV Boli", 15F, FontStyle.Bold);
            lblbos.ForeColor = Color.White;
            lblbos.Location = new Point(14, 332);
            lblbos.Name = "lblbos";
            lblbos.Size = new Size(257, 32);
            lblbos.TabIndex = 1;
            lblbos.Text = "MUCİZE Diş Klinigi";
            // 
            // lbldis
            // 
            lbldis.AutoSize = true;
            lbldis.BackColor = Color.FromArgb(0, 64, 64);
            lbldis.Font = new Font("MV Boli", 15F, FontStyle.Bold);
            lbldis.ForeColor = Color.White;
            lbldis.Location = new Point(54, 56);
            lbldis.Name = "lbldis";
            lbldis.Size = new Size(183, 32);
            lbldis.TabIndex = 0;
            lbldis.Text = "Hoş Geldiniz \r\n";
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.Navy;
            btnkapat.BackgroundImage = (Image)resources.GetObject("btnkapat.BackgroundImage");
            btnkapat.BackgroundImageLayout = ImageLayout.Stretch;
            btnkapat.FlatAppearance.BorderSize = 0;
            btnkapat.FlatStyle = FlatStyle.Flat;
            btnkapat.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            btnkapat.Location = new Point(476, 12);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(38, 38);
            btnkapat.TabIndex = 6;
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Navy;
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.Controls.Add(button1);
            btnMinimize.Controls.Add(label4);
            btnMinimize.Controls.Add(label3);
            btnMinimize.Controls.Add(label1);
            btnMinimize.Controls.Add(btnkapat);
            btnMinimize.Controls.Add(btnekle);
            btnMinimize.Controls.Add(chcsifre);
            btnMinimize.Controls.Add(btngiris);
            btnMinimize.Controls.Add(txtkullanici);
            btnMinimize.Controls.Add(lblkadi);
            btnMinimize.Controls.Add(txtsifre);
            btnMinimize.Controls.Add(lblsifre);
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.Location = new Point(287, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(529, 454);
            btnMinimize.TabIndex = 5;
            btnMinimize.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(423, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 422);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 12;
            label4.Text = "Düzenle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 397);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 11;
            label3.Text = "Kullanıcıları";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(409, 408);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 9;
            label1.Text = "Giriş Yap";
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.Navy;
            btnekle.BackgroundImage = (Image)resources.GetObject("btnekle.BackgroundImage");
            btnekle.BackgroundImageLayout = ImageLayout.Stretch;
            btnekle.FlatAppearance.BorderSize = 0;
            btnekle.FlatStyle = FlatStyle.Flat;
            btnekle.Font = new Font("MV Boli", 13F, FontStyle.Bold);
            btnekle.Location = new Point(7, 321);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(125, 73);
            btnekle.TabIndex = 8;
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // chcsifre
            // 
            chcsifre.AutoSize = true;
            chcsifre.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            chcsifre.ForeColor = Color.White;
            chcsifre.Location = new Point(249, 284);
            chcsifre.Name = "chcsifre";
            chcsifre.Size = new Size(157, 26);
            chcsifre.TabIndex = 7;
            chcsifre.Text = "Şifreyi Göster";
            chcsifre.UseVisualStyleBackColor = true;
            chcsifre.CheckedChanged += chcsifre_CheckedChanged;
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.Navy;
            btngiris.BackgroundImage = (Image)resources.GetObject("btngiris.BackgroundImage");
            btngiris.BackgroundImageLayout = ImageLayout.Stretch;
            btngiris.FlatAppearance.BorderSize = 0;
            btngiris.FlatStyle = FlatStyle.Flat;
            btngiris.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            btngiris.Location = new Point(383, 323);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(125, 73);
            btngiris.TabIndex = 4;
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(816, 454);
            Controls.Add(btnMinimize);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginKlinik";
            Load += frmlogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            btnMinimize.ResumeLayout(false);
            btnMinimize.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblkadi;
        private Label lblsifre;
        private TextBox txtsifre;
        private Panel panel1;
        private Label lbldis;
        private Panel btnMinimize;
        private Label lblbos;
        private Button btngiris;
        private Button btnkapat;
        private CheckBox chcsifre;
        private Button btnekle;
        private Label label1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        public TextBox txtkullanici;
        private Button button1;
    }
}

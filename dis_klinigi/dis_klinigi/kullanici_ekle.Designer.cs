namespace dis_klinigi
{
    partial class kullanici_ekle
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
            dataGridView1 = new DataGridView();
            lblkullanici = new Label();
            lblsifre = new Label();
            txtadi = new TextBox();
            txtsifre = new TextBox();
            btnkaydet = new Button();
            btnduzenle = new Button();
            btnsil = new Button();
            txtaraislem = new TextBox();
            lblasasasasas = new Label();
            panel1 = new Panel();
            btnkapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(450, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(508, 545);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // lblkullanici
            // 
            lblkullanici.AutoSize = true;
            lblkullanici.Font = new Font("Rockwell Extra Bold", 11F, FontStyle.Bold);
            lblkullanici.ForeColor = Color.White;
            lblkullanici.Location = new Point(137, 32);
            lblkullanici.Name = "lblkullanici";
            lblkullanici.Size = new Size(162, 22);
            lblkullanici.TabIndex = 1;
            lblkullanici.Text = "Kullanıcı Adı ";
            // 
            // lblsifre
            // 
            lblsifre.AutoSize = true;
            lblsifre.Font = new Font("Rockwell Extra Bold", 11F, FontStyle.Bold);
            lblsifre.ForeColor = Color.White;
            lblsifre.Location = new Point(187, 161);
            lblsifre.Name = "lblsifre";
            lblsifre.Size = new Size(62, 22);
            lblsifre.TabIndex = 2;
            lblsifre.Text = "Sifre";
            // 
            // txtadi
            // 
            txtadi.BackColor = Color.Navy;
            txtadi.BorderStyle = BorderStyle.FixedSingle;
            txtadi.Font = new Font("Segoe UI", 11F);
            txtadi.ForeColor = Color.White;
            txtadi.Location = new Point(39, 76);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(358, 32);
            txtadi.TabIndex = 3;
            // 
            // txtsifre
            // 
            txtsifre.BackColor = Color.Navy;
            txtsifre.BorderStyle = BorderStyle.FixedSingle;
            txtsifre.Font = new Font("Segoe UI", 11F);
            txtsifre.ForeColor = Color.White;
            txtsifre.Location = new Point(39, 200);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(358, 32);
            txtsifre.TabIndex = 4;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.Lime;
            btnkaydet.FlatAppearance.BorderSize = 0;
            btnkaydet.FlatStyle = FlatStyle.Flat;
            btnkaydet.Font = new Font("Rockwell Extra Bold", 11F, FontStyle.Bold);
            btnkaydet.Location = new Point(39, 299);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(106, 33);
            btnkaydet.TabIndex = 5;
            btnkaydet.Text = "kaydet";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btnduzenle
            // 
            btnduzenle.BackColor = Color.Yellow;
            btnduzenle.FlatAppearance.BorderSize = 0;
            btnduzenle.FlatStyle = FlatStyle.Flat;
            btnduzenle.Font = new Font("Rockwell Extra Bold", 11F, FontStyle.Bold);
            btnduzenle.Location = new Point(181, 299);
            btnduzenle.Name = "btnduzenle";
            btnduzenle.Size = new Size(112, 33);
            btnduzenle.TabIndex = 6;
            btnduzenle.Text = "Düzenle";
            btnduzenle.UseVisualStyleBackColor = false;
            btnduzenle.Click += btnduzenle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Red;
            btnsil.FlatAppearance.BorderSize = 0;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Rockwell Extra Bold", 11F, FontStyle.Bold);
            btnsil.Location = new Point(322, 299);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(106, 33);
            btnsil.TabIndex = 7;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // txtaraislem
            // 
            txtaraislem.BackColor = Color.Navy;
            txtaraislem.BorderStyle = BorderStyle.FixedSingle;
            txtaraislem.Font = new Font("Segoe UI", 11F);
            txtaraislem.ForeColor = Color.White;
            txtaraislem.Location = new Point(39, 415);
            txtaraislem.Name = "txtaraislem";
            txtaraislem.Size = new Size(358, 32);
            txtaraislem.TabIndex = 9;
            txtaraislem.TextChanged += txtaraislem_TextChanged;
            // 
            // lblasasasasas
            // 
            lblasasasasas.AutoSize = true;
            lblasasasasas.Font = new Font("Rockwell Extra Bold", 11F, FontStyle.Bold);
            lblasasasasas.ForeColor = Color.White;
            lblasasasasas.Location = new Point(39, 373);
            lblasasasasas.Name = "lblasasasasas";
            lblasasasasas.Size = new Size(358, 22);
            lblasasasasas.TabIndex = 10;
            lblasasasasas.Text = "kullanıcı adı ile arama yapınız";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnkapat);
            panel1.Controls.Add(txtadi);
            panel1.Controls.Add(lblasasasasas);
            panel1.Controls.Add(lblkullanici);
            panel1.Controls.Add(txtaraislem);
            panel1.Controls.Add(lblsifre);
            panel1.Controls.Add(txtsifre);
            panel1.Controls.Add(btnsil);
            panel1.Controls.Add(btnkaydet);
            panel1.Controls.Add(btnduzenle);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 545);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.FromArgb(255, 128, 0);
            btnkapat.FlatAppearance.BorderSize = 0;
            btnkapat.FlatStyle = FlatStyle.Flat;
            btnkapat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnkapat.Location = new Point(181, 493);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(79, 39);
            btnkapat.TabIndex = 11;
            btnkapat.Text = "Çıkış Yap";
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // kullanici_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(958, 545);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kullanici_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kullanici_ekle";
            Load += kullanici_ekle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblkullanici;
        private Label lblsifre;
        private TextBox txtadi;
        private TextBox txtsifre;
        private Button btnkaydet;
        private Button btnduzenle;
        private Button btnsil;
        private TextBox txtaraislem;
        private Label lblasasasasas;
        private Panel panel1;
        private Button btnkapat;
    }
}
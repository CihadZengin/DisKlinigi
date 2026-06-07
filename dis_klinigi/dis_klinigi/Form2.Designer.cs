namespace dis_klinigi
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnrandevu = new Button();
            btntedaviler = new Button();
            btnhasta = new Button();
            btnrecete = new Button();
            btndoktor = new Button();
            btngeri = new Button();
            btnkapat = new Button();
            txtara = new TextBox();
            lblmesaj = new Label();
            lblhastakyt = new Label();
            lblrandevu = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblrecete = new Label();
            btnilac = new Button();
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
            groupBox1.Location = new Point(0, 255);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1425, 360);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(4, 22);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1418, 336);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // btnrandevu
            // 
            btnrandevu.BackColor = Color.Navy;
            btnrandevu.BackgroundImage = (Image)resources.GetObject("btnrandevu.BackgroundImage");
            btnrandevu.BackgroundImageLayout = ImageLayout.Stretch;
            btnrandevu.FlatAppearance.BorderSize = 0;
            btnrandevu.FlatStyle = FlatStyle.Flat;
            btnrandevu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnrandevu.Location = new Point(20, 57);
            btnrandevu.Margin = new Padding(3, 2, 3, 2);
            btnrandevu.Name = "btnrandevu";
            btnrandevu.Size = new Size(178, 80);
            btnrandevu.TabIndex = 1;
            btnrandevu.UseVisualStyleBackColor = false;
            btnrandevu.Click += btnrandevu_Click;
            // 
            // btntedaviler
            // 
            btntedaviler.BackColor = Color.Navy;
            btntedaviler.BackgroundImage = (Image)resources.GetObject("btntedaviler.BackgroundImage");
            btntedaviler.BackgroundImageLayout = ImageLayout.Stretch;
            btntedaviler.FlatAppearance.BorderSize = 0;
            btntedaviler.FlatStyle = FlatStyle.Flat;
            btntedaviler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btntedaviler.Location = new Point(743, 57);
            btntedaviler.Margin = new Padding(3, 2, 3, 2);
            btntedaviler.Name = "btntedaviler";
            btntedaviler.Size = new Size(178, 83);
            btntedaviler.TabIndex = 2;
            btntedaviler.UseVisualStyleBackColor = false;
            btntedaviler.Click += btntedaviler_Click;
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
            btnhasta.Location = new Point(497, 57);
            btnhasta.Margin = new Padding(3, 2, 3, 2);
            btnhasta.Name = "btnhasta";
            btnhasta.Size = new Size(178, 86);
            btnhasta.TabIndex = 3;
            btnhasta.UseVisualStyleBackColor = false;
            btnhasta.Click += btnhasta_Click;
            // 
            // btnrecete
            // 
            btnrecete.BackColor = Color.Navy;
            btnrecete.BackgroundImage = (Image)resources.GetObject("btnrecete.BackgroundImage");
            btnrecete.BackgroundImageLayout = ImageLayout.Stretch;
            btnrecete.FlatAppearance.BorderSize = 0;
            btnrecete.FlatStyle = FlatStyle.Flat;
            btnrecete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnrecete.Location = new Point(1236, 54);
            btnrecete.Margin = new Padding(3, 2, 3, 2);
            btnrecete.Name = "btnrecete";
            btnrecete.Size = new Size(178, 83);
            btnrecete.TabIndex = 4;
            btnrecete.UseVisualStyleBackColor = false;
            btnrecete.Click += btnrecete_Click;
            // 
            // btndoktor
            // 
            btndoktor.BackColor = Color.Navy;
            btndoktor.BackgroundImage = (Image)resources.GetObject("btndoktor.BackgroundImage");
            btndoktor.BackgroundImageLayout = ImageLayout.Stretch;
            btndoktor.FlatAppearance.BorderSize = 0;
            btndoktor.FlatStyle = FlatStyle.Flat;
            btndoktor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btndoktor.Location = new Point(1001, 51);
            btndoktor.Margin = new Padding(3, 2, 3, 2);
            btndoktor.Name = "btndoktor";
            btndoktor.Size = new Size(178, 86);
            btndoktor.TabIndex = 5;
            btndoktor.UseVisualStyleBackColor = false;
            btndoktor.Click += btndoktor_Click;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Navy;
            btngeri.BackgroundImage = (Image)resources.GetObject("btngeri.BackgroundImage");
            btngeri.BackgroundImageLayout = ImageLayout.Stretch;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.ForeColor = Color.White;
            btngeri.Location = new Point(1283, 5);
            btngeri.Margin = new Padding(3, 2, 3, 2);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(33, 28);
            btngeri.TabIndex = 11;
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.Navy;
            btnkapat.BackgroundImage = (Image)resources.GetObject("btnkapat.BackgroundImage");
            btnkapat.BackgroundImageLayout = ImageLayout.Stretch;
            btnkapat.FlatAppearance.BorderSize = 0;
            btnkapat.FlatStyle = FlatStyle.Flat;
            btnkapat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnkapat.Location = new Point(1382, 5);
            btnkapat.Margin = new Padding(3, 2, 3, 2);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(33, 28);
            btnkapat.TabIndex = 10;
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // txtara
            // 
            txtara.BackColor = Color.Navy;
            txtara.BorderStyle = BorderStyle.FixedSingle;
            txtara.Font = new Font("Segoe UI", 11F);
            txtara.ForeColor = Color.White;
            txtara.Location = new Point(522, 228);
            txtara.Margin = new Padding(3, 2, 3, 2);
            txtara.Name = "txtara";
            txtara.Size = new Size(381, 27);
            txtara.TabIndex = 13;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // lblmesaj
            // 
            lblmesaj.AutoSize = true;
            lblmesaj.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblmesaj.ForeColor = Color.White;
            lblmesaj.Location = new Point(642, 193);
            lblmesaj.Name = "lblmesaj";
            lblmesaj.Size = new Size(126, 25);
            lblmesaj.TabIndex = 12;
            lblmesaj.Text = "Randevu Ara";
            // 
            // lblhastakyt
            // 
            lblhastakyt.AutoSize = true;
            lblhastakyt.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblhastakyt.ForeColor = Color.White;
            lblhastakyt.Location = new Point(522, 142);
            lblhastakyt.Name = "lblhastakyt";
            lblhastakyt.Size = new Size(111, 25);
            lblhastakyt.TabIndex = 14;
            lblhastakyt.Text = "Hasta Kayıt";
            // 
            // lblrandevu
            // 
            lblrandevu.AutoSize = true;
            lblrandevu.BackColor = Color.Navy;
            lblrandevu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblrandevu.ForeColor = Color.White;
            lblrandevu.Location = new Point(40, 140);
            lblrandevu.Name = "lblrandevu";
            lblrandevu.Size = new Size(125, 25);
            lblrandevu.TabIndex = 15;
            lblrandevu.Text = "Randevu Ver";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(760, 142);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 16;
            label1.Text = "Tedavi Listesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1040, 142);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 17;
            label2.Text = "Doktorlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1292, 142);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 18;
            label3.Text = "İlaçlar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(63, 14);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 20;
            label4.Text = "Ana Sayfa";
            // 
            // lblrecete
            // 
            lblrecete.AutoSize = true;
            lblrecete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblrecete.ForeColor = Color.White;
            lblrecete.Location = new Point(291, 142);
            lblrecete.Name = "lblrecete";
            lblrecete.Size = new Size(103, 25);
            lblrecete.TabIndex = 22;
            lblrecete.Text = "Reçete ver";
            // 
            // btnilac
            // 
            btnilac.BackColor = Color.Navy;
            btnilac.BackgroundImage = (Image)resources.GetObject("btnilac.BackgroundImage");
            btnilac.BackgroundImageLayout = ImageLayout.Stretch;
            btnilac.FlatAppearance.BorderSize = 0;
            btnilac.FlatStyle = FlatStyle.Flat;
            btnilac.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnilac.Location = new Point(260, 57);
            btnilac.Margin = new Padding(3, 2, 3, 2);
            btnilac.Name = "btnilac";
            btnilac.Size = new Size(178, 83);
            btnilac.TabIndex = 21;
            btnilac.UseVisualStyleBackColor = false;
            btnilac.Click += btnilac_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 10F, FontStyle.Bold);
            button1.Location = new Point(1333, 6);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(33, 28);
            button1.TabIndex = 23;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1425, 615);
            Controls.Add(button1);
            Controls.Add(lblrecete);
            Controls.Add(btnilac);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblrandevu);
            Controls.Add(lblhastakyt);
            Controls.Add(txtara);
            Controls.Add(lblmesaj);
            Controls.Add(btngeri);
            Controls.Add(btnkapat);
            Controls.Add(btndoktor);
            Controls.Add(btnrecete);
            Controls.Add(btnhasta);
            Controls.Add(btntedaviler);
            Controls.Add(btnrandevu);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevular";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnrandevu;
        private Button btntedaviler;
        private Button btnhasta;
        private Button btnrecete;
        private Button btndoktor;
        private Button btngeri;
        private Button btnkapat;
        private TextBox txtara;
        private Label lblmesaj;
        private Label lblhastakyt;
        private Label lblrandevu;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblrecete;
        private Button btnilac;
        private Button button1;
    }
}
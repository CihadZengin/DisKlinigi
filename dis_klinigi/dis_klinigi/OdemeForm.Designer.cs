namespace dis_klinigi
{
    partial class OdemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeForm));
            groupBox1 = new GroupBox();
            dtgBorcDetaylari = new DataGridView();
            txtToplamTutar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOdenenTutar = new TextBox();
            label3 = new Label();
            txtKalanBorc = new TextBox();
            btnOdemeYap = new Button();
            label4 = new Label();
            txtYeniOdemeMiktari = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBorcDetaylari).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgBorcDetaylari);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(0, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 346);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borç Bilgileri";
            // 
            // dtgBorcDetaylari
            // 
            dtgBorcDetaylari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBorcDetaylari.BackgroundColor = Color.DimGray;
            dtgBorcDetaylari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgBorcDetaylari.DefaultCellStyle = dataGridViewCellStyle1;
            dtgBorcDetaylari.Dock = DockStyle.Bottom;
            dtgBorcDetaylari.Location = new Point(3, 29);
            dtgBorcDetaylari.Name = "dtgBorcDetaylari";
            dtgBorcDetaylari.ReadOnly = true;
            dtgBorcDetaylari.RowHeadersWidth = 51;
            dtgBorcDetaylari.Size = new Size(634, 314);
            dtgBorcDetaylari.TabIndex = 0;
            dtgBorcDetaylari.RowHeaderMouseClick += dtgBorcDetaylari_RowHeaderMouseClick;
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.BackColor = Color.Navy;
            txtToplamTutar.BorderStyle = BorderStyle.FixedSingle;
            txtToplamTutar.Font = new Font("Segoe UI", 11F);
            txtToplamTutar.ForeColor = Color.White;
            txtToplamTutar.Location = new Point(49, 51);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.ReadOnly = true;
            txtToplamTutar.Size = new Size(282, 32);
            txtToplamTutar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 23);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 2;
            label1.Text = "Toplam Tutar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(123, 97);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 4;
            label2.Text = "Ödenen Tutar";
            // 
            // txtOdenenTutar
            // 
            txtOdenenTutar.BackColor = Color.Navy;
            txtOdenenTutar.BorderStyle = BorderStyle.FixedSingle;
            txtOdenenTutar.Font = new Font("Segoe UI", 11F);
            txtOdenenTutar.ForeColor = Color.White;
            txtOdenenTutar.Location = new Point(49, 134);
            txtOdenenTutar.Name = "txtOdenenTutar";
            txtOdenenTutar.ReadOnly = true;
            txtOdenenTutar.Size = new Size(282, 32);
            txtOdenenTutar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(137, 176);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 6;
            label3.Text = "Kalan Borç";
            // 
            // txtKalanBorc
            // 
            txtKalanBorc.BackColor = Color.Navy;
            txtKalanBorc.BorderStyle = BorderStyle.FixedSingle;
            txtKalanBorc.Font = new Font("Segoe UI", 11F);
            txtKalanBorc.ForeColor = Color.White;
            txtKalanBorc.Location = new Point(49, 213);
            txtKalanBorc.Name = "txtKalanBorc";
            txtKalanBorc.ReadOnly = true;
            txtKalanBorc.Size = new Size(282, 32);
            txtKalanBorc.TabIndex = 5;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.BackgroundImage = (Image)resources.GetObject("btnOdemeYap.BackgroundImage");
            btnOdemeYap.BackgroundImageLayout = ImageLayout.Stretch;
            btnOdemeYap.FlatAppearance.BorderSize = 0;
            btnOdemeYap.FlatStyle = FlatStyle.Flat;
            btnOdemeYap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOdemeYap.Location = new Point(391, 124);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(182, 109);
            btnOdemeYap.TabIndex = 7;
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(102, 258);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 10;
            label4.Text = "Yeni Ödenen Tutar";
            // 
            // txtYeniOdemeMiktari
            // 
            txtYeniOdemeMiktari.BackColor = Color.Navy;
            txtYeniOdemeMiktari.BorderStyle = BorderStyle.FixedSingle;
            txtYeniOdemeMiktari.Font = new Font("Segoe UI", 11F);
            txtYeniOdemeMiktari.ForeColor = Color.White;
            txtYeniOdemeMiktari.Location = new Point(49, 288);
            txtYeniOdemeMiktari.Name = "txtYeniOdemeMiktari";
            txtYeniOdemeMiktari.Size = new Size(282, 32);
            txtYeniOdemeMiktari.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(426, 236);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 19;
            label5.Text = "Ödeme Yap";
            // 
            // OdemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(640, 694);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtYeniOdemeMiktari);
            Controls.Add(btnOdemeYap);
            Controls.Add(label3);
            Controls.Add(txtKalanBorc);
            Controls.Add(label2);
            Controls.Add(txtOdenenTutar);
            Controls.Add(label1);
            Controls.Add(txtToplamTutar);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "OdemeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdemeForm";
            Load += OdemeForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgBorcDetaylari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtgBorcDetaylari;
        private TextBox txtToplamTutar;
        private Label label1;
        private Label label2;
        private TextBox txtOdenenTutar;
        private Label label3;
        private TextBox txtKalanBorc;
        private Button btnOdemeYap;
        private Label label4;
        private TextBox txtYeniOdemeMiktari;
        private Label label5;
    }
}
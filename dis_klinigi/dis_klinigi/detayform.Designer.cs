namespace dis_klinigi
{
    partial class detayform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detayform));
            dgvDetaylar = new DataGridView();
            btnYazdir = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.BackgroundColor = Color.DimGray;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Dock = DockStyle.Bottom;
            dgvDetaylar.Location = new Point(0, 209);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersWidth = 51;
            dgvDetaylar.Size = new Size(822, 365);
            dgvDetaylar.TabIndex = 0;
            // 
            // btnYazdir
            // 
            btnYazdir.BackgroundImage = (Image)resources.GetObject("btnYazdir.BackgroundImage");
            btnYazdir.BackgroundImageLayout = ImageLayout.Stretch;
            btnYazdir.FlatAppearance.BorderSize = 0;
            btnYazdir.FlatStyle = FlatStyle.Flat;
            btnYazdir.Location = new Point(318, 92);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(159, 82);
            btnYazdir.TabIndex = 1;
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(364, 177);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 2;
            label1.Text = "Yazdır";
            // 
            // detayform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(822, 574);
            Controls.Add(label1);
            Controls.Add(btnYazdir);
            Controls.Add(dgvDetaylar);
            MaximizeBox = false;
            Name = "detayform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "detayform";
            Load += detayform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetaylar;
        private Button btnYazdir;
        private Label label1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dis_klinigi
{
    public partial class Form2 : Form
    {
        SqlConnection con; // = new SqlConnection("Data Source= CIHAD;Initial Catalog=proje;Integrated security=true;");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("select HastaTCNumarasi,HastaAdi,HastaSoyadi,HastaTelefonNumarasi,HastaCinsiyeti,TedaviAdi,TedaviFiyati,Saatler,Tarih from Randevu_tbl\r\ninner join Hastalar_tbl on HastaID=RandevuHID\r\ninner join Tedavi_tbl on TedavilerID=RandevuTeID\r\ninner Join Saat_tbl on SaatID = RandevuSID\r\ninner join Tarih_tbl on TarihID=RandevuTaID\r\n order by Tarih,Saatler", con))
                    {
                        using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                        {
                            con.Open();
                            adapt.Fill(dt);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Verileri tazeleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridView1.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);

            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            defaultCellStyle.SelectionForeColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            defaultCellStyle.Padding = new Padding(5, 2, 5, 2);
            dataGridView1.DefaultCellStyle = defaultCellStyle;

            DataGridViewCellStyle alternatingCellStyle = new DataGridViewCellStyle();
            alternatingCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            alternatingCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            alternatingCellStyle.SelectionBackColor = Color.FromArgb(62, 162, 229);
            alternatingCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = alternatingCellStyle;

            dataGridView1.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.FromArgb(70, 70, 70);     
            columnHeaderStyle.ForeColor = Color.White;                  
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold); 
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.TopLeft; 
            columnHeaderStyle.Padding = new Padding(5, 5, 5, 5); 
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.ColumnHeadersHeight = 30;

            dataGridView1.BorderStyle = BorderStyle.None; 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Kapanıyor", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Giriş Ekranına Dönüş Yapmak İstiyor Musunuz?", "Önceki Ekrana Dön", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                frmlogin frm1 = new frmlogin();
                frm1.Show();
                this.Close();
            }
        }
        private void ara()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    string ara = txtara.Text.Trim();
                    DataTable dtara = new DataTable();

                    string query = "select HastaTCNumarasi, HastaAdi, HastaSoyadi, HastaTelefonNumarasi, HastaCinsiyeti, TedaviAdi, TedaviFiyati, Saatler, Tarih from Randevu_tbl\r\ninner join Hastalar_tbl on HastaID = RandevuHID\r\ninner join Tedavi_tbl on TedavilerID = RandevuTeID\r\ninner Join Saat_tbl on SaatID = RandevuSID\r\ninner join Tarih_tbl on TarihID = RandevuTaID\r\n  where HastaTCNumarasi like '%" + ara + "%' or HastaAdi like '%" + ara + "%' or HastaSoyadi like '%" + ara + "%'\r\n or HastaTelefonNumarasi like '%" + ara + "%'\r\n order by Tarih, Saatler";

                    using (SqlDataAdapter adptara = new SqlDataAdapter(query, con))
                    {
                        // Güvenli yöntem: Parametre kullanmak.
                        adptara.SelectCommand.Parameters.AddWithValue("@aramaParametresi", "%" + ara + "%");

                        adptara.Fill(dtara);
                        dataGridView1.DataSource = dtara;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Arama işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtara_TextChanged(object sender, EventArgs e)
        {
            ara();
        }
        private void btntedaviler_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tedavi Ekleme Ekranına Geçiliyor", "Tedavi Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Tedaviler ted = new Tedaviler();
                this.Close();
                ted.Show();
            }
        }
        private void btnhasta_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Hasta Ekleme Ekranına Geçiliyor", "Hasta Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Hastalar has = new Hastalar();
                this.Close();
                has.Show();
            }
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Doktor Ekleme Ekranına Geçiliyor", "Doktor Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Doktorlar dr = new Doktorlar();
                this.Close();
                dr.Show();

            }
        }

        private void btnrecete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("İlaç Ekleme Ekranına Geçiliyor", "İlaç Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                İlaclar ilac = new İlaclar();
                this.Close();
                ilac.Show();

            }
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Randevu Ekranına Geçiliyor", "Reçete Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Randevu_Ekranı rand = new Randevu_Ekranı();
                this.Close();
                rand.Show();
            }
        }

        private void btnilac_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("İlaç Ekleme Ekranına Geçiliyor", "İlaç Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                recete_ver rctv = new recete_ver();
                this.Close();
                rctv.Show();

            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string hastaTC = dataGridView1.Rows[e.RowIndex].Cells["HastaTCNumarasi"].Value.ToString(); 
                RandevuDetayForm randevuForm = new RandevuDetayForm(hastaTC);
                this.Close();
                randevuForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dis_klinigi
{
    public partial class Doktorlar : Form
    {
        private int ID = 0;
        public Doktorlar()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ana Sayfaya Dönülüyor", "Ana Sayfa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form2 anasayfa = new Form2();
                this.Close();
                anasayfa.Show();

            }
        }
        private void temizle()
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            mtxttelno.Clear();
            txtmail.Clear();
        }
        public void VerileriTazele()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapt = new SqlDataAdapter("select * from Doktor_tbl", con))
                    {
                        adapt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Verileri tazeleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            VerileriTazele();
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
            columnHeaderStyle.BackColor = Color.FromArgb(70, 70, 70);     // Sütun başlıkları arka planı (koyu gri)
            columnHeaderStyle.ForeColor = Color.White;                  // Sütun başlıkları yazı rengi
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold); // Başlık yazı tipi
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.TopLeft; // Başlıkları ortala
            columnHeaderStyle.Padding = new Padding(5, 5, 5, 5); // Başlık içi dolgu
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.ColumnHeadersHeight = 30;

            dataGridView1.BorderStyle = BorderStyle.None; // Kenar çerçevesi stili
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtadi.Text) && !string.IsNullOrWhiteSpace(txtsoyadi.Text) && !string.IsNullOrWhiteSpace(txtmail.Text) && !string.IsNullOrWhiteSpace(mtxttelno.Text))
            {
                string cinsiyet = radioe.Checked ? "Erkek" : radiok.Checked ? "Kadın" : "";
                if (cinsiyet == "")
                {
                    MessageBox.Show("Lütfen cinsiyet seçiniz.");
                    return;
                }

                using (SqlConnection con = DbConnection.GetConnection())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Doktor_tbl (DoktorAdi, DoktorSoyadi, DoktorTelefonNumarasi, DoktorCinsiyet, DoktorGmail) VALUES(@adi, @soyadi, @telno, @cinsiyet, @mail)", con))
                        {
                            cmd.Parameters.AddWithValue("@adi", txtadi.Text.Trim());
                            cmd.Parameters.AddWithValue("@soyadi", txtsoyadi.Text.Trim());
                            cmd.Parameters.AddWithValue("@telno", mtxttelno.Text.Trim());
                            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                            cmd.Parameters.AddWithValue("@mail", txtmail.Text.Trim());

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        VerileriTazele();
                        temizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz bir şekilde doldurunuz.");
            }
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir kayıt seçiniz.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtadi.Text) && !string.IsNullOrWhiteSpace(txtsoyadi.Text) && !string.IsNullOrWhiteSpace(txtmail.Text) && !string.IsNullOrWhiteSpace(mtxttelno.Text))
            {
                string cinsiyet = radioe.Checked ? "Erkek" : radiok.Checked ? "Kadın" : "";
                if (cinsiyet == "")
                {
                    MessageBox.Show("Lütfen cinsiyet seçiniz.");
                    return;
                }

                using (SqlConnection con = DbConnection.GetConnection())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE Doktor_tbl SET DoktorAdi=@adi, DoktorSoyadi=@soyadi, doktorTelefonNumarasi=@telno, DoktorCinsiyet=@cinsiyet, DoktorGmail=@mail WHERE DoktorID=@id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@adi", txtadi.Text.Trim());
                            cmd.Parameters.AddWithValue("@soyadi", txtsoyadi.Text.Trim());
                            cmd.Parameters.AddWithValue("@telno", mtxttelno.Text.Trim());
                            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                            cmd.Parameters.AddWithValue("@mail", txtmail.Text.Trim());

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        VerileriTazele();
                        temizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz bir şekilde doldurunuz.");
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Lütfen silmek için bir kayıt seçiniz.");
                return;
            }

            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Doktor_tbl WHERE DoktorID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    VerileriTazele();
                    temizle();
                    ID = 0; // ID'yi sıfırla
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kayıt silme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("Seçili satırda geçerli bir ID bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                txtsoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                mtxttelno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? string.Empty;
                txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? string.Empty;
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"ID formatında bir hata oluştu: {ex.Message}", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void veriara()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    string ara = txtara.Text.Trim();
                    DataTable dtara = new DataTable();
                    string query = "SELECT * FROM Doktor_tbl WHERE DoktorAdi LIKE @ara OR DoktorSoyadi LIKE @ara OR DoktorTelefonNumarasi LIKE @ara";

                    using (SqlDataAdapter adptara = new SqlDataAdapter(query, con))
                    {
                        adptara.SelectCommand.Parameters.AddWithValue("@ara", "%" + ara + "%");
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
            veriara();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

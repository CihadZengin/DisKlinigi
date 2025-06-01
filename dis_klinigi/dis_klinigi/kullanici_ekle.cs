using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace dis_klinigi
{
    public partial class kullanici_ekle : Form
    {
        private int ID = 0;
        public kullanici_ekle()
        {
            InitializeComponent();
        }
        public void VerileriTazele()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM login_tbl", con))
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
        private string HashSifre(string sifre)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void temizle()
        {
            txtadi.Clear();
            txtsifre.Clear();
        }
        private void veriara()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    DataTable dtara = new DataTable();
                    string query = "SELECT * FROM login_tbl WHERE KullaniciAdi LIKE @ara";

                    using (SqlDataAdapter adptara = new SqlDataAdapter(query, con))
                    {
                        adptara.SelectCommand.Parameters.AddWithValue("@ara", "%" + txtaraislem.Text.Trim() + "%");
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

        private void kullanici_ekle_Load(object sender, EventArgs e)
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
            var result = MessageBox.Show("Düzenleme Menüsünden Çıkılıyor Kabul Ediyor Musunuz?", "Kapanıyor", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                frmlogin form1 = new frmlogin();
                form1.Show();
                this.Close();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtadi.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Bir Şekilde Doldurunuz");
                return;
            }

            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    string kullaniciAdi = txtadi.Text;
                    string hashlenmisSifre = HashSifre(txtsifre.Text);

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO login_tbl(Kullaniciadi, Sifre) VALUES(@Kullaniciadi, @Sifre)", con))
                    {
                        cmd.Parameters.AddWithValue("@Kullaniciadi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Sifre", hashlenmisSifre);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    VerileriTazele();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Kayıt Edildi");
                    temizle();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show($"Veritabanında bir hata oluştu: {ex1.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir kayıt seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtadi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
                return;
            }

            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    string sqlQuery;
                    // SqlCommand'i using bloğunun dışında tanımla, içinde oluştur.
                    SqlCommand cmd;

                    if (!string.IsNullOrWhiteSpace(txtsifre.Text))
                    {
                        // Şifre güncelleniyorsa
                        string hashlenmisSifre = HashSifre(txtsifre.Text);
                        sqlQuery = "UPDATE login_tbl SET Kullaniciadi=@Kullaniciadi, Sifre=@Sifre WHERE ID=@ID";
                        cmd = new SqlCommand(sqlQuery, con);
                        cmd.Parameters.AddWithValue("@Sifre", hashlenmisSifre);
                    }
                    else
                    {
                        // Sadece kullanıcı adı güncelleniyorsa
                        sqlQuery = "UPDATE login_tbl SET Kullaniciadi=@Kullaniciadi WHERE ID=@ID";
                        cmd = new SqlCommand(sqlQuery, con);
                    }

                    using (cmd) // cmd nesnesini using ile yönet
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@Kullaniciadi", txtadi.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    VerileriTazele();
                    MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                    ID = 0;
                }
                catch (Exception ex1)
                {
                    MessageBox.Show($"Genel bir hata oluştu: {ex1.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM login_tbl WHERE ID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    VerileriTazele();
                    temizle();
                    ID = 0;
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
                if (e.RowIndex < 0) return; 
                string idColumnName = "ID"; 
                string kullaniciAdiColumnName = "KullaniciAdi"; 
                                                                

                if (dataGridView1.Columns.Contains(idColumnName) && dataGridView1.Rows[e.RowIndex].Cells[idColumnName].Value != null && dataGridView1.Rows[e.RowIndex].Cells[idColumnName].Value != DBNull.Value)
                {
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[idColumnName].Value);
                }
                else
                {
                    MessageBox.Show("Seçili satırda geçerli bir ID bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID = 0;
                    temizle();
                    return;
                }

                if (dataGridView1.Columns.Contains(kullaniciAdiColumnName))
                {
                    txtadi.Text = dataGridView1.Rows[e.RowIndex].Cells[kullaniciAdiColumnName].Value?.ToString() ?? string.Empty;
                }
                txtsifre.Clear();

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"ID formatında bir hata oluştu: {ex.Message}", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                temizle();
            }
        }


        private void txtaraislem_TextChanged(object sender, EventArgs e)
        {
            veriara();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dis_klinigi
{
    public partial class Tedaviler : Form
    {
        //SqlConnection con = new SqlConnection("Data Source= CIHAD;Initial Catalog=proje;Integrated security=true;");
        private int ID = 0;

        public Tedaviler()
        {
            InitializeComponent();
        }

        private void Tedaviler_Load(object sender, EventArgs e)
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
        public void VerileriTazele()
        {
            using (SqlConnection con = DbConnection.GetConnection()) // DbConnection KULLANILDI
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tedavi_tbl", con))
                    {
                        using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            // con.Open(); // SqlDataAdapter.Fill metodu bağlantıyı kendi açıp kapatır.
                            adapt.Fill(dt);
                            // con.Close(); // SqlDataAdapter.Fill metodu bağlantıyı kendi açıp kapatır.
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veri yükleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            txtfiyat.Clear();
        }
        private void veriara()
        {
            using (SqlConnection con = DbConnection.GetConnection()) // DbConnection KULLANILDI
            {
                try
                {
                    DataTable dtara = new DataTable();
                    string ara = txtara.Text.Trim();

                    // SQL Injection'a karşı GÜVENLİ HALE GETİRİLDİ. Orijinal sorgu mantığın korundu.
                    string query = "SELECT * FROM Tedavi_tbl WHERE TedaviAdi LIKE @araParam";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@araParam", "%" + ara + "%"); // Parametre burada eklendi

                        using (SqlDataAdapter adptara = new SqlDataAdapter(cmd))
                        {
                            // con.Open(); // SqlDataAdapter.Fill metodu bağlantıyı kendi açıp kapatır.
                            adptara.Fill(dtara);
                            // con.Close(); // SqlDataAdapter.Fill metodu bağlantıyı kendi açıp kapatır.
                        }
                    }
                    dataGridView1.DataSource = dtara;
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

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtadi.Text) || string.IsNullOrWhiteSpace(txtfiyat.Text))
            {
                MessageBox.Show("Lütfen verileri eksiksiz giriniz.", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tedaviFiyatiValue;
            // Fiyatı decimal'a çevirme (Türkçe kültürüne göre nokta/virgül ayrımına dikkat et)
            if (!Decimal.TryParse(txtfiyat.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out tedaviFiyatiValue))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Geçersiz Fiyat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = DbConnection.GetConnection()) // DbConnection KULLANILDI
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Tedavi_tbl(TedaviAdi, TedaviFiyati) VALUES(@tedaviad, @tedavifiyat)", con))
                    {
                        cmd.Parameters.AddWithValue("@tedaviad", txtadi.Text.Trim()); // Orijinal Add metodu
                        cmd.Parameters.AddWithValue("@tedavifiyat", tedaviFiyatiValue); // DÖNÜŞTÜRÜLMÜŞ decimal değer

                        con.Open(); // ExecuteNonQuery için bağlantı açılmalı
                        cmd.ExecuteNonQuery();
                        // con.Close(); // Using bloğu sonunda otomatik kapanır.
                    }
                    VerileriTazele();
                    temizle();
                    MessageBox.Show("Tedavi başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mesaj eklendi
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanı işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir kayıt seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtadi.Text) || string.IsNullOrWhiteSpace(txtfiyat.Text))
            {
                MessageBox.Show("Lütfen verileri eksiksiz giriniz.", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tedaviFiyatiValue;
            if (!Decimal.TryParse(txtfiyat.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out tedaviFiyatiValue))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Geçersiz Fiyat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = DbConnection.GetConnection()) // DbConnection KULLANILDI
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Tedavi_tbl SET TedaviAdi=@tedaviad, TedaviFiyati=@tedavifiyat WHERE TedavilerID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID); // Orijinal Add metodu
                        cmd.Parameters.AddWithValue("@tedaviad", txtadi.Text.Trim());
                        cmd.Parameters.AddWithValue("@tedavifiyat", tedaviFiyatiValue); // DÖNÜŞTÜRÜLMÜŞ decimal değer

                        con.Open(); // ExecuteNonQuery için bağlantı açılmalı
                        cmd.ExecuteNonQuery();
                        // con.Close(); // Using bloğu sonunda otomatik kapanır.
                    }
                    VerileriTazele();
                    MessageBox.Show("Tedavi başarılı bir şekilde düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanı işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var confirmResult = MessageBox.Show("Bu tedaviyi silmek istediğinizden emin misiniz?",
                                                "Silme Onayı",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning); // Onay mesajı eklendi
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            using (SqlConnection con = DbConnection.GetConnection()) // DbConnection KULLANILDI
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Tedavi_tbl WHERE TedavilerID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        con.Open(); // ExecuteNonQuery için bağlantı açılmalı
                        cmd.ExecuteNonQuery();
                        // con.Close(); // Using bloğu sonunda otomatik kapanır.
                    }
                    VerileriTazele();
                    temizle();
                    MessageBox.Show("Tedavi başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mesaj eklendi
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
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Seçili satırda geçerli bir ID bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                txtfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"ID formatı hatalı: {ex.Message}", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

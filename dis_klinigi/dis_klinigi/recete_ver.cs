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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dis_klinigi
{
    public partial class recete_ver : Form
    {
        int receteID = 0;
        public recete_ver()
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
        private void verileritazele()
        {
            using (SqlConnection con = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    DataTable dt = new DataTable();
                    string query = "select AlınanİlacID, HastaTCNumarasi,HastaAdi,HastaSoyadi,İlacAdi,KullanımKosullari,İlacDetaylari from Alınanİlac_tbl \r\ninner join Hastalar_tbl on HastaID=HID\r\ninner join Recete_tbl on İlacID=Alınanİlaclar"; // AlınanİlacID'yi de seçtim, silme/güncelleme için gerekebilir.

                    using (SqlDataAdapter adapt = new SqlDataAdapter(query, con))
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

        private void recete_ver_Load(object sender, EventArgs e)
        {
            verileritazele();
            FillComboBoxhasta();
            FillComboBoxİlac();
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
        private void FillComboBoxhasta()
        {
            // DİKKAT: Artık string connectionString satırı yok.
            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    string query = "SELECT HastaTCNumarasi FROM Hastalar_tbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            txtmtc.Items.Clear();
                            while (reader.Read())
                            {
                                txtmtc.Items.Add(reader["HastaTCNumarasi"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Hasta TC'leri yüklenirken hata: " + ex.Message); }
            }
        }
        private void FillComboBoxİlac()
        {
            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    string query = "SELECT İlacAdi FROM Recete_tbl"; // Senin orijinal sorgun

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) // SqlDataReader için de using ekledim
                        {
                            txtiadi.Items.Clear(); // ComboBox'ı her seferinde temizliyoruz
                            while (reader.Read())
                            {
                                txtiadi.Items.Add(reader["İlacAdi"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İlaç adları yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // 'connection' using bloğu sonunda otomatik olarak kapanacaktır.
            }
        }
        private void GetCustomerInfohasta(string tcNo)
        {
            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    string query = "SELECT HastaAdi, HastaSoyadi FROM Hastalar_tbl WHERE HastaTCNumarasi = @TCNo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TCNo", tcNo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtmadi.Text = reader["HastaAdi"].ToString();
                                txtmsoyadi.Text = reader["HastaSoyadi"].ToString();
                            }
                            else
                            {
                                txtmadi.Clear();
                                txtmsoyadi.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Hasta bilgileri alınırken hata: " + ex.Message); }
            }
        }
        private void GetcastomerilacDetails(string doctorName)
        {
            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    // Sorgudaki parametre adı senin orijinalindeki gibi '@ilacadi' olarak bırakıldı
                    string query = "SELECT KullanımKosullari, İlacDetaylari FROM Recete_tbl WHERE İlacAdi = @ilacadi";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreye değer atarken de orijinal 'doctorName' kullanıldı
                        command.Parameters.AddWithValue("@ilacadi", doctorName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtikosul.Text = reader["KullanımKosullari"].ToString();
                                txtdetay.Text = reader["İlacDetaylari"].ToString();
                            }
                            else
                            {
                                // Belki burada mesaj göstermek yerine sadece alanları temizlemek daha iyi olabilir
                                txtikosul.Clear();
                                txtdetay.Clear();
                                // MessageBox.Show("İlaç bilgileri bulunamadı!"); // Eski kodunda "Doktor bilgileri" yazıyordu, "İlaç" olarak düzelttim.
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İlaç detayları alınırken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtmtc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtmtc.SelectedItem == null)
                return;

            string selectedTC = txtmtc.SelectedItem.ToString();
            GetCustomerInfohasta(selectedTC);
        }

        private void txtiadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtiadi.SelectedItem == null)
                return;
            string selectediad = txtiadi.SelectedItem.ToString();
            GetcastomerilacDetails(selectediad);
        }
        private int GetHastaID(string tcNo)
        {
            int id = -1;
            if (string.IsNullOrEmpty(tcNo)) return id;

            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    string query = "SELECT HastaID FROM Hastalar_tbl WHERE HastaTCNumarasi = @tc";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@tc", tcNo);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            id = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Hasta ID alınırken hata oluştu: {ex.Message}"); }
            }
            return id;


        }
        private int GetİlacID(string ilacıd)
        {
            int id = -1;
            if (string.IsNullOrEmpty(ilacıd)) return id;
            // string query = "SELECT İlacID FROM Recete_tbl WHERE İlacAdi = @iad"; // Orijinal kodda bu satır yoktu.
            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection KULLANILDI
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT İlacID FROM Recete_tbl WHERE İlacAdi = @iad", connection)) // Sorgu direkt buraya
                    {
                        cmd.Parameters.AddWithValue("@iad", ilacıd);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value) // DBNull.Value kontrolü eklendi
                        {
                            // int.TryParse(result.ToString(), out id) // Orijinal kodunuzda direkt Convert vardı, koruyorum.
                            id = Convert.ToInt32(result);
                            // return id; // Orijinal kodda return burada değildi.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"İlaç ID alınırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return id; // Orijinal kodda return buradaydı.
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtmtc.SelectedItem == null || txtiadi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hasta ve ilaç seçiniz!");
                return;
            }

            int hastaID = GetHastaID(txtmtc.Text);
            int ilacID = GetİlacID(txtiadi.Text);

            if (hastaID == -1 || ilacID == -1)
            {
                MessageBox.Show("Eksik veya hatalı bilgi var! (ID'ler alınamadı)");
                return;
            }

            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Alınanİlac_tbl (Alınanİlaclar, HID) VALUES (@iid, @hid)", connection))
                    {
                        cmd.Parameters.AddWithValue("@iid", ilacID);
                        cmd.Parameters.AddWithValue("@hid", hastaID); // Parametre adını düzelttim (@iad yerine @hid)
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Reçete Başarıyla Oluşturuldu");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Reçete eklenirken hata: " + ex.Message); }
            }
            verileritazele();
            Temizle();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtmtc.Text = selectedRow.Cells["HastaTCNumarasi"].Value.ToString();
                txtmadi.Text = selectedRow.Cells["HastaAdi"].Value.ToString();
                txtmsoyadi.Text = selectedRow.Cells["HastaSoyadi"].Value.ToString();
                txtiadi.Text = selectedRow.Cells["İlacAdi"].Value.ToString();
                txtikosul.Text = selectedRow.Cells["KullanımKosullari"].Value.ToString();
                txtdetay.Text = selectedRow.Cells["İlacDetaylari"].Value.ToString();
            }

        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows[0].Cells["AlınanİlacID"].Value == null) // AlınanİlacID'yi seçtiğinden emin ol
    {
                MessageBox.Show("Lütfen güncellemek için bir kayıt seçin.");
                return;
            }
            // receteID'yi DataGridView'den almalısın, class seviyesindeki receteID'ye gerek yok.
            int secilenAlinanIlacID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AlınanİlacID"].Value);


            if (txtmtc.SelectedItem == null || txtiadi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hasta ve ilaç seçiniz!");
                return;
            }

            int hastaID = GetHastaID(txtmtc.Text);
            int ilacID = GetİlacID(txtiadi.Text);

            if (hastaID == -1 || ilacID == -1)
            {
                MessageBox.Show("Eksik ya da hatalı bilgi girdiniz! (ID'ler alınamadı)");
                return;
            }

            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE Alınanİlac_tbl SET HID=@hid, Alınanİlaclar=@ilacid WHERE AlınanİlacID=@alinanIlacID", connection))
                    {
                        updateCmd.Parameters.AddWithValue("@hid", hastaID);
                        updateCmd.Parameters.AddWithValue("@ilacid", ilacID); // Parametre adını düzelttim (@teid yerine @ilacid)
                        updateCmd.Parameters.AddWithValue("@alinanIlacID", secilenAlinanIlacID); // Parametre adını düzelttim (@aid yerine @alinanIlacID)
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Reçete başarıyla güncellendi!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Reçete güncellenirken hata: " + ex.Message); }
            }
            verileritazele();
            Temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows[0].Cells["AlınanİlacID"].Value == null)
            {
                MessageBox.Show("Lütfen silmek için bir kayıt seçin."); // Mesajı "güncellemek" yerine "silmek" olarak düzelttim.
                return;
            }
            var confirm = MessageBox.Show("Seçilen reçeteyi silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            // receteID'yi DataGridView'den almalısın.
            int secilenAlinanIlacID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AlınanİlacID"].Value);

            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    connection.Open();
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Alınanİlac_tbl WHERE AlınanİlacID=@alinanIlacID", connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@alinanIlacID", secilenAlinanIlacID); // Parametre adını düzelttim
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Reçete başarıyla silindi!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Reçete silinirken hata: " + ex.Message); }
            }
            verileritazele();
            Temizle();
        }
        private void Temizle()
        {
            txtmtc.SelectedIndexChanged -= txtmtc_SelectedIndexChanged;
            txtiadi.SelectedIndexChanged -= txtiadi_SelectedIndexChanged;

            txtmtc.SelectedIndex = -1;
            txtmadi.Clear();
            txtmsoyadi.Clear();

            txtiadi.SelectedIndex = -1;
            txtikosul.Clear();
            txtdetay.Clear();

            txtmtc.SelectedIndexChanged += txtmtc_SelectedIndexChanged;
            txtiadi.SelectedIndexChanged += txtiadi_SelectedIndexChanged;
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection()) // DbConnection kullanıyoruz
            {
                try
                {
                    string ara = txtara.Text.Trim();
                    DataTable dtara = new DataTable();
                    // Sorguyu ve parametreyi güvenli hale getir
                    string query = "SELECT AlınanİlacID, HastaTCNumarasi,HastaAdi,HastaSoyadi,İlacAdi,KullanımKosullari,İlacDetaylari FROM Alınanİlac_tbl " +
                                   "INNER JOIN Hastalar_tbl ON HastaID=HID " +
                                   "INNER JOIN Recete_tbl ON İlacID=Alınanİlaclar " +
                                   "WHERE HastaTCNumarasi LIKE @aramaParam OR HastaAdi LIKE @aramaParam OR İlacAdi LIKE @aramaParam"; // Arama kriterlerini genişletebilirsin

                    using (SqlDataAdapter adptara = new SqlDataAdapter(query, con))
                    {
                        adptara.SelectCommand.Parameters.AddWithValue("@aramaParam", "%" + ara + "%");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

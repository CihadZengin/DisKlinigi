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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dis_klinigi
{
    public partial class Randevu_Ekranı : Form
    {
        int randevuID = 0;
        public Randevu_Ekranı()
        {
            InitializeComponent();
        }

        private void Randevu_Ekranı_Load(object sender, EventArgs e)
        {
            verileritazele();
            FillComboBoxhasta();
            FillDoctorComboBox();
            FillTreatmentComboBox();
            FillHourComboBox();

            date.Format = DateTimePickerFormat.Custom; 
            date.CustomFormat = "dd-MM-yyyy"; 
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

        private void verileritazele()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    DataTable dt = new DataTable();
                    string query = "select RandevuID, HastaTCNumarasi, HastaAdi, HastaSoyadi,HastaTelefonNumarasi, DoktorAdi, DoktorSoyadi,DoktorTelefonNumarasi, TedaviAdi, TedaviFiyati, Saatler, Tarih from Randevu_tbl " +
                                   "inner join Hastalar_tbl on HastaID=RandevuHID " +
                                   "inner join Doktor_tbl on DoktorID=RandevuDID " +
                                   "inner join Tedavi_tbl on TedavilerID=RandevuTeID " +
                                   "inner Join Saat_tbl on SaatID = RandevuSID " +
                                   "inner join Tarih_tbl on TarihID=RandevuTaID " +
                                   "order by Tarih,Saatler";

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
        private void FillComboBoxhasta()
        {
            // DİKKAT: Artık her metodun başında kendi bağlantı cümlesini oluşturmuyoruz.
            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz.
            {
                try
                {
                    connection.Open();
                    string query = "SELECT HastaTCNumarasi FROM Hastalar_tbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            txtmtc.Items.Clear(); // ComboBox'ı temizle
                            while (reader.Read())
                            {
                                txtmtc.Items.Add(reader["HastaTCNumarasi"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hasta bilgileri yüklenirken hata: " + ex.Message);
                }
            }
        }
        private void FillDoctorComboBox()
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DoktorAdi FROM Doktor_tbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            txtdrad.Items.Clear();
                            while (reader.Read())
                            {
                                txtdrad.Items.Add(reader["DoktorAdi"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Doktor adları yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        private void FillTreatmentComboBox()
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TedaviAdi FROM Tedavi_tbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            txttad.Items.Clear();
                            while (reader.Read())
                            {
                                txttad.Items.Add(reader["TedaviAdi"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tedavi adları yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        private void FillHourComboBox()
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT SaatID, Saatler FROM saat_tbl";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            txtsaat.Items.Clear();
                            while (reader.Read())
                            {
                                txtsaat.Items.Add(reader["Saatler"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Saatler yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }



        private void GetCustomerInfohasta(string tcNo)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT HastaAdi, HastaSoyadi, HastaTelefonNumarasi FROM Hastalar_tbl WHERE HastaTCNumarasi = @TCNo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TCNo", tcNo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtmadi.Text = reader["HastaAdi"].ToString();
                                txtmsoyadi.Text = reader["HastaSoyadi"].ToString();
                                mtxtmtelno.Text = reader["HastaTelefonNumarasi"].ToString();
                            }
                            else
                            {
                                // MessageBox.Show("Hasta bilgisi bulunamadı!"); // Belki bu mesaj gereksiz olabilir
                                txtmadi.Clear();
                                txtmsoyadi.Clear();
                                mtxtmtelno.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hasta bilgileri alınırken hata: " + ex.Message);
                }
            }
        }
        private void GetDoctorDetails(string doctorName)
        {
            using(SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DoktorSoyadi, DoktorTelefonNumarasi FROM Doktor_tbl WHERE DoktorAdi = @DoktorAd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoktorAd", doctorName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtdrsoyad.Text = reader["DoktorSoyadi"].ToString();
                                mtxtdrtelno.Text = reader["DoktorTelefonNumarasi"].ToString();
                            }
                            else
                            {
                                txtdrsoyad.Clear();
                                mtxtdrtelno.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Doktor bilgileri alınırken hata: " + ex.Message);
                }
            }
        }
        private void GetTreatmentDetails(string treatmentName)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TedaviFiyati FROM Tedavi_tbl WHERE TedaviAdi = @TedaviAdi";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TedaviAdi", treatmentName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txttucret.Text = reader["TedaviFiyati"].ToString();
                            }
                            else
                            {
                                txttucret.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tedavi ücreti alınırken hata: " + ex.Message);
                }
            }
        }
        private void SaveDate(DateTime selectedDate)
        {
            string formattedDate = selectedDate.ToString("dd-MM-yyyy");
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    // Önce tarihin var olup olmadığını kontrol et
                    string checkQuery = "SELECT TarihID FROM tarih_tbl WHERE Tarih = @Tarih";
                    object result;
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Tarih", formattedDate);
                        result = checkCommand.ExecuteScalar();
                    }

                    // Eğer tarih yoksa ekle
                    if (result == null)
                    {
                        string insertQuery = "INSERT INTO tarih_tbl (Tarih) VALUES (@Tarih)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Tarih", formattedDate);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarih kaydedilirken hata: " + ex.Message);
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


        private void txtdrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtdrad.SelectedItem == null)
                return;

            string selectedDoctor = txtdrad.SelectedItem.ToString();
            GetDoctorDetails(selectedDoctor);
        }


        private void txttad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txttad.SelectedItem == null)
                return;

            string selectedTreatment = txttad.SelectedItem.ToString();
            GetTreatmentDetails(selectedTreatment);
        }


        private void txtsaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsaat.SelectedItem == null)
                return;

            string selectedHour = txtsaat.SelectedItem.ToString();
        }


        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (date == null)
                return;

            DateTime selectedDate = date.Value.Date; 
            SaveDate(selectedDate); 
        }

        private int GetHastaID(string tcNo)
        {
            int id = -1;
            using (SqlConnection connection = DbConnection.GetConnection()) // DbConnection kullanıyoruz.
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT HastaID FROM Hastalar_tbl WHERE HastaTCNumarasi = @tc", connection);
                    cmd.Parameters.AddWithValue("@tc", tcNo);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        id = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hasta ID alınırken hata: " + ex.Message);
                }
            }
            return id;
        }

        private int GetTedaviID(string tedaviAdi)
        {
            int id = -1;
            if (string.IsNullOrEmpty(tedaviAdi)) return id;
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TedavilerID FROM Tedavi_tbl WHERE TedaviAdi = @ad", connection))
                    {
                        cmd.Parameters.AddWithValue("@ad", tedaviAdi);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Tedavi ID alınırken hata: " + ex.Message); }
            }
            return id;
        }

        private int GetSaatID(string saat)
        {
            int id = -1;
            if (string.IsNullOrEmpty(saat)) return id;
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT SaatID FROM Saat_tbl WHERE Saatler = @saat", connection))
                    {
                        cmd.Parameters.AddWithValue("@saat", saat);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Saat ID alınırken hata: " + ex.Message); }
            }
            return id;
        }
        private int GetDoktorID(string doktoradi)
        {
            int id = -1;
            if (string.IsNullOrEmpty(doktoradi)) return id;
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DoktorID FROM Doktor_tbl WHERE DoktorAdi = @ad", connection))
                    {
                        cmd.Parameters.AddWithValue("@ad", doktoradi);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Doktor ID alınırken hata: " + ex.Message); }
            }
            return id;
        }

        private int GetTarihID(DateTime tarih)
        {
            int id = -1;
            string formattedDate = tarih.ToString("dd-MM-yyyy");
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TarihID FROM Tarih_tbl WHERE Tarih = @tarih", connection))
                    {
                        cmd.Parameters.AddWithValue("@tarih", formattedDate);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Tarih ID alınırken hata: " + ex.Message); }
            }
            return id;
        }
        private bool RandevuVarMi(int doktorID, int saatID, int tarihID, int hariçRandevuID = 0)
        {
            if (doktorID == -1 || saatID == -1 || tarihID == -1) return false;
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Randevu_tbl WHERE RandevuDID=@drid AND RandevuSID=@sid AND RandevuTaID=@taid";
                    if (hariçRandevuID > 0)
                    {
                        query += " AND RandevuID != @randevuID";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@drid", doktorID);
                        cmd.Parameters.AddWithValue("@sid", saatID);
                        cmd.Parameters.AddWithValue("@taid", tarihID);
                        if (hariçRandevuID > 0)
                        {
                            cmd.Parameters.AddWithValue("@randevuID", hariçRandevuID);
                        }
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Randevu kontrolü sırasında hata: " + ex.Message);
                    return true; // Hata durumunda, çakışma varmış gibi davranmak daha güvenli olabilir.
                }
            }
        }
        private void RandevuEkle()
        {
            if (txtmtc.SelectedItem == null || txttad.SelectedItem == null || txtsaat.SelectedItem == null || txtdrad.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları seçiniz!");
                return;
            }

            int hastaID = GetHastaID(txtmtc.Text);
            int tedaviID = GetTedaviID(txttad.Text);
            int saatID = GetSaatID(txtsaat.Text);
            int tarihID = GetTarihID(date.Value);
            int doktorID = GetDoktorID(txtdrad.Text);

            if (hastaID == -1 || tedaviID == -1 || saatID == -1 || tarihID == -1 || doktorID == -1)
            {
                MessageBox.Show("Eksik veya hatalı bilgi var! (ID'ler alınamadı)");
                return;
            }

            if (RandevuVarMi(doktorID, saatID, tarihID))
            {
                MessageBox.Show("Bu doktorun bu saatte zaten randevusu var! Lütfen başka bir saat veya tarih seçin.");
                return;
            }

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Randevu_tbl (RandevuHID, RandevuTeID, RandevuSID, RandevuTaID, RandevuDID) VALUES (@hid, @teid, @sid, @taid, @drid)", connection))
                    {
                        cmd.Parameters.AddWithValue("@hid", hastaID);
                        cmd.Parameters.AddWithValue("@teid", tedaviID);
                        cmd.Parameters.AddWithValue("@sid", saatID);
                        cmd.Parameters.AddWithValue("@drid", doktorID);
                        cmd.Parameters.AddWithValue("@taid", tarihID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarıyla eklendi!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Randevu eklenirken hata: " + ex.Message); }
            }
            Temizle();
            verileritazele();
        }


        private void btnekle_Click(object sender, EventArgs e)
        {
            RandevuEkle();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows.Count > e.RowIndex) // Satırın geçerli olduğundan emin ol
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try // Olası hataları yakalamak için try-catch bloğu
                {
                    // En ÖNEMLİ EKSİK KISIM: randevuID'yi ayarla
                    if (row.Cells["RandevuID"].Value != null && row.Cells["RandevuID"].Value != DBNull.Value)
                    {
                        randevuID = Convert.ToInt32(row.Cells["RandevuID"].Value);
                    }
                    else
                    {
                        randevuID = 0; // Geçerli ID yoksa sıfırla
                        MessageBox.Show("Seçilen randevuya ait ID bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Belki burada diğer alanları da temizlemek veya formu sıfırlamak isteyebilirsin.
                        // return; // Eğer ID yoksa diğer alanları doldurmak istemiyorsan
                    }

                    // Diğer alanları doldurma (senin orijinal kodun)
                    txtdrad.Text = row.Cells["DoktorAdi"].Value?.ToString() ?? "";
                    txtdrsoyad.Text = row.Cells["DoktorSoyadi"].Value?.ToString() ?? "";
                    mtxtdrtelno.Text = row.Cells["DoktorTelefonNumarasi"].Value?.ToString() ?? "";
                    txtmtc.Text = row.Cells["HastaTCNumarasi"].Value?.ToString() ?? "";
                    txtmadi.Text = row.Cells["HastaAdi"].Value?.ToString() ?? "";
                    txtmsoyadi.Text = row.Cells["HastaSoyadi"].Value?.ToString() ?? "";
                    mtxtmtelno.Text = row.Cells["HastaTelefonNumarasi"].Value?.ToString() ?? "";
                    txttad.Text = row.Cells["TedaviAdi"].Value?.ToString() ?? "";
                    txttucret.Text = row.Cells["TedaviFiyati"].Value?.ToString() ?? "";
                    txtsaat.Text = row.Cells["Saatler"].Value?.ToString() ?? "";

                    DateTime parsedDate;
                    if (row.Cells["Tarih"].Value != null && DateTime.TryParse(row.Cells["Tarih"].Value.ToString(), out parsedDate))
                    {
                        date.Value = parsedDate;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Satır verileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    randevuID = 0; // Hata durumunda ID'yi sıfırla
                    Temizle();     // Formu temizle
                }
            }
        }
        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (randevuID == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir randevu seçin.");
                return;
            }

            if (txtmtc.SelectedItem == null || txttad.SelectedItem == null || txtsaat.SelectedItem == null || txtdrad.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları seçiniz!");
                return;
            }

            int hastaID = GetHastaID(txtmtc.Text);
            int tedaviID = GetTedaviID(txttad.Text);
            int saatID = GetSaatID(txtsaat.Text);
            int tarihID = GetTarihID(date.Value);
            int doktorID = GetDoktorID(txtdrad.Text);

            if (hastaID == -1 || tedaviID == -1 || saatID == -1 || tarihID == -1 || doktorID == -1)
            {
                MessageBox.Show("Eksik ya da hatalı bilgi girdiniz! (ID'ler alınamadı)");
                return;
            }

            // Güncellenen randevunun kendisi hariç, başka bir çakışma var mı kontrol et
            if (RandevuVarMi(doktorID, saatID, tarihID, randevuID))
            {
                MessageBox.Show("Bu doktorun bu saatte zaten başka bir randevusu var! Lütfen başka bir saat veya tarih seçin.");
                return;
            }

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE Randevu_tbl SET RandevuHID=@hid, RandevuTeID=@teid, RandevuSID=@sid, RandevuTaID=@taid, RandevuDID=@did WHERE RandevuID=@rid", connection))
                    {
                        updateCmd.Parameters.AddWithValue("@hid", hastaID);
                        updateCmd.Parameters.AddWithValue("@teid", tedaviID);
                        updateCmd.Parameters.AddWithValue("@sid", saatID);
                        updateCmd.Parameters.AddWithValue("@taid", tarihID);
                        updateCmd.Parameters.AddWithValue("@did", doktorID);
                        updateCmd.Parameters.AddWithValue("@rid", randevuID);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarıyla güncellendi!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Randevu güncellenirken hata: " + ex.Message); }
            }
            Temizle();
            verileritazele();
            randevuID = 0;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (randevuID == 0)
            {
                MessageBox.Show("Lütfen silinecek bir randevu seçin.");
                return;
            }

            var confirm = MessageBox.Show("Seçilen randevuyu silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Randevu_tbl WHERE RandevuID=@rid", connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@rid", randevuID);
                        deleteCmd.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarıyla silindi!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Randevu silinirken hata: " + ex.Message); }
            }
            Temizle();
            verileritazele();
            randevuID = 0;
        }
        private void Temizle()
        {
            txtdrad.SelectedIndexChanged -= txtdrad_SelectedIndexChanged;
            txtmtc.SelectedIndexChanged -= txtmtc_SelectedIndexChanged;
            txttad.SelectedIndexChanged -= txttad_SelectedIndexChanged;

            txtdrad.SelectedIndex = -1;
            txtdrsoyad.Clear();
            mtxtdrtelno.Clear();

            txtmtc.SelectedIndex = -1;
            txtmadi.Clear();
            txtmsoyadi.Clear();
            mtxtmtelno.Clear();

            txttad.SelectedIndex = -1;
            txttucret.Clear();

            txtsaat.SelectedIndex = -1;

            date.Value = DateTime.Now;

            txtdrad.SelectedIndexChanged += txtdrad_SelectedIndexChanged;
            txtmtc.SelectedIndexChanged += txtmtc_SelectedIndexChanged;
            txttad.SelectedIndexChanged += txttad_SelectedIndexChanged;
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    string ara = txtara.Text.Trim();
                    DataTable dtara = new DataTable();

                    string query = "select RandevuID, HastaTCNumarasi,HastaAdi,HastaSoyadi,HastaTelefonNumarasi,DoktorAdi,DoktorSoyadi,DoktorTelefonNumarasi,TedaviAdi,TedaviFiyati,Saatler,Tarih from Randevu_tbl " +
                                   "inner join Hastalar_tbl on HastaID=RandevuHID " +
                                   "inner join Doktor_tbl on DoktorID=RandevuDID " +
                                   "inner join Tedavi_tbl on TedavilerID=RandevuTeID " +
                                   "inner Join Saat_tbl on SaatID = RandevuSID " +
                                   "inner join Tarih_tbl on TarihID=RandevuTaID " +
                                   "where HastaTCNumarasi LIKE @ara OR HastaAdi LIKE @ara OR HastaSoyadi LIKE @ara OR HastaTelefonNumarasi LIKE @ara " +
                                   "order by Tarih, Saatler";

                    using (SqlDataAdapter adptara = new SqlDataAdapter(query, con))
                    {
                        // Güvenli yöntem: Parametre kullanmak.
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
    


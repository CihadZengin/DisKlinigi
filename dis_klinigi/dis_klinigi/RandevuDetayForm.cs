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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace dis_klinigi
{
    public partial class RandevuDetayForm : Form
    {
        private int hastaninIDsi;
        private string hastaTC;
        private int secilenBorcID = 0;
        private int secilenRandevuID = 0;
        private int hastaID = 0;
        public RandevuDetayForm()
        {
            InitializeComponent();
        }

        private void RandevuDetayForm_Load(object sender, EventArgs e)
        {
            // Bağlantıyı DbConnection'dan alıyoruz.
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open(); // Bağlantıyı burada bir kere açıyoruz, tüm işlemler için kullanacağız.

                    string getHastaIdQuery = "SELECT HastaID FROM Hastalar_tbl WHERE HastaTCNumarasi = @hastaTC";
                    using (SqlCommand cmdGetId = new SqlCommand(getHastaIdQuery, conn))
                    {
                        cmdGetId.Parameters.AddWithValue("@hastaTC", hastaTC);
                        object result = cmdGetId.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            hastaninIDsi = Convert.ToInt32(result);

                            string getHastaDetayQuery = "SELECT HastaAdi, HastaSoyadi, HastaTelefonNumarasi, HastaCinsiyeti FROM Hastalar_tbl WHERE HastaID = @hastaID";
                            using (SqlCommand hastaCmd = new SqlCommand(getHastaDetayQuery, conn))
                            {
                                hastaCmd.Parameters.AddWithValue("@hastaID", hastaninIDsi);
                                using (SqlDataReader reader = hastaCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        lblHastaTC.Text = "TC: " + hastaTC;
                                        lblHastaAdiSoyadi.Text = "Adı Soyadı: " + reader["HastaAdi"].ToString() + " " + reader["HastaSoyadi"].ToString();
                                        lblHastaTelefon.Text = "Telefon Numarası: " + reader["HastaTelefonNumarasi"].ToString();
                                        lblHastaCinsiyeti.Text = "Cinsiyet: " + reader["HastaCinsiyeti"].ToString();
                                    }
                                } // SqlDataReader burada otomatik kapanır (using bloğu)
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hata: Hasta ID bulunamadı.");
                            this.Close();
                            return;
                        }
                    }

                    string query = "SELECT RandevuID, DoktorAdi,DoktorSoyadi,TedaviAdi,TedaviFiyati,Saatler,Tarih FROM Randevu_tbl " +
                                   "INNER JOIN Hastalar_tbl ON HastaID=RandevuHID " +
                                   "INNER JOIN Doktor_tbl ON DoktorID=RandevuDID " +
                                   "INNER JOIN Tedavi_tbl ON TedavilerID=RandevuTeID " +
                                   "INNER JOIN Saat_tbl ON SaatID = RandevuSID " +
                                   "INNER JOIN Tarih_tbl ON TarihID=RandevuTaID WHERE HastaTCNumarasi = @hastaTC";
                    using (SqlDataAdapter daRandevu = new SqlDataAdapter(query, conn))
                    {
                        daRandevu.SelectCommand.Parameters.AddWithValue("@hastaTC", hastaTC);
                        DataTable dtRandevu = new DataTable();
                        daRandevu.Fill(dtRandevu);
                        dataGridView1.DataSource = dtRandevu;
                    }

                    string ilacQuery = "SELECT İlacAdi,KullanımKosullari,İlacDetaylari FROM Alınanİlac_tbl " +
                                       "INNER JOIN Hastalar_tbl ON HastaID=HID " +
                                       "INNER JOIN Recete_tbl ON İlacID=Alınanİlaclar WHERE HastaTCNumarasi = @hastaTC";
                    using (SqlDataAdapter daIlac = new SqlDataAdapter(ilacQuery, conn))
                    {
                        daIlac.SelectCommand.Parameters.AddWithValue("@hastaTC", hastaTC);
                        DataTable dtIlac = new DataTable();
                        daIlac.Fill(dtIlac);
                        dataGridView2.DataSource = dtIlac;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Form yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // conn burada otomatik kapanır (using bloğu)
            }

            HesaplaToplamBorc();
            dataGridView1.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView2.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView2.GridColor = Color.FromArgb(224, 224, 224);

            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            defaultCellStyle.SelectionForeColor = Color.White;
            defaultCellStyle.Padding = new Padding(5, 2, 5, 2);
            dataGridView1.DefaultCellStyle = defaultCellStyle;
            dataGridView2.DefaultCellStyle = defaultCellStyle;

            DataGridViewCellStyle alternatingCellStyle = new DataGridViewCellStyle();
            alternatingCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            alternatingCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            alternatingCellStyle.SelectionBackColor = Color.FromArgb(62, 162, 229);
            alternatingCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = alternatingCellStyle;
            dataGridView2.AlternatingRowsDefaultCellStyle = alternatingCellStyle;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView2.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.FromArgb(70, 70, 70);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            columnHeaderStyle.Padding = new Padding(5, 5, 5, 5);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView2.ColumnHeadersHeight = 30;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;



        }
        public RandevuDetayForm(string tc)
        {
            InitializeComponent();
            hastaTC = tc;
        }
        private void BorcuVeritabaninaKaydet()
        {

            // ... (Metodun başındaki kontroller aynı kalabilir) ...
            if (hastaninIDsi == 0)
            {
                MessageBox.Show("Hasta ID bulunamadı. İşlem yapılamaz.");
                return;
            }

            // Bağlantıyı DbConnection'dan alıyoruz.
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open(); // Bağlantıyı burada bir kere açıyoruz, tüm işlemler için kullanacağız.

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        // ... (randevuIDColumnIndex ve tedaviFiyatiColumnIndex kontrolleri aynı kalabilir) ...

                        if (row.Cells["RandevuID"].Value != null && row.Cells["TedaviFiyati"].Value != null) // Sütun adlarını kontrol et
                        {
                            int currentRandevuID;
                            decimal currentTedaviFiyati;

                            if (int.TryParse(row.Cells["RandevuID"].Value.ToString(), out currentRandevuID) &&
                                decimal.TryParse(row.Cells["TedaviFiyati"].Value.ToString(), out currentTedaviFiyati))
                            {
                                // Her bir satır için ayrı bir transaction başlatmak yerine,
                                // tüm döngü için tek bir transaction başlatmak daha performanslı olabilir
                                // ama mevcut yapıyı korumak adına şimdilik böyle bırakıyorum.
                                // Eğer çok fazla satır varsa bu yapı yavaş olabilir.
                                using (SqlTransaction transaction = conn.BeginTransaction())
                                {
                                    try
                                    {
                                        string checkQuery = "SELECT COUNT(*) FROM BorcTbl WHERE HID = @HastaID AND RandevuID = @RandevuID";
                                        int existingCount = 0;
                                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                                        {
                                            checkCmd.Parameters.AddWithValue("@HastaID", hastaninIDsi);
                                            checkCmd.Parameters.AddWithValue("@RandevuID", currentRandevuID);
                                            existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                                        }

                                        if (existingCount > 0)
                                        {
                                            string updateQuery = "UPDATE BorcTbl SET toplamTutar = @ToplamTutar, borcTutarı = @ToplamTutar - ödenenTutar WHERE HID = @HastaID AND RandevuID = @RandevuID";
                                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                                            {
                                                updateCmd.Parameters.AddWithValue("@HastaID", hastaninIDsi);
                                                updateCmd.Parameters.AddWithValue("@RandevuID", currentRandevuID);
                                                updateCmd.Parameters.AddWithValue("@ToplamTutar", currentTedaviFiyati);
                                                updateCmd.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            string insertQuery = "INSERT INTO BorcTbl (HID, randevuID, toplamtutar, ödenenTutar, borcTutarı) VALUES (@HastaID, @RandevuID, @ToplamTutar, 0, @ToplamTutar)";
                                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                                            {
                                                insertCmd.Parameters.AddWithValue("@HastaID", hastaninIDsi);
                                                insertCmd.Parameters.AddWithValue("@RandevuID", currentRandevuID);
                                                insertCmd.Parameters.AddWithValue("@ToplamTutar", currentTedaviFiyati);
                                                insertCmd.ExecuteNonQuery();
                                            }
                                        }
                                        transaction.Commit();
                                    }
                                    catch (Exception ex)
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Borç bilgisi kaydedilirken bir hata oluştu (Satır: " + row.Index + "): " + ex.Message);
                                        // Hata durumunda döngüden çıkmak veya devam etmek kararı verilebilir.
                                        // Şimdilik devam ediyor.
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Uyarı: Randevu ID veya Tedavi Fiyatı sayısal değil. RandevuID: {row.Cells["RandevuID"].Value}, TedaviFiyati: {row.Cells["TedaviFiyati"].Value}");
                            }
                        }
                    }
                    MessageBox.Show("Tüm borç bilgileri veritabanına başarıyla kaydedildi/güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Genel bir hata oluştu (BorcuVeritabaninaKaydet): " + ex.Message);
                }

            }
        }

        private void btnBorcuKaydet_Click(object sender, EventArgs e)
        {
            BorcuVeritabaninaKaydet();
        }

        private void HesaplaToplamBorc()
        {
            decimal toplamBorc = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (dataGridView1.Columns.Contains("TedaviFiyati") && row.Cells["TedaviFiyati"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["TedaviFiyati"].Value.ToString(), out decimal tedaviFiyati))
                    {
                        toplamBorc += tedaviFiyati;
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Tedavi Fiyatı değeri bulundu: " + row.Cells["TedaviFiyati"].Value, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            lblToplamBorc.Text = "Toplam Tutar: " + toplamBorc.ToString("N2") + " TL";
        }

        private void btnOdemeIslemleri_Click(object sender, EventArgs e)
        {
            if (hastaninIDsi == 0 || string.IsNullOrEmpty(hastaTC))
            {
                MessageBox.Show("Hasta bilgileri alınamadı. Ödeme işlemleri açılamıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OdemeForm odemeForm = new OdemeForm(hastaTC, hastaninIDsi);
            odemeForm.ShowDialog();
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

        private void btnodemegeçmişi_Click(object sender, EventArgs e)
        {
            if (hastaninIDsi == 0 || string.IsNullOrEmpty(hastaTC))
            {
                MessageBox.Show("Form için geçerli bir hasta tanımlanmamış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                detayform gecmisFormu = new detayform(hastaTC, hastaninIDsi);
                gecmisFormu.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
         
         
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                    saveFileDialog.Title = "PDF olarak kaydet";
                    // hastaTC class seviyesinde tanımlı ve dolu olmalı
                    saveFileDialog.FileName = $"Hasta_Raporu_{hastaTC}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Document document = new Document(PageSize.A4, 20, 20, 20, 20); // Kenar boşlukları ayarlandı
                        PdfWriter writer = null; // writer'ı burada tanımla

                        try // Dosya işlemleri için ayrı bir try-finally
                        {
                            writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                            document.Open();

                            // Font Tanımlamaları (Türkçe karakterler için gerekirse BaseFont kullan)
                            // BaseFont bfHelvetica = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1254, BaseFont.NOT_EMBEDDED);
                            // var baslikFont = new Font(bfHelvetica, 16, Font.BOLD);

                            var baslikFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                            var subBaslikFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                            var etiketFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10); // Tablo başlıkları için daha küçük bold
                            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                            // Ana Başlık
                            Paragraph title = new Paragraph("Hasta Raporu", baslikFont);
                            title.Alignment = Element.ALIGN_CENTER;
                            title.SpacingAfter = 10f; // Başlık sonrası boşluk
                            document.Add(title);

                            // --- HASTA BİLGİLERİ LABEL'LARDAN ---
                            Paragraph hastaBilgileriBaslik = new Paragraph("Hasta Bilgileri", subBaslikFont);
                            hastaBilgileriBaslik.SpacingBefore = 10f;
                            hastaBilgileriBaslik.SpacingAfter = 5f;
                            document.Add(hastaBilgileriBaslik);

                            // Label'lardaki metinleri doğrudan ekle
                            // Form_Load'da "TC: " gibi ön eklerle doldurulduğunu varsayıyoruz.
                            if (lblHastaTC.Text != "TC:" && !string.IsNullOrWhiteSpace(lblHastaTC.Text.Replace("TC:", "").Trim()))
                                document.Add(new Paragraph(lblHastaTC.Text, normalFont));
                            if (lblHastaAdiSoyadi.Text != "Adı Soyadı:" && !string.IsNullOrWhiteSpace(lblHastaAdiSoyadi.Text.Replace("Adı Soyadı:", "").Trim()))
                                document.Add(new Paragraph(lblHastaAdiSoyadi.Text, normalFont));
                            if (lblHastaTelefon.Text != "Telefon Numarası:" && !string.IsNullOrWhiteSpace(lblHastaTelefon.Text.Replace("Telefon Numarası:", "").Trim()))
                                document.Add(new Paragraph(lblHastaTelefon.Text, normalFont));
                            if (lblHastaCinsiyeti.Text != "Cinsiyet:" && !string.IsNullOrWhiteSpace(lblHastaCinsiyeti.Text.Replace("Cinsiyet:", "").Trim()))
                                document.Add(new Paragraph(lblHastaCinsiyeti.Text, normalFont));

                            // lblToplamBorc label'ının varlığını ve dolu olup olmadığını kontrol et.
                            // Bu label'ın formunuzda olduğundan ve HesaplaToplamBorc() ile doldurulduğundan emin olun.
                            if (Controls.OfType<Label>().Any(lbl => lbl.Name == "lblToplamBorc") && !string.IsNullOrEmpty(lblToplamBorc.Text) && lblToplamBorc.Text.StartsWith("Toplam Tutar:"))
                            {
                                document.Add(new Paragraph(lblToplamBorc.Text, normalFont));
                            }
                            document.Add(new Paragraph(" ")); // Boş satır

                            // Randevu Bilgileri Tablosu
                            if (dataGridView1.Rows.Count > 0)
                            {
                                Paragraph randevuBaslik = new Paragraph("Randevu Bilgileri", subBaslikFont);
                                randevuBaslik.SpacingBefore = 10f;
                                randevuBaslik.SpacingAfter = 5f;
                                document.Add(randevuBaslik);

                                PdfPTable randevuTable = new PdfPTable(dataGridView1.Columns.Count);
                                randevuTable.WidthPercentage = 100;
                                // randevuTable.SpacingBefore = 5f; // Başlıkla tablo arası boşluk

                                foreach (DataGridViewColumn col in dataGridView1.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, etiketFont));
                                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                    cell.Padding = 4f;
                                    cell.HorizontalAlignment = Element.ALIGN_LEFT;
                                    randevuTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (row.IsNewRow) continue;
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        string text = cell.Value != null ? cell.Value.ToString() : "";
                                        PdfPCell dataCell = new PdfPCell(new Phrase(text, normalFont));
                                        dataCell.Padding = 4f;
                                        randevuTable.AddCell(dataCell);
                                    }
                                }
                                document.Add(randevuTable);
                                document.Add(new Paragraph(" ")); // Boş satır
                            }

                            // İlaç Bilgileri Tablosu
                            if (dataGridView2.Rows.Count > 0)
                            {
                                Paragraph ilacBaslik = new Paragraph("Yazılan İlaç Bilgileri", subBaslikFont);
                                ilacBaslik.SpacingBefore = 10f;
                                ilacBaslik.SpacingAfter = 5f;
                                document.Add(ilacBaslik);

                                PdfPTable ilacTable = new PdfPTable(dataGridView2.Columns.Count);
                                ilacTable.WidthPercentage = 100;
                                // ilacTable.SpacingBefore = 5f;

                                foreach (DataGridViewColumn col in dataGridView2.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, etiketFont));
                                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                    cell.Padding = 4f;
                                    cell.HorizontalAlignment = Element.ALIGN_LEFT;
                                    ilacTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dataGridView2.Rows)
                                {
                                    if (row.IsNewRow) continue;
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        string text = cell.Value != null ? cell.Value.ToString() : "";
                                        PdfPCell dataCell = new PdfPCell(new Phrase(text, normalFont));
                                        dataCell.Padding = 4f;
                                        ilacTable.AddCell(dataCell);
                                    }
                                }
                                document.Add(ilacTable);
                            }
                        }
                        catch (IOException ioEx)
                        {
                            MessageBox.Show("PDF oluşturulurken bir dosya hatası oluştu: " + ioEx.Message + "\nLütfen dosyanın başka bir program tarafından kullanılmadığından emin olun.", "Dosya Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex) // Diğer tüm hatalar için genel catch
                        {
                            MessageBox.Show("PDF oluşturulurken genel bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (document.IsOpen())
                            {
                                document.Close();
                            }
                            if (writer != null)
                            {
                                writer.Close();
                            }
                        }
                        // Başarı mesajı sadece document ve writer başarılı bir şekilde kapatıldıysa gösterilmeli,
                        // yani try bloğunun sonuna veya hatasız bir şekilde finally'den sonra.
                        // Ama saveFileDialog.ShowDialog() == DialogResult.OK kontrolü zaten en dışta.
                        // En temizi, başarılıysa try'ın sonunda göstermek.
                        if (File.Exists(saveFileDialog.FileName)) // Dosya gerçekten oluşturuldu mu kontrolü
                        {
                            MessageBox.Show("PDF başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                // Catch bloğu dışarıda kalmış, saveFileDialog kontrolünün dışına taşıyalım.
                // Ya da tüm işlemi kapsayan tek bir try-catch daha iyi olabilir.
                // Yukarıdaki kodda try-catch'i dosya işlemleri için içe aldım.
                // Genel PDF oluşturma hatası için en dıştaki try-catch bloğu kalabilir.
                // Yukarıdaki kod bu mantığa göre düzenlendi.
                catch (Exception ex) // Bu, saveFileDialog.ShowDialog() öncesi bir hata olursa diye.
                {
                    MessageBox.Show("PDF işlemi başlatılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            
        
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
    




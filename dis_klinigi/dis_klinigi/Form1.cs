using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;


namespace dis_klinigi
{
    public partial class frmlogin : Form
    {

        SqlConnection con; //= new SqlConnection("Data Source= CIHAD;Initial Catalog=proje;Integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public frmlogin()
        {
            InitializeComponent();
            txtsifre.PasswordChar = '*';
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

        private void giris()
        {
            if (string.IsNullOrWhiteSpace(txtkullanici.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Kullan�c� ad� ve �ifre bo� b�rak�lamaz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullaniciAdi = txtkullanici.Text;
            string girilenSifre = txtsifre.Text;
            string hashlenmisGirilenSifre = HashSifre(girilenSifre);

            string veritabanindakiHash = null;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Sifre FROM login_tbl WHERE KullaniciAdi = @KullaniciAdi", con))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            veritabanindakiHash = result.ToString();
                        }
                        con.Close();
                    }


                    if (veritabanindakiHash != null && veritabanindakiHash == hashlenmisGirilenSifre)
                    {
                        MessageBox.Show("Giri� Ba�ar�l�! G�zel Bir �� G�n� Dileriz :)", "Giri� Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� Ad� Veya �ifre Yanl�� L�tfen Tekrar Deneyin", "Giri� Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Sil();
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show($"Veritaban�na ba�lan�rken bir hata olu�tu: {sqlex.Message}", "SQL Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmedik bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }

        }
        private void Sil()
        {
            txtkullanici.Clear();
            txtsifre.Clear();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void txtsifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamay� kapatmak istiyor musunuz?", "Kapan�yor", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chcsifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chcsifre.Checked)
            {
                txtsifre.PasswordChar = '\0';
            }
            else
                txtsifre.PasswordChar = '*';
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanici.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Kullan�c� y�netimi b�l�m�ne eri�mek i�in l�tfen kullan�c� ad� ve �ifrenizi girin.", "Giri� Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullaniciAdi = txtkullanici.Text;
            string girilenSifre = txtsifre.Text;
            string hashlenmisGirilenSifre = HashSifre(girilenSifre);

            string veritabanindakiHash = null;
            bool yetkiliKullanici = false;
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Sifre FROM login_tbl WHERE KullaniciAdi = @KullaniciAdi", con))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            veritabanindakiHash = result.ToString();
                        }
                        con.Close();
                    }

                    if (veritabanindakiHash != null && veritabanindakiHash == hashlenmisGirilenSifre)
                    {
                        yetkiliKullanici = true;
                    }

                    if (yetkiliKullanici)
                    {
                        var dialogResult = MessageBox.Show("Kullan�c� D�zenleme B�l�m�ne eri�mek istedi�inize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            kullanici_ekle klnc = new kullanici_ekle();
                            klnc.Show();
                            // this.Hide(); // Login formunu a��k b�rakabilirsin, kullan�c� ekleme formu modal de�ilse.
                            Sil(); // Giri� bilgilerini temizle
                        }
                        else
                        {
                            MessageBox.Show("��lem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Sil();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� Ad� Ve/Veya �ifre yanl��! Kullan�c� d�zenleme b�l�m�ne sadece yetkili ki�iler eri�ebilir.", "Yetkisiz Eri�im", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Sil();
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show($"Veritaban� hatas�: {sqlex.Message}", "SQL Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblsifre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

            
                
            

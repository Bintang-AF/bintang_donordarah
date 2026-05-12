using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace donordarah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HitungTotal()
        {
            string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // menghitung jumlah baris di tabel Pendonor
                    string query = "SELECT COUNT(*) FROM Pendonor";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();

                    // ExecuteScalar mengambil baris pertama kolom pertama (hasil COUNT)
                    int total = (int)cmd.ExecuteScalar();

                   
                    lblTotal.Text = "Total Data: " + total.ToString();
                }
                catch (Exception ex)
                {
                  
                    Console.WriteLine("Gagal hitung total: " + ex.Message);
                }
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM Pendonor";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    conn.Open();
                    adapter.Fill(dt);

                    dgvviewvalue.DataSource = dt;

                    HitungTotal();

                    MessageBox.Show("Data berhasil ditampilkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            if (identitas.RoleUser == "Petugas")
            {
                btnhapus.Enabled = false;
                lbluser.Text = "Login sebagai: Petugas (" + identitas.NamaUser + ")";
            }
            else
            {
                lbluser.Text = "Login sebagai: Admin (" + identitas.NamaUser + ")";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbluser.Text = "Login Sebagai: " + identitas.NamaUser;

            this.Text = "Aplikasi Donor Darah - Selamat Datang " + identitas.NamaUser;
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnama.Text) || cbgoldar.SelectedIndex == -1 || cbrhesus.SelectedIndex == -1)
            {
                MessageBox.Show("Nama, Golongan Darah, dan Rhesus wajib diisi!", "Peringatan");
                return;
            }

            string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Pendonor (nama_pendonor, golongan_darah, rhesus, telepon, alamat) " +
                               "VALUES (@nama, @goldar, @rhesus, @telp, @alamat)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                cmd.Parameters.AddWithValue("@goldar", cbgoldar.Text);
                cmd.Parameters.AddWithValue("@rhesus", cbrhesus.Text); 
                cmd.Parameters.AddWithValue("@telp", txttelepon.Text);
                cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Pendonor Berhasil Ditambahkan!", "Sukses");

                    LoadData();
                    BersihkanForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Simpan: " + ex.Message);
                }
            }
        }

        private void lblalamat_Click(object sender, EventArgs e)
        {

        }

        private void btnbersihkan_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnama.Clear();
            txttelepon.Clear();
            txtalamat.Clear();
            cbgoldar.SelectedIndex = -1;
            txtnama.Focus();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Pilih data yang ingin diubah dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "UPDATE Pendonor SET nama_pendonor=@nama, golongan_darah=@goldar, telepon=@telp, alamat=@alamat " +
                                   "WHERE id_pendonor=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                    cmd.Parameters.AddWithValue("@goldar", cbgoldar.Text);
                    cmd.Parameters.AddWithValue("@telp", txttelepon.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtalamat.Text); ;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnload_Click(null, null); 
                        BersihkanForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Ubah: " + ex.Message);
                    }
                }
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Data ini akan dihapus permanen. Lanjutkan?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "DELETE FROM Pendonor WHERE id_pendonor=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Berhasil Dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnload_Click(null, null); 
                        HitungTotal();   
                        BersihkanForm(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Hapus: " + ex.Message);
                    }
                }
            }
        }

        private void dgvviewvalue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvviewvalue.Rows[e.RowIndex];

                txtid.Text = row.Cells[0].Value.ToString();
                txtnama.Text = row.Cells[1].Value.ToString();
                cbgoldar.Text = row.Cells[2].Value.ToString(); 
                cbrhesus.Text = row.Cells[3].Value.ToString(); 
                txttelepon.Text = row.Cells[4].Value.ToString();
                txtalamat.Text = row.Cells[5].Value.ToString();
            }
        }
        private void BersihkanForm()
        {
            txtid.Clear();
            txtnama.Clear();
            txttelepon.Clear();
            txtalamat.Clear();
            cbgoldar.SelectedIndex = -1;
            txtnama.Focus();
        }

        private void LoadData()
        {
            string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pendonor", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvviewvalue.DataSource = dt; 
            }
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    
                    string query = "SELECT * FROM Pendonor WHERE nama_pendonor LIKE @nama + '%'";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    
                    cmd.Parameters.AddWithValue("@nama", txtcari.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);

                   
                    dgvviewvalue.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat mencari: " + ex.Message);
                }
            }
        }

        private void dgvviewvalue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } // Penutup Class
} // Penutup Namespace

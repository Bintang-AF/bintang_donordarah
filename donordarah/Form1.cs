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
                    // Query untuk menghitung jumlah baris di tabel Pendonor
                    string query = "SELECT COUNT(*) FROM Pendonor";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();

                    // ExecuteScalar mengambil baris pertama kolom pertama (hasil COUNT)
                    int total = (int)cmd.ExecuteScalar();

                    // Tampilkan ke label. Pastikan nama label di desain kamu benar (misal: lblTotal)
                    lblTotal.Text = "Total Data: " + total.ToString();
                }
                catch (Exception ex)
                {
                    // Tidak perlu pakai MessageBox di sini agar tidak mengganggu user setiap kali refresh
                    Console.WriteLine("Gagal hitung total: " + ex.Message);
                }
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            // Tambahkan TrustServerCertificate=True jika koneksi ditolak karena SSL/Sertifikat
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

                    // 1. Pastikan nama DataGridView di UI kamu adalah 'Dgv'
                    dgvviewvalue.DataSource = dt;

                    // 2. Panggil fungsi hitung total agar angka statistik juga terupdate
                    HitungTotal();

                    MessageBox.Show("Data berhasil ditampilkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 3. Logika Role (Pastikan menggunakan Identitas sesuai diskusi kita sebelumnya)
            // Jika masih merah, ganti 'Session' menjadi 'Identitas'
            if (identitas.RoleUser == "Petugas")
            {
                btnhapus.Enabled = false;
                // lblStatus sesuaikan dengan nama label di desain kamu
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

            // Optional: Tampilkan juga di Title Bar Form (bagian paling atas jendela)
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
                // Query disesuaikan dengan struktur kolom di SQL Server kamu
                string query = "INSERT INTO Pendonor (nama_pendonor, golongan_darah, rhesus, telepon, alamat) " +
                               "VALUES (@nama, @goldar, @rhesus, @telp, @alamat)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                cmd.Parameters.AddWithValue("@goldar", cbgoldar.Text);
                cmd.Parameters.AddWithValue("@rhesus", cbrhesus.Text); // Mengambil dari ComboBox baru
                cmd.Parameters.AddWithValue("@telp", txttelepon.Text);
                cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Pendonor Berhasil Ditambahkan!", "Sukses");

                    LoadData(); // Refresh DataGridView
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
            txttelepon.Clear(); // Ganti yang sebelumnya berat
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

            // Poin E: Konfirmasi sebelum melakukan aksi
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // Gunakan nama kolom: nama_pendonor, golongan_darah, telepon, alamat
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

                        btnload_Click(null, null); // Refresh tabel
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

            // Poin E & F: Konfirmasi Hapus dengan Ikon Warning
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

                        btnload_Click(null, null); // Refresh tabel
                        HitungTotal();   // Update statistik angka di pojok kanan
                        BersihkanForm(); // Kosongkan input
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
                cbgoldar.Text = row.Cells[2].Value.ToString(); // Kolom golongan_darah
                cbrhesus.Text = row.Cells[3].Value.ToString(); // Kolom rhesus
                txttelepon.Text = row.Cells[4].Value.ToString();
                txtalamat.Text = row.Cells[5].Value.ToString();
            }
        }
       

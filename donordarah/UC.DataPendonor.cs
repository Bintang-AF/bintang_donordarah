using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace donordarah
{
    public partial class UC : UserControl
    {
        // 1. Connection String diletakkan di sini agar bisa dipakai oleh semua tombol
        string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

        public UC()
        {
            InitializeComponent();
        }

        // --- EVENT SAAT HALAMAN DIBUKA ---
        private void UC_Load(object sender, EventArgs e)
        {
            // Cek role: Jika Petugas, matikan tombol hapus
            if (identitas.RoleUser == "Petugas")
            {
                btnhapus.Enabled = false;
            }

            // Otomatis memuat data saat halaman pertama kali dibuka
            LoadData();
        }

        // --- FUNGSI BANTUAN (Tampil Data & Bersihkan) ---
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pendonor", conn);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);
                    dgvviewvalue.DataSource = dt;

                    HitungTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HitungTotal()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Pendonor";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    int total = (int)cmd.ExecuteScalar();
                    lblTotal.Text = "Total Data: " + total.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Gagal hitung total: " + ex.Message);
                }
            }
        }

        private void BersihkanForm()
        {
            txtid.Clear();
            txtnama.Clear();
            txttelepon.Clear();
            txtalamat.Clear();
            cbgoldar.SelectedIndex = -1;
            cbrhesus.SelectedIndex = -1; // Tambahan untuk Rhesus
            txtnama.Focus();
        }

        // --- EVENT TOMBOL AKSI (CRUD) ---
        private void btnload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data berhasil ditampilkan/diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnama.Text) || cbgoldar.SelectedIndex == -1 || cbrhesus.SelectedIndex == -1)
            {
                MessageBox.Show("Nama, Golongan Darah, dan Rhesus wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Pendonor (nama_pendonor, golongan_darah, rhesus, telepon, alamat) VALUES (@nama, @goldar, @rhesus, @telp, @alamat)";
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
                    MessageBox.Show("Data Pendonor Berhasil Ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BersihkanForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Simpan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "UPDATE Pendonor SET nama_pendonor=@nama, golongan_darah=@goldar, rhesus=@rhesus, telepon=@telp, alamat=@alamat WHERE id_pendonor=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                    cmd.Parameters.AddWithValue("@goldar", cbgoldar.Text);
                    cmd.Parameters.AddWithValue("@rhesus", cbrhesus.Text); // Perbaikan: Menambahkan rhesus di fitur ubah
                    cmd.Parameters.AddWithValue("@telp", txttelepon.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        BersihkanForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Ubah: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Pilih data yang akan dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Data ini akan dihapus permanen. Lanjutkan?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
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
                        LoadData();
                        BersihkanForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Hapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnbersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        // --- EVENT KLIK TABEL (Pindah Data dari Tabel ke TextBox) ---
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

        // --- EVENT PENCARIAN (Langsung mencari saat diketik) ---
        private void txtcari_TextChanged(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Error saat mencari: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Load_1(object sender, EventArgs e)
        {

        }
    }
}
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

       
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

      mespace

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace donordarah
{
    public partial class UC_Transaksi : UserControl
    {
        string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

        public UC_Transaksi()
        {
            InitializeComponent();
        }

        // 1. EVENT SAAT HALAMAN DIBUKA
        private void UC_Transaksi_Load(object sender, EventArgs e)
        {
            // Set nama petugas otomatis (Ambil dari form login)
            // Jika identitas.NamaUser error, pastikan class identitas sudah public dan punya variabel NamaUser
            txtPetugas.Text = identitas.NamaUser;

            LoadRiwayat();
        }

        // 2. FUNGSI MENAMPILKAN RIWAYAT (MENGGUNAKAN VIEW UCP 2)
        private void LoadRiwayat()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // Menampilkan data menggunakan VIEW khusus transaksi hari ini
                    string query = "SELECT id_transaksi AS [ID TRX], tanggal_donor AS [Tgl Donor], nama_pendonor AS [Nama Pendonor], golongan_darah AS [Goldar], id_kantong AS [ID Kantong] FROM vw_RiwayatTransaksi WHERE CAST(tanggal_donor AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);
                    dgvRiwayat.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat tabel riwayat: " + ex.Message, "Error");
                }
            }
        }

        // 3. FUNGSI PENCARIAN PENDONOR (MENGGUNAKAN SP UCP 2)
        private void btnCari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCari.Text))
            {
                MessageBox.Show("Masukkan nama pendonor terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_CariPendonorUntukTransaksi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", txtCari.Text.Trim());

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Jika ketemu, isi ke text box confirm
                        txtIdPendonor.Text = reader["id_pendonor"].ToString();
                        txtNamaConfirm.Text = reader["nama_pendonor"].ToString();
                        txtGoldarConfirm.Text = reader["golongan_darah"].ToString();
                        MessageBox.Show("Pendonor ditemukan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data pendonor tidak ditemukan di sistem.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BersihkanConfirm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error pencarian: " + ex.Message, "Error");
                }
            }
        }

        // 4. FUNGSI SIMPAN TRANSAKSI (MENGGUNAKAN SP UCP 2)
      
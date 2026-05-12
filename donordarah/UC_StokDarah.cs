using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace donordarah
{
    public partial class UC_StokDarah : UserControl
    {
        // Gunakan connection string milikmu
        string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

        public UC_StokDarah()
        {
            InitializeComponent();
        }

        private void UC_StokDarah_Load(object sender, EventArgs e)
        {
            // Set default pilihan filter agar tidak kosong
            cbFilterGoldar.SelectedIndex = 0; // "Semua"
            cbFilterStatus.SelectedIndex = 0; // "Semua"

            LoadRingkasanStok();
            LoadDataStok();
        }

        // FUNGSI MENGAMBIL ANGKA RINGKASAN (GOL A, B, AB, O)
        private void LoadRingkasanStok()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetRingkasanStok", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        lblStokA.Text = dr["StokA"].ToString() + " Kantong";
                        lblStokB.Text = dr["StokB"].ToString() + " Kantong";
                        lblStokAB.Text = dr["StokAB"].ToString() + " Kantong";
                        lblStokO.Text = dr["StokO"].ToString() + " Kantong";
                    }
                }
                catch (Exception ex) { MessageBox.Show("Gagal Ringkasan: " + ex.Message); }
            }
        }

        // FUNGSI MENAMPILKAN TABEL (MENGGUNAKAN VIEW & SP)
        private void LoadDataStok()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_FilterStok", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", txtCariId.Text);
                cmd.Parameters.AddWithValue("@Goldar", cbFilterGoldar.Text);
                cmd.Parameters.AddWithValue("@Status", cbFilterStatus.Text);

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    dgvStok.DataSource = dt;
                }
                catch (Exception) { /* Diabaikan saat proses mengetik */ }
            }
        }

        // EVENT FILTER REAL-TIME
        private void txtCariId_TextChanged(object sender, EventArgs e) => LoadDataStok();
        private void cbFilterGoldar_SelectedIndexChanged(object sender, EventArgs e) => LoadDataStok();
        private void cbFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadDataStok();

        // KLIK TABEL UNTUK UPDATE
        private void dgvStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdUpdate.Text = dgvStok.Rows[e.RowIndex].Cells["id_kantong"].Value.ToString();
                cbStatusBaru.Text = dgvStok.Rows[e.RowIndex].Cells["status"].Value.ToString();
            }
        }

        // TOMBOL UPDATE STATUS
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdUpdate.Text)) return;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateStatusKantong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_kantong", txtIdUpdate.Text);
                cmd.Parameters.AddWithValue("@status_baru", cbStatusBaru.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Status Berhasil Diperbarui!");
                    LoadRingkasanStok();
                    LoadDataStok();
                }
                catch (Exception ex) { MessageBox.Show("Gagal: " + ex.Message); }
            }
        }
    }
}
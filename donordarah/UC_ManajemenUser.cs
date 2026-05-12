using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace donordarah
{
    public partial class UC_User : UserControl
    {
        string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

        public UC_User()
        {
            InitializeComponent();
        }

        private void UC_User_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // Pakai VIEW vw_DaftarUser yang barusan kita buat di SSMS
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_DaftarUser", conn);
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    dgvUser.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show("Gagal Muat: " + ex.Message); }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parameter disesuaikan dengan SP sp_InsertUser terbaru
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                cmd.Parameters.AddWithValue("@role", cbRole.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Petugas Berhasil Terdaftar!");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var id = dgvUser.SelectedRows[0].Cells["ID"].Value;
                if (MessageBox.Show("Yakin hapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_DeleteUser", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtNamaLengkap.Clear();
            cbRole.SelectedIndex = -1;
        }
    }
}
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
       
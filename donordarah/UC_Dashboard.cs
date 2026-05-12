using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace donordarah
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        // Event saat halaman dashboard dimuat
        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            HitungDashboard();
        }

        private void HitungDashboard()
        {
            string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // 1. Menghitung Total Pendonor
                    SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Pendonor", conn);
                    lblTotalPendonor.Text = cmd1.ExecuteScalar().ToString();

                    // 2. Menghitung Stok Darah
                    SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Stok_Darah", conn);
                    lblStokDarah.Text = cmd2.ExecuteScalar().ToString();

                    // 3. Menghitung Transaksi Hari Ini
                    SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Transaksi_Donor WHERE CAST(tanggal_donor AS DATE) = CAST(GETDATE() AS DATE)", conn);
                    lblTransaksiHariIni.Text = cmd3.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Dashboard: " + ex.Message);
                }
            }
        }
    }
}

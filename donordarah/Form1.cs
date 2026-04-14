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

      

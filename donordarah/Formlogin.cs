using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace donordarah
{
    public partial class Formlogin: Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connString = @"Data source=DESKTOP-E32H1C2\BINTANGAF;initial catalog=DBdonordarah;integrated security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT nama_lengkap, role FROM Pengguna WHERE username=@user AND password=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtuser.Text);
                cmd.Parameters.AddWithValue("@pass", txtpwd.Text);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // --- KUNCI UTAMA: Menitipkan data ke class identitas ---
                        identitas.NamaUser = reader["nama_lengkap"].ToString();
                        identitas.RoleUser = reader["role"].ToString();

                        MessageBox.Show("Selamat Datang, " + identitas.NamaUser);

                        // Pindah Form
                        Form1 utama = new Form1();
                        utama.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password Salah!");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

       
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace donordarah
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        // Event saat form dashboard baru pertama kali dibuka/diload
        private void dashboard_Load(object sender, EventArgs e)
        {
            // 1. Tampilkan nama user di pojok kanan atas dari class identitas
            lblUserLogin.Text = "Halo, " + identitas.NamaUser;

            // 3. Logika Hak Akses (RBAC) - Menyembunyikan menu jika BUKAN Admin
            if (identitas.RoleUser != "Admin")
            {
                btnManajemenUser.Visible = false; // Menyembunyikan tombol Manajemen User
                lblAdminOnly.Visible = false;     // Menyembunyikan tulisan "Admin Only"
                sepAdmin.Visible = false;         // Menyembunyikan garis strip separator
            }
        }

        // Fungsi khusus untuk menarik dan menghitung data dari SQL
      

        // Event saat tombol Log Out diklik
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Munculkan kotak konfirmasi sebelum benar-benar keluar
            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close(); // Menutup halaman dashboard saat ini

                // Membuka kembali halaman Formlogin
                Formlogin login = new Formlogin();
                login.Show();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            lblJudulHalaman.Text = "Kelola Data Pendonor";

            // 1. PASTIKAN PANEL TERLIHAT (Ini kunci agar tidak perlu klik 2x)
            panelKonten.Visible = true;

            // 2. Bersihkan panel sampai benar-benar kosong
            foreach (Control c in panelKonten.Controls)
            {
                c.Dispose();
            }
            panelKonten.Controls.Clear();

            // 3. Panggil halaman Pendonor
            UC ucPendonor = new UC();
            ucPendonor.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(ucPendonor);

            // 4. Paksa panel untuk tampil di paling depan
            panelKonten.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // 1. Ubah judul
            lblJudulHalaman.Text = "Dashboard Utama";

            // 2. Bersihkan panel
            panelKonten.Controls.Clear();

            // 3. Panggil halaman Dashboard
            UC_Dashboard ucDash = new UC_Dashboard();
            ucDash.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(ucDash);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            // 1. Pastikan judulnya benar saat pertama kali buka
            lblJudulHalaman.Text = "Dashboard Utama";

            // 2. Bersihkan panel tengah
            panelKonten.Controls.Clear();

            // 3. Langsung panggil User Control Dashboard
            UC_Dashboard ucDash = new UC_Dashboard();
            ucDash.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(ucDash);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // 1. Ubah Judul Header di atas
            lblJudulHalaman.Text = "Transaksi Donor Darah";

            // 2. Pastikan panel penampung terlihat
            panelKonten.Visible = true;

            // 3. Bersihkan halaman sebelumnya dari memori agar ringan
            foreach (Control c in panelKonten.Controls)
            {
                c.Dispose();
            }
            panelKonten.Controls.Clear();

            // 4. Panggil User Control Transaksi yang baru kita buat
            UC_Transaksi ucTrans = new UC_Transaksi();
            ucTrans.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(ucTrans);

            // 5. Paksa panel tampil di paling depan
            panelKonten.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lblJudulHalaman.Text = "Manajemen Stok Darah";
            panelKonten.Visible = true;

            // Bersihkan panel agar tidak tumpang tindih
            foreach (Control c in panelKonten.Controls)
            {
                c.Dispose();
            }
            panelKonten.Controls.Clear();

            // Panggil halaman Stok Darah
            UC_StokDarah ucStok = new UC_StokDarah();
            ucStok.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(ucStok);
            panelKonten.BringToFront();
        }

        private void btnManajemenUser_Click(object sender, EventArgs e)
        {
            // 1. Ubah Judul di Header
            lblJudulHalaman.Text = "Manajemen Pengguna";

            // 2. Pastikan Panel Konten terlihat
            panelKonten.Visible = true;

            // 3. Bersihkan panel agar halaman sebelumnya tidak tumpang tindih
            foreach (Control c in panelKonten.Controls)
            {
                c.Dispose();
            }
            panelKonten.Controls.Clear();

            // 4. Panggil User Control Manajemen User (UC_User)
            UC_User ucUser = new UC_User();
            ucUser.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(ucUser);

            // 5. Bawa ke depan agar tidak tertutup komponen lain
            panelKonten.BringToFront();
        }
    }
}
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

     
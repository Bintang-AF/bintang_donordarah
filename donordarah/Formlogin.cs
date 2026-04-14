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

          
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
      
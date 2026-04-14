namespace donordarah
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.cbgoldar = new System.Windows.Forms.ComboBox();
            this.txttelepon = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnbersihkan = new System.Windows.Forms.Button();
            this.dgvviewvalue = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnama = new System.Windows.Forms.Label();
            this.lblgoldar = new System.Windows.Forms.Label();
            this.lbltelepon = new System.Windows.Forms.Label();
            this.lblalamat = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbrhesus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(854, 532);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(95, 36);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "Tampilkan";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEM MANAJEMEN DONOR DARAH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbrhesus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblnama);
            this.groupBox1.Controls.Add(this.lblgoldar);
            this.groupBox1.Controls.Add(this.lbltelepon);
            this.groupBox1.Controls.Add(this.lblalamat);
            this.groupBox1.Controls.Add(this.txttelepon);
            this.groupBox1.Controls.Add(this.txtalamat);
            this.groupBox1.Controls.Add(this.cbgoldar);
            this.groupBox1.Controls.Add(this.txtnama);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(214, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 320);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pendonor";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtid.Location = new System.Drawing.Point(191, 38);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(495, 26);
            this.txtid.TabIndex = 5;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(191, 80);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(495, 26);
            this.txtnama.TabIndex = 0;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // cbgoldar
            // 
            this.cbgoldar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgoldar.FormattingEnabled = true;
            this.cbgoldar.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cbgoldar.Location = new System.Drawing.Point(191, 129);
            this.cbgoldar.Name = "cbgoldar";
            this.cbgoldar.Size = new System.Drawing.Size(121, 28);
            this.cbgoldar.TabIndex = 1;
            // 
            // txttelepon
            // 
            this.txttelepon.Location = new System.Drawing.Point(191, 224);
            this.txttelepon.Name = "txttelepon";
            this.txttelepon.Size = new System.Drawing.Size(218, 26);
            this.txttelepon.TabIndex = 2;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(191, 267);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(495, 26);
            this.txtalamat.TabIndex = 3;
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(315, 535);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(95, 36);
            this.btntambah.TabIndex = 5;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(447, 535);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(95, 36);
            this.btnubah.TabIndex = 6;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(571, 535);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(95, 36);
            this.btnhapus.TabIndex = 7;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnbersihkan
            // 
            this.btnbersihkan.Location = new System.Drawing.Point(701, 535);
            this.btnbersihkan.Name = "btnbersihkan";
            this.btnbersihkan.Size = new System.Drawing.Size(95, 36);
            this.btnbersihkan.TabIndex = 8;
            this.btnbersihkan.Text = "Bersihkan";
            this.btnbersihkan.UseVisualStyleBackColor = true;
            this.btnbersihkan.Click += new System.EventHandler(this.btnbersihkan_Click);
            // 
            // dgvviewvalue
            // 
            this.dgvviewvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvviewvalue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewvalue.Location = new System.Drawing.Point(-72, 608);
            this.dgvviewvalue.Name = "dgvviewvalue";
            this.dgvviewvalue.RowHeadersWidth = 62;
            this.dgvviewvalue.RowTemplate.Height = 28;
            this.dgvviewvalue.Size = new System.Drawing.Size(1486, 222);
            this.dgvviewvalue.TabIndex = 9;
            this.dgvviewvalue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewvalue_CellClick);
            this.dgvviewvalue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewvalue_CellContentClick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(32, 44);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 20);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "ID";
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(32, 85);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(51, 20);
            this.lblnama.TabIndex = 0;
            this.lblnama.Text = "Nama";
            // 
            // lblgoldar
            // 
            this.lblgoldar.AutoSize = true;
            this.lblgoldar.Location = new System.Drawing.Point(32, 137);
            this.lblgoldar.Name = "lblgoldar";
            this.lblgoldar.Size = new System.Drawing.Size(124, 20);
            this.lblgoldar.TabIndex = 1;
            this.lblgoldar.Text = "Golongan darah";
            this.lblgoldar.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbltelepon
            // 
            this.lbltelepon.AutoSize = true;
            this.lbltelepon.Location = new System.Drawing.Point(32, 224);
            this.lbltelepon.Name = "lbltelepon";
            this.lbltelepon.Size = new System.Drawing.Size(113, 20);
            this.lbltelepon.TabIndex = 2;
            this.lbltelepon.Text = "Nomor telepon";
            this.lbltelepon.Click += new System.EventHandler(this.lblalamat_Click);
            // 
            // lblalamat
            // 
            this.lblalamat.AutoSize = true;
            this.lblalamat.Location = new System.Drawing.Point(32, 271);
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(57, 20);
            this.lblalamat.TabIndex = 3;
            this.lblalamat.Text = "alamat";
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(443, 576);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(595, 26);
            this.txtcari.TabIndex = 10;
            this.txtcari.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cari Nama Pendonor";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(526, 164);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 20);
            this.lbluser.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1085, 582);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 20);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rhesus";
            // 
            // cbrhesus
            // 
            this.cbrhesus.FormattingEnabled = true;
            this.cbrhesus.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbrhesus.Location = new System.Drawing.Point(191, 175);
            this.cbrhesus.Name = "cbrhesus";
            this.cbrhesus.Size = new System.Drawing.Size(121, 28);
            this.cbrhesus.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 816);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.dgvviewvalue);
            this.Controls.Add(this.btnbersihkan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txttelepon;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.ComboBox cbgoldar;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnbersihkan;
        private System.Windows.Forms.DataGridView dgvviewvalue;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label lblgoldar;
        private System.Windows.Forms.Label lbltelepon;
        private System.Windows.Forms.Label lblalamat;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbrhesus;
        private System.Windows.Forms.Label label4;
    }
}


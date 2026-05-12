namespace donordarah
{
    partial class UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.btnbersihkan = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbrhesus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnama = new System.Windows.Forms.Label();
            this.lblgoldar = new System.Windows.Forms.Label();
            this.lbltelepon = new System.Windows.Forms.Label();
            this.lblalamat = new System.Windows.Forms.Label();
            this.txttelepon = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.cbgoldar = new System.Windows.Forms.ComboBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.dgvviewvalue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(864, 406);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 20);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total Data";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(305, -12);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 20);
            this.lbluser.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cari Nama Pendonor";
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(222, 400);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(595, 26);
            this.txtcari.TabIndex = 23;
            this.txtcari.Click += new System.EventHandler(this.txtcari_TextChanged);
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // btnbersihkan
            // 
            this.btnbersihkan.Location = new System.Drawing.Point(496, 359);
            this.btnbersihkan.Name = "btnbersihkan";
            this.btnbersihkan.Size = new System.Drawing.Size(95, 36);
            this.btnbersihkan.TabIndex = 21;
            this.btnbersihkan.Text = "Bersihkan";
            this.btnbersihkan.UseVisualStyleBackColor = true;
            this.btnbersihkan.Click += new System.EventHandler(this.btnbersihkan_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(362, 359);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(95, 36);
            this.btnhapus.TabIndex = 20;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(228, 359);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(95, 36);
            this.btnubah.TabIndex = 19;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(94, 359);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(95, 36);
            this.btntambah.TabIndex = 18;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(64, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 320);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pendonor";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rhesus";
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
            // 
            // lbltelepon
            // 
            this.lbltelepon.AutoSize = true;
            this.lbltelepon.Location = new System.Drawing.Point(32, 224);
            this.lbltelepon.Name = "lbltelepon";
            this.lbltelepon.Size = new System.Drawing.Size(113, 20);
            this.lbltelepon.TabIndex = 2;
            this.lbltelepon.Text = "Nomor telepon";
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
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(191, 80);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(495, 26);
            this.txtnama.TabIndex = 0;
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
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtid.Location = new System.Drawing.Point(191, 38);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(495, 26);
            this.txtid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, -53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "SISTEM MANAJEMEN DONOR DARAH";
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(630, 359);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(95, 36);
            this.btnload.TabIndex = 15;
            this.btnload.Text = "Tampilkan";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // dgvviewvalue
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvviewvalue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvviewvalue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvviewvalue.ColumnHeadersHeight = 4;
            this.dgvviewvalue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvviewvalue.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvviewvalue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvviewvalue.Location = new System.Drawing.Point(0, 440);
            this.dgvviewvalue.Name = "dgvviewvalue";
            this.dgvviewvalue.RowHeadersVisible = false;
            this.dgvviewvalue.RowHeadersWidth = 62;
            this.dgvviewvalue.RowTemplate.Height = 28;
            this.dgvviewvalue.Size = new System.Drawing.Size(1024, 178);
            this.dgvviewvalue.TabIndex = 27;
            this.dgvviewvalue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvviewvalue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvviewvalue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvviewvalue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvviewvalue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvviewvalue.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvviewvalue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvviewvalue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dgvviewvalue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvviewvalue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvviewvalue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvviewvalue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvviewvalue.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvviewvalue.ThemeStyle.ReadOnly = false;
            this.dgvviewvalue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvviewvalue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvviewvalue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvviewvalue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvviewvalue.ThemeStyle.RowsStyle.Height = 28;
            this.dgvviewvalue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvviewvalue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvviewvalue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewvalue_CellClick);
            // 
            // UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvviewvalue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.btnbersihkan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnload);
            this.Name = "UC";
            this.Size = new System.Drawing.Size(1015, 593);
            this.Load += new System.EventHandler(this.UC_Load_1);
            this.Click += new System.EventHandler(this.UC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Button btnbersihkan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbrhesus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label lblgoldar;
        private System.Windows.Forms.Label lbltelepon;
        private System.Windows.Forms.Label lblalamat;
        private System.Windows.Forms.TextBox txttelepon;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.ComboBox cbgoldar;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnload;
        private Guna.UI2.WinForms.Guna2DataGridView dgvviewvalue;
    }
}

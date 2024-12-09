namespace desainperpus_aran
{
    partial class PengembalianBuku
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
            search = new TextBox();
            label8 = new Label();
            bDelete = new Button();
            bInsert = new Button();
            dataGridView1 = new DataGridView();
            idPeminjaman = new ComboBox();
            label1 = new Label();
            idBuku = new ComboBox();
            label2 = new Label();
            judulBuku = new TextBox();
            label3 = new Label();
            jumlahBuku = new NumericUpDown();
            nisSiswa = new ComboBox();
            label4 = new Label();
            namaSiswa = new TextBox();
            label5 = new Label();
            tanggalKembali = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jumlahBuku).BeginInit();
            SuspendLayout();
            // 
            // search
            // 
            search.Location = new Point(176, 26);
            search.Name = "search";
            search.Size = new Size(205, 27);
            search.TabIndex = 37;
            search.TextChanged += search_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 22);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 36;
            label8.Text = "Search";
            // 
            // bDelete
            // 
            bDelete.BackColor = Color.SandyBrown;
            bDelete.FlatAppearance.BorderSize = 0;
            bDelete.FlatStyle = FlatStyle.Flat;
            bDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bDelete.Location = new Point(338, 295);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(193, 44);
            bDelete.TabIndex = 40;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = false;
            bDelete.Click += bDelete_Click;
            // 
            // bInsert
            // 
            bInsert.BackColor = Color.SandyBrown;
            bInsert.FlatAppearance.BorderSize = 0;
            bInsert.FlatStyle = FlatStyle.Flat;
            bInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bInsert.Location = new Point(117, 295);
            bInsert.Name = "bInsert";
            bInsert.Size = new Size(189, 44);
            bInsert.TabIndex = 38;
            bInsert.Text = "Insert";
            bInsert.UseVisualStyleBackColor = false;
            bInsert.Click += bInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(827, 200);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idPeminjaman
            // 
            idPeminjaman.FormattingEnabled = true;
            idPeminjaman.Location = new Point(218, 371);
            idPeminjaman.Name = "idPeminjaman";
            idPeminjaman.Size = new Size(151, 28);
            idPeminjaman.TabIndex = 51;
            idPeminjaman.SelectedIndexChanged += idPeminjaman_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 368);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 52;
            label1.Text = "id Peminjaman";
            // 
            // idBuku
            // 
            idBuku.Enabled = false;
            idBuku.FormattingEnabled = true;
            idBuku.Location = new Point(219, 433);
            idBuku.Name = "idBuku";
            idBuku.Size = new Size(225, 28);
            idBuku.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 433);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 54;
            label2.Text = "id Buku";
            // 
            // judulBuku
            // 
            judulBuku.Enabled = false;
            judulBuku.Location = new Point(218, 467);
            judulBuku.Name = "judulBuku";
            judulBuku.Size = new Size(225, 27);
            judulBuku.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 514);
            label3.Name = "label3";
            label3.Size = new Size(162, 31);
            label3.TabIndex = 56;
            label3.Text = "Jumlah Pinjam";
            // 
            // jumlahBuku
            // 
            jumlahBuku.Enabled = false;
            jumlahBuku.Location = new Point(218, 514);
            jumlahBuku.Name = "jumlahBuku";
            jumlahBuku.Size = new Size(224, 27);
            jumlahBuku.TabIndex = 57;
            // 
            // nisSiswa
            // 
            nisSiswa.Enabled = false;
            nisSiswa.FormattingEnabled = true;
            nisSiswa.Location = new Point(220, 572);
            nisSiswa.Name = "nisSiswa";
            nisSiswa.Size = new Size(223, 28);
            nisSiswa.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 572);
            label4.Name = "label4";
            label4.Size = new Size(49, 31);
            label4.TabIndex = 59;
            label4.Text = "NIS";
            // 
            // namaSiswa
            // 
            namaSiswa.Enabled = false;
            namaSiswa.Location = new Point(219, 606);
            namaSiswa.Name = "namaSiswa";
            namaSiswa.Size = new Size(223, 27);
            namaSiswa.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(391, 371);
            label5.Name = "label5";
            label5.Size = new Size(183, 31);
            label5.TabIndex = 61;
            label5.Text = "Tanggal Kembali";
            // 
            // tanggalKembali
            // 
            tanggalKembali.Location = new Point(580, 375);
            tanggalKembali.Name = "tanggalKembali";
            tanggalKembali.Size = new Size(250, 27);
            tanggalKembali.TabIndex = 62;
            // 
            // PengembalianBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tanggalKembali);
            Controls.Add(label5);
            Controls.Add(namaSiswa);
            Controls.Add(label4);
            Controls.Add(nisSiswa);
            Controls.Add(jumlahBuku);
            Controls.Add(label3);
            Controls.Add(judulBuku);
            Controls.Add(label2);
            Controls.Add(idBuku);
            Controls.Add(label1);
            Controls.Add(idPeminjaman);
            Controls.Add(dataGridView1);
            Controls.Add(bDelete);
            Controls.Add(bInsert);
            Controls.Add(search);
            Controls.Add(label8);
            Name = "PengembalianBuku";
            Size = new Size(959, 690);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jumlahBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search;
        private Label label8;
        private Button bDelete;
        private Button bEdit;
        private Button bInsert;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private ComboBox idPeminjaman;
        private Label label1;
        private ComboBox idBuku;
        private Label label2;
        private TextBox judulBuku;
        private Label label3;
        private NumericUpDown jumlahBuku;
        private ComboBox nisSiswa;
        private Label label4;
        private TextBox namaSiswa;
        private Label label5;
        private DateTimePicker tanggalKembali;
    }
}

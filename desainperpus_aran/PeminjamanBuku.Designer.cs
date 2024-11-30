namespace desainperpus_aran
{
    partial class PeminjamanBuku
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
            namaSiswa = new TextBox();
            label1 = new Label();
            nisSiswa = new ComboBox();
            idBuku = new ComboBox();
            judulBuku = new TextBox();
            label2 = new Label();
            bDelete = new Button();
            bEdit = new Button();
            label3 = new Label();
            jumlahBuku = new NumericUpDown();
            bSavePeminjaman = new Button();
            panel1 = new Panel();
            search = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)jumlahBuku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // namaSiswa
            // 
            namaSiswa.Enabled = false;
            namaSiswa.Location = new Point(246, 60);
            namaSiswa.Name = "namaSiswa";
            namaSiswa.Size = new Size(197, 27);
            namaSiswa.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 7;
            label1.Text = "NIS";
            // 
            // nisSiswa
            // 
            nisSiswa.FormattingEnabled = true;
            nisSiswa.Location = new Point(246, 16);
            nisSiswa.Name = "nisSiswa";
            nisSiswa.Size = new Size(197, 28);
            nisSiswa.TabIndex = 9;
            nisSiswa.SelectedIndexChanged += nisSiswa_SelectedIndexChanged;
            // 
            // idBuku
            // 
            idBuku.FormattingEnabled = true;
            idBuku.Location = new Point(246, 102);
            idBuku.Name = "idBuku";
            idBuku.Size = new Size(183, 28);
            idBuku.TabIndex = 12;
            idBuku.SelectedIndexChanged += idBuku_SelectedIndexChanged;
            // 
            // judulBuku
            // 
            judulBuku.Enabled = false;
            judulBuku.Location = new Point(246, 146);
            judulBuku.Name = "judulBuku";
            judulBuku.Size = new Size(312, 27);
            judulBuku.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(141, 98);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 10;
            label2.Text = "id Buku";
            // 
            // bDelete
            // 
            bDelete.BackColor = Color.SandyBrown;
            bDelete.FlatAppearance.BorderSize = 0;
            bDelete.FlatStyle = FlatStyle.Flat;
            bDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bDelete.Location = new Point(373, 243);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(185, 44);
            bDelete.TabIndex = 27;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = false;
            bDelete.Click += bDelete_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.SandyBrown;
            bEdit.FlatAppearance.BorderSize = 0;
            bEdit.FlatStyle = FlatStyle.Flat;
            bEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bEdit.Location = new Point(141, 243);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(210, 44);
            bEdit.TabIndex = 26;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 188);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 28;
            label3.Text = "Jumlah";
            // 
            // jumlahBuku
            // 
            jumlahBuku.Location = new Point(246, 188);
            jumlahBuku.Name = "jumlahBuku";
            jumlahBuku.Size = new Size(67, 27);
            jumlahBuku.TabIndex = 29;
            // 
            // bSavePeminjaman
            // 
            bSavePeminjaman.BackColor = Color.SandyBrown;
            bSavePeminjaman.FlatAppearance.BorderSize = 0;
            bSavePeminjaman.FlatStyle = FlatStyle.Flat;
            bSavePeminjaman.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bSavePeminjaman.Location = new Point(141, 303);
            bSavePeminjaman.Name = "bSavePeminjaman";
            bSavePeminjaman.Size = new Size(690, 53);
            bSavePeminjaman.TabIndex = 30;
            bSavePeminjaman.Text = "Save Peminjaman";
            bSavePeminjaman.UseVisualStyleBackColor = false;
            bSavePeminjaman.Click += bSavePeminjaman_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(587, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 271);
            panel1.TabIndex = 31;
            // 
            // search
            // 
            search.Location = new Point(160, 370);
            search.Name = "search";
            search.Size = new Size(205, 27);
            search.TabIndex = 34;
            search.TextChanged += search_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(67, 366);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 33;
            label8.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 424);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(852, 200);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // PeminjamanBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(bSavePeminjaman);
            Controls.Add(jumlahBuku);
            Controls.Add(label3);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(idBuku);
            Controls.Add(judulBuku);
            Controls.Add(label2);
            Controls.Add(nisSiswa);
            Controls.Add(namaSiswa);
            Controls.Add(label1);
            Name = "PeminjamanBuku";
            Size = new Size(959, 655);
            ((System.ComponentModel.ISupportInitialize)jumlahBuku).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox namaSiswa;
        private Label label1;
        private ComboBox nisSiswa;
        private ComboBox idBuku;
        private TextBox judulBuku;
        private Label label2;
        private Button bDelete;
        private Button bEdit;
        private Label label3;
        private NumericUpDown jumlahBuku;
        private Button bSavePeminjaman;
        private Panel panel1;
        private TextBox search;
        private Label label8;
        private DataGridView dataGridView1;
    }
}

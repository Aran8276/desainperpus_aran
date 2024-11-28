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
            textBox7 = new TextBox();
            label8 = new Label();
            bDelete = new Button();
            bInsert = new Button();
            jumlahBuku = new NumericUpDown();
            label3 = new Label();
            idBuku = new ComboBox();
            judulBuku = new TextBox();
            label2 = new Label();
            nisSiswa = new ComboBox();
            namaSiswa = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            idPeminjaman = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)jumlahBuku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.Location = new Point(176, 26);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(205, 27);
            textBox7.TabIndex = 37;
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
            bDelete.Location = new Point(233, 230);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(112, 44);
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
            bInsert.Location = new Point(83, 230);
            bInsert.Name = "bInsert";
            bInsert.Size = new Size(112, 44);
            bInsert.TabIndex = 38;
            bInsert.Text = "Insert";
            bInsert.UseVisualStyleBackColor = false;
            bInsert.Click += bInsert_Click;
            // 
            // jumlahBuku
            // 
            jumlahBuku.Enabled = false;
            jumlahBuku.Location = new Point(233, 497);
            jumlahBuku.Name = "jumlahBuku";
            jumlahBuku.Size = new Size(67, 27);
            jumlahBuku.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 497);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 44;
            label3.Text = "Jumlah";
            // 
            // idBuku
            // 
            idBuku.Enabled = false;
            idBuku.FormattingEnabled = true;
            idBuku.Location = new Point(233, 411);
            idBuku.Name = "idBuku";
            idBuku.Size = new Size(183, 28);
            idBuku.TabIndex = 43;
            // 
            // judulBuku
            // 
            judulBuku.Enabled = false;
            judulBuku.Location = new Point(233, 455);
            judulBuku.Name = "judulBuku";
            judulBuku.Size = new Size(312, 27);
            judulBuku.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 407);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 41;
            label2.Text = "id Buku";
            // 
            // nisSiswa
            // 
            nisSiswa.Enabled = false;
            nisSiswa.FormattingEnabled = true;
            nisSiswa.Location = new Point(233, 553);
            nisSiswa.Name = "nisSiswa";
            nisSiswa.Size = new Size(197, 28);
            nisSiswa.TabIndex = 48;
            // 
            // namaSiswa
            // 
            namaSiswa.Enabled = false;
            namaSiswa.Location = new Point(233, 597);
            namaSiswa.Name = "namaSiswa";
            namaSiswa.Size = new Size(197, 27);
            namaSiswa.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 549);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 46;
            label1.Text = "NIS";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(564, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 271);
            panel1.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 140);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idPeminjaman
            // 
            idPeminjaman.FormattingEnabled = true;
            idPeminjaman.Location = new Point(233, 309);
            idPeminjaman.Name = "idPeminjaman";
            idPeminjaman.Size = new Size(183, 28);
            idPeminjaman.TabIndex = 51;
            idPeminjaman.SelectedIndexChanged += idPeminjaman_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 309);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 52;
            label4.Text = "id Peminjaman";
            // 
            // PengembalianBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(idPeminjaman);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(nisSiswa);
            Controls.Add(namaSiswa);
            Controls.Add(label1);
            Controls.Add(jumlahBuku);
            Controls.Add(label3);
            Controls.Add(idBuku);
            Controls.Add(judulBuku);
            Controls.Add(label2);
            Controls.Add(bDelete);
            Controls.Add(bInsert);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Name = "PengembalianBuku";
            Size = new Size(959, 668);
            ((System.ComponentModel.ISupportInitialize)jumlahBuku).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox7;
        private Label label8;
        private Button bDelete;
        private Button bInsert;
        private NumericUpDown jumlahBuku;
        private Label label3;
        private ComboBox idBuku;
        private TextBox judulBuku;
        private Label label2;
        private ComboBox nisSiswa;
        private TextBox namaSiswa;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ComboBox idPeminjaman;
        private Label label4;
    }
}

namespace desainperpus_aran
{
    partial class MasterBuku
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
            judul = new TextBox();
            label1 = new Label();
            pengarang = new TextBox();
            label2 = new Label();
            penerbit = new TextBox();
            label3 = new Label();
            tahun = new TextBox();
            label4 = new Label();
            stok = new TextBox();
            label5 = new Label();
            search = new TextBox();
            label8 = new Label();
            bDelete = new Button();
            bEdit = new Button();
            bInsert = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // judul
            // 
            judul.Location = new Point(271, 30);
            judul.Name = "judul";
            judul.Size = new Size(237, 27);
            judul.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 26);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 5;
            label1.Text = "Judul Buku";
            // 
            // pengarang
            // 
            pengarang.Location = new Point(271, 82);
            pengarang.Name = "pengarang";
            pengarang.Size = new Size(196, 27);
            pengarang.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 78);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 7;
            label2.Text = "Pengarang";
            // 
            // penerbit
            // 
            penerbit.Location = new Point(271, 131);
            penerbit.Name = "penerbit";
            penerbit.Size = new Size(196, 27);
            penerbit.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 127);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 9;
            label3.Text = "Penerbit";
            // 
            // tahun
            // 
            tahun.Location = new Point(728, 34);
            tahun.Name = "tahun";
            tahun.Size = new Size(125, 27);
            tahun.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(568, 30);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 11;
            label4.Text = "Tahun Terbit";
            // 
            // stok
            // 
            stok.Location = new Point(728, 86);
            stok.Name = "stok";
            stok.Size = new Size(125, 27);
            stok.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(568, 82);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 13;
            label5.Text = "Stok";
            // 
            // search
            // 
            search.Location = new Point(178, 295);
            search.Name = "search";
            search.Size = new Size(205, 27);
            search.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(85, 291);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 25;
            label8.Text = "Search";
            // 
            // bDelete
            // 
            bDelete.BackColor = Color.SandyBrown;
            bDelete.FlatAppearance.BorderSize = 0;
            bDelete.FlatStyle = FlatStyle.Flat;
            bDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bDelete.Location = new Point(604, 202);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(172, 53);
            bDelete.TabIndex = 24;
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
            bEdit.Location = new Point(396, 202);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(172, 53);
            bEdit.TabIndex = 23;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bInsert
            // 
            bInsert.BackColor = Color.SandyBrown;
            bInsert.FlatAppearance.BorderSize = 0;
            bInsert.FlatStyle = FlatStyle.Flat;
            bInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bInsert.Location = new Point(190, 202);
            bInsert.Name = "bInsert";
            bInsert.Size = new Size(172, 53);
            bInsert.TabIndex = 22;
            bInsert.Text = "Insert";
            bInsert.UseVisualStyleBackColor = false;
            bInsert.Click += bInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(816, 193);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // MasterBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(label8);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bInsert);
            Controls.Add(stok);
            Controls.Add(label5);
            Controls.Add(tahun);
            Controls.Add(label4);
            Controls.Add(penerbit);
            Controls.Add(label3);
            Controls.Add(pengarang);
            Controls.Add(label2);
            Controls.Add(judul);
            Controls.Add(label1);
            Name = "MasterBuku";
            Size = new Size(959, 569);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox judul;
        private Label label1;
        private TextBox pengarang;
        private Label label2;
        private TextBox penerbit;
        private Label label3;
        private TextBox tahun;
        private Label label4;
        private TextBox stok;
        private Label label5;
        private TextBox search;
        private Label label8;
        private Button bDelete;
        private Button bEdit;
        private Button bInsert;
        private DataGridView dataGridView1;
    }
}

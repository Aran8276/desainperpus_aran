namespace desainperpus_aran
{
    partial class MasterSiswa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nis = new TextBox();
            nama = new TextBox();
            alamat = new TextBox();
            kelas = new ComboBox();
            username = new TextBox();
            notelp = new TextBox();
            label5 = new Label();
            label6 = new Label();
            password = new TextBox();
            label7 = new Label();
            bInsert = new Button();
            bEdit = new Button();
            bDelete = new Button();
            search = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            email = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 0;
            label1.Text = "NIS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 67);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 116);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 2;
            label3.Text = "Kelas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 165);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 3;
            label4.Text = "Alamat";
            // 
            // nis
            // 
            nis.Location = new Point(202, 22);
            nis.Name = "nis";
            nis.Size = new Size(125, 27);
            nis.TabIndex = 4;
            // 
            // nama
            // 
            nama.Location = new Point(202, 71);
            nama.Name = "nama";
            nama.Size = new Size(239, 27);
            nama.TabIndex = 5;
            // 
            // alamat
            // 
            alamat.Location = new Point(202, 169);
            alamat.Multiline = true;
            alamat.Name = "alamat";
            alamat.Size = new Size(168, 66);
            alamat.TabIndex = 7;
            // 
            // kelas
            // 
            kelas.FormattingEnabled = true;
            kelas.Items.AddRange(new object[] { "XI RPL 1", "XI RPL 2", "XI RPL 3" });
            kelas.Location = new Point(202, 120);
            kelas.Name = "kelas";
            kelas.Size = new Size(151, 28);
            kelas.TabIndex = 8;
            // 
            // username
            // 
            username.Location = new Point(628, 119);
            username.Name = "username";
            username.Size = new Size(140, 27);
            username.TabIndex = 12;
            // 
            // notelp
            // 
            notelp.Location = new Point(628, 22);
            notelp.Name = "notelp";
            notelp.Size = new Size(160, 27);
            notelp.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(487, 115);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 10;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(487, 18);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 9;
            label6.Text = "No Telepon";
            // 
            // password
            // 
            password.Location = new Point(628, 169);
            password.Name = "password";
            password.Size = new Size(140, 27);
            password.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(487, 165);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 13;
            label7.Text = "Password";
            // 
            // bInsert
            // 
            bInsert.BackColor = Color.SandyBrown;
            bInsert.FlatAppearance.BorderSize = 0;
            bInsert.FlatStyle = FlatStyle.Flat;
            bInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bInsert.Location = new Point(202, 272);
            bInsert.Name = "bInsert";
            bInsert.Size = new Size(172, 53);
            bInsert.TabIndex = 16;
            bInsert.Text = "Insert";
            bInsert.UseVisualStyleBackColor = false;
            bInsert.Click += bInsert_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.SandyBrown;
            bEdit.FlatAppearance.BorderSize = 0;
            bEdit.FlatStyle = FlatStyle.Flat;
            bEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bEdit.Location = new Point(408, 272);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(172, 53);
            bEdit.TabIndex = 17;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bDelete
            // 
            bDelete.BackColor = Color.SandyBrown;
            bDelete.FlatAppearance.BorderSize = 0;
            bDelete.FlatStyle = FlatStyle.Flat;
            bDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bDelete.Location = new Point(616, 272);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(172, 53);
            bDelete.TabIndex = 18;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = false;
            bDelete.Click += bDelete_Click;
            // 
            // search
            // 
            search.Location = new Point(190, 365);
            search.Name = "search";
            search.Size = new Size(205, 27);
            search.TabIndex = 20;
            search.TextChanged += search_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(97, 361);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 19;
            label8.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 411);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 221);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // email
            // 
            email.Location = new Point(628, 75);
            email.Name = "email";
            email.Size = new Size(160, 27);
            email.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(487, 71);
            label9.Name = "label9";
            label9.Size = new Size(59, 28);
            label9.TabIndex = 22;
            label9.Text = "Email";
            // 
            // MasterSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(email);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(label8);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bInsert);
            Controls.Add(password);
            Controls.Add(label7);
            Controls.Add(username);
            Controls.Add(notelp);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(kelas);
            Controls.Add(alamat);
            Controls.Add(nama);
            Controls.Add(nis);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MasterSiswa";
            Size = new Size(959, 651);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nis;
        private TextBox nama;
        private TextBox alamat;
        private ComboBox kelas;
        private TextBox username;
        private TextBox notelp;
        private Label label5;
        private Label label6;
        private TextBox password;
        private Label label7;
        private Button bInsert;
        private Button bEdit;
        private Button bDelete;
        private TextBox search;
        private Label label8;
        private DataGridView dataGridView1;
        private TextBox email;
        private Label label9;
    }
}

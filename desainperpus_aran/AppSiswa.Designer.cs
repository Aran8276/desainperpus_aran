namespace desainperpus_aran
{
    partial class AppSiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSiswa));
            splitContainer1 = new SplitContainer();
            bLogOut = new Button();
            bRiwayatPengambilan = new Button();
            bRiwayatPeminjaman = new Button();
            bCariBuku = new Button();
            pictureBox1 = new PictureBox();
            cariBuku1 = new CariBuku();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.SandyBrown;
            splitContainer1.Panel1.Controls.Add(bLogOut);
            splitContainer1.Panel1.Controls.Add(bRiwayatPengambilan);
            splitContainer1.Panel1.Controls.Add(bRiwayatPeminjaman);
            splitContainer1.Panel1.Controls.Add(bCariBuku);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LemonChiffon;
            splitContainer1.Panel2.Controls.Add(cariBuku1);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1254, 805);
            splitContainer1.SplitterDistance = 348;
            splitContainer1.TabIndex = 1;
            // 
            // bLogOut
            // 
            bLogOut.FlatAppearance.BorderSize = 0;
            bLogOut.FlatStyle = FlatStyle.Flat;
            bLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bLogOut.Location = new Point(12, 328);
            bLogOut.Name = "bLogOut";
            bLogOut.Size = new Size(294, 54);
            bLogOut.TabIndex = 6;
            bLogOut.Text = "Log Out";
            bLogOut.UseVisualStyleBackColor = true;
            bLogOut.Click += bLogOut_Click;
            // 
            // bRiwayatPengambilan
            // 
            bRiwayatPengambilan.FlatAppearance.BorderSize = 0;
            bRiwayatPengambilan.FlatStyle = FlatStyle.Flat;
            bRiwayatPengambilan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bRiwayatPengambilan.Location = new Point(3, 268);
            bRiwayatPengambilan.Name = "bRiwayatPengambilan";
            bRiwayatPengambilan.Size = new Size(294, 54);
            bRiwayatPengambilan.TabIndex = 3;
            bRiwayatPengambilan.Text = "Riwayat Pengambilan";
            bRiwayatPengambilan.UseVisualStyleBackColor = true;
            // 
            // bRiwayatPeminjaman
            // 
            bRiwayatPeminjaman.FlatAppearance.BorderSize = 0;
            bRiwayatPeminjaman.FlatStyle = FlatStyle.Flat;
            bRiwayatPeminjaman.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bRiwayatPeminjaman.Location = new Point(12, 208);
            bRiwayatPeminjaman.Name = "bRiwayatPeminjaman";
            bRiwayatPeminjaman.Size = new Size(294, 54);
            bRiwayatPeminjaman.TabIndex = 2;
            bRiwayatPeminjaman.Text = "Riwayat Peminjaman";
            bRiwayatPeminjaman.UseVisualStyleBackColor = true;
            // 
            // bCariBuku
            // 
            bCariBuku.FlatAppearance.BorderSize = 0;
            bCariBuku.FlatStyle = FlatStyle.Flat;
            bCariBuku.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCariBuku.Location = new Point(12, 148);
            bCariBuku.Name = "bCariBuku";
            bCariBuku.Size = new Size(294, 54);
            bCariBuku.TabIndex = 1;
            bCariBuku.Text = "Cari Buku";
            bCariBuku.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cariBuku1
            // 
            cariBuku1.Location = new Point(-2, 104);
            cariBuku1.Name = "cariBuku1";
            cariBuku1.Size = new Size(904, 675);
            cariBuku1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-46, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 64);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 18);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome Siswa";
            label1.Click += label1_Click;
            // 
            // AppSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 805);
            Controls.Add(splitContainer1);
            Name = "AppSiswa";
            Text = "AppSiswa";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button bLogOut;
        private Button bRiwayatPengambilan;
        private Button bRiwayatPeminjaman;
        private Button bCariBuku;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private CariBuku cariBuku1;
    }
}
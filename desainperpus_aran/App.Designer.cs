namespace desainperpus_aran
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            splitContainer1 = new SplitContainer();
            bLogOut = new Button();
            bPengembalianBuku = new Button();
            bPeminjamanBuku = new Button();
            bMasterBuku = new Button();
            bMasterSiswa = new Button();
            bDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            dashboard1 = new Dashboard();
            peminjamanBuku1 = new PeminjamanBuku();
            masterBuku1 = new MasterBuku();
            masterSiswa1 = new MasterSiswa();
            pengembalianBuku1 = new PengembalianBuku();
            refreshButton = new Button();
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
            splitContainer1.Panel1.Controls.Add(refreshButton);
            splitContainer1.Panel1.Controls.Add(bLogOut);
            splitContainer1.Panel1.Controls.Add(bPengembalianBuku);
            splitContainer1.Panel1.Controls.Add(bPeminjamanBuku);
            splitContainer1.Panel1.Controls.Add(bMasterBuku);
            splitContainer1.Panel1.Controls.Add(bMasterSiswa);
            splitContainer1.Panel1.Controls.Add(bDashboard);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LemonChiffon;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(dashboard1);
            splitContainer1.Panel2.Controls.Add(peminjamanBuku1);
            splitContainer1.Panel2.Controls.Add(masterBuku1);
            splitContainer1.Panel2.Controls.Add(masterSiswa1);
            splitContainer1.Panel2.Controls.Add(pengembalianBuku1);
            splitContainer1.Size = new Size(1262, 793);
            splitContainer1.SplitterDistance = 351;
            splitContainer1.TabIndex = 0;
            // 
            // bLogOut
            // 
            bLogOut.FlatAppearance.BorderSize = 0;
            bLogOut.FlatStyle = FlatStyle.Flat;
            bLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bLogOut.Location = new Point(12, 448);
            bLogOut.Name = "bLogOut";
            bLogOut.Size = new Size(294, 54);
            bLogOut.TabIndex = 6;
            bLogOut.Text = "Log Out";
            bLogOut.UseVisualStyleBackColor = true;
            bLogOut.Click += bLogOut_Click;
            // 
            // bPengembalianBuku
            // 
            bPengembalianBuku.FlatAppearance.BorderSize = 0;
            bPengembalianBuku.FlatStyle = FlatStyle.Flat;
            bPengembalianBuku.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bPengembalianBuku.Location = new Point(12, 388);
            bPengembalianBuku.Name = "bPengembalianBuku";
            bPengembalianBuku.Size = new Size(294, 54);
            bPengembalianBuku.TabIndex = 5;
            bPengembalianBuku.Text = "Pengembalian Buku";
            bPengembalianBuku.UseVisualStyleBackColor = true;
            bPengembalianBuku.Click += bPengembalianBuku_Click;
            // 
            // bPeminjamanBuku
            // 
            bPeminjamanBuku.FlatAppearance.BorderSize = 0;
            bPeminjamanBuku.FlatStyle = FlatStyle.Flat;
            bPeminjamanBuku.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bPeminjamanBuku.Location = new Point(12, 328);
            bPeminjamanBuku.Name = "bPeminjamanBuku";
            bPeminjamanBuku.Size = new Size(294, 54);
            bPeminjamanBuku.TabIndex = 4;
            bPeminjamanBuku.Text = "Peminjaman Buku";
            bPeminjamanBuku.UseVisualStyleBackColor = true;
            bPeminjamanBuku.Click += bPeminjamanBuku_Click;
            // 
            // bMasterBuku
            // 
            bMasterBuku.FlatAppearance.BorderSize = 0;
            bMasterBuku.FlatStyle = FlatStyle.Flat;
            bMasterBuku.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bMasterBuku.Location = new Point(12, 268);
            bMasterBuku.Name = "bMasterBuku";
            bMasterBuku.Size = new Size(294, 54);
            bMasterBuku.TabIndex = 3;
            bMasterBuku.Text = "Master Buku";
            bMasterBuku.UseVisualStyleBackColor = true;
            bMasterBuku.Click += bMasterBuku_Click;
            // 
            // bMasterSiswa
            // 
            bMasterSiswa.FlatAppearance.BorderSize = 0;
            bMasterSiswa.FlatStyle = FlatStyle.Flat;
            bMasterSiswa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bMasterSiswa.Location = new Point(12, 208);
            bMasterSiswa.Name = "bMasterSiswa";
            bMasterSiswa.Size = new Size(294, 54);
            bMasterSiswa.TabIndex = 2;
            bMasterSiswa.Text = "Master Siswa";
            bMasterSiswa.UseVisualStyleBackColor = true;
            bMasterSiswa.Click += bMasterSiswa_Click;
            // 
            // bDashboard
            // 
            bDashboard.FlatAppearance.BorderSize = 0;
            bDashboard.FlatStyle = FlatStyle.Flat;
            bDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDashboard.Location = new Point(12, 148);
            bDashboard.Name = "bDashboard";
            bDashboard.Size = new Size(294, 54);
            bDashboard.TabIndex = 1;
            bDashboard.Text = "Dashboard";
            bDashboard.UseVisualStyleBackColor = true;
            bDashboard.Click += bDashboard_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-46, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome Admin,";
            label1.Click += label1_Click;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(-2, 96);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(906, 697);
            dashboard1.TabIndex = 1;
            // 
            // peminjamanBuku1
            // 
            peminjamanBuku1.Location = new Point(1, 101);
            peminjamanBuku1.Name = "peminjamanBuku1";
            peminjamanBuku1.Size = new Size(903, 689);
            peminjamanBuku1.TabIndex = 4;
            // 
            // masterBuku1
            // 
            masterBuku1.Location = new Point(1, 101);
            masterBuku1.Name = "masterBuku1";
            masterBuku1.Size = new Size(903, 689);
            masterBuku1.TabIndex = 3;
            masterBuku1.Load += masterBuku1_Load;
            // 
            // masterSiswa1
            // 
            masterSiswa1.Location = new Point(3, 104);
            masterSiswa1.Name = "masterSiswa1";
            masterSiswa1.Size = new Size(904, 689);
            masterSiswa1.TabIndex = 2;
            // 
            // pengembalianBuku1
            // 
            pengembalianBuku1.Location = new Point(1, 99);
            pengembalianBuku1.Name = "pengembalianBuku1";
            pengembalianBuku1.Size = new Size(903, 691);
            pengembalianBuku1.TabIndex = 5;
            pengembalianBuku1.Load += pengembalianBuku1_Load;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.DodgerBlue;
            refreshButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = SystemColors.Control;
            refreshButton.Location = new Point(85, 697);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(181, 59);
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 793);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            FormClosing += App_FormClosing;
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
        private Button bPengembalianBuku;
        private Button bPeminjamanBuku;
        private Button bMasterBuku;
        private Button bMasterSiswa;
        private Button bDashboard;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Dashboard dashboard1;
        private MasterSiswa masterSiswa1;
        private MasterBuku masterBuku1;
        private PeminjamanBuku peminjamanBuku1;
        private PengembalianBuku pengembalianBuku1;
        private Button refreshButton;
    }
}
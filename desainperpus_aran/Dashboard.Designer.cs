namespace desainperpus_aran
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            labelBuku = new Label();
            panel2 = new Panel();
            label3 = new Label();
            labelSiswa = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(152, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(654, 269);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(labelBuku);
            panel3.Location = new Point(531, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 174);
            panel3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 126);
            label4.Name = "label4";
            label4.Size = new Size(187, 38);
            label4.TabIndex = 6;
            label4.Text = "Koleksi Buku";
            // 
            // labelBuku
            // 
            labelBuku.AutoSize = true;
            labelBuku.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuku.Location = new Point(78, 39);
            labelBuku.Name = "labelBuku";
            labelBuku.Size = new Size(64, 50);
            labelBuku.TabIndex = 5;
            labelBuku.Text = "20";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(labelSiswa);
            panel2.Location = new Point(193, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 174);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 126);
            label3.Name = "label3";
            label3.Size = new Size(90, 38);
            label3.TabIndex = 4;
            label3.Text = "Siswa";
            // 
            // labelSiswa
            // 
            labelSiswa.AutoSize = true;
            labelSiswa.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSiswa.Location = new Point(68, 39);
            labelSiswa.Name = "labelSiswa";
            labelSiswa.Size = new Size(85, 50);
            labelSiswa.TabIndex = 3;
            labelSiswa.Text = "200";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Dashboard";
            Size = new Size(959, 540);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label4;
        private Label labelBuku;
        private Panel panel2;
        private Label label3;
        private Label labelSiswa;
    }
}

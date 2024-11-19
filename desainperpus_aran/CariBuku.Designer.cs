namespace desainperpus_aran
{
    partial class CariBuku
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
            panel1 = new Panel();
            label1 = new Label();
            tCariBuku = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(29, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 354);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 1;
            label1.Text = "Cari Buku";
            // 
            // tCariBuku
            // 
            tCariBuku.Location = new Point(29, 80);
            tCariBuku.Name = "tCariBuku";
            tCariBuku.Size = new Size(258, 27);
            tCariBuku.TabIndex = 2;
            // 
            // CariBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tCariBuku);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CariBuku";
            Size = new Size(868, 540);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tCariBuku;
    }
}

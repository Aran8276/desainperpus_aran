namespace desainperpus_aran
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            bCancel = new Button();
            bLogin = new Button();
            tPassword = new TextBox();
            tUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
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
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LemonChiffon;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(993, 484);
            splitContainer1.SplitterDistance = 381;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(bCancel);
            panel1.Controls.Add(bLogin);
            panel1.Controls.Add(tPassword);
            panel1.Controls.Add(tUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(90, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 263);
            panel1.TabIndex = 1;
            // 
            // bCancel
            // 
            bCancel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            bCancel.Location = new Point(239, 179);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(119, 46);
            bCancel.TabIndex = 5;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // bLogin
            // 
            bLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            bLogin.Location = new Point(69, 179);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(123, 46);
            bLogin.TabIndex = 4;
            bLogin.Text = "Sign In";
            bLogin.UseVisualStyleBackColor = true;
            bLogin.Click += bLogin_Click;
            // 
            // tPassword
            // 
            tPassword.Location = new Point(173, 127);
            tPassword.Name = "tPassword";
            tPassword.Size = new Size(185, 27);
            tPassword.TabIndex = 3;
            // 
            // tUsername
            // 
            tUsername.Location = new Point(173, 55);
            tUsername.Name = "tUsername";
            tUsername.Size = new Size(185, 27);
            tUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 129);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 57);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 67);
            label1.Name = "label1";
            label1.Size = new Size(123, 39);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 484);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button bCancel;
        private Button bLogin;
        private TextBox tPassword;
        private TextBox tUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}

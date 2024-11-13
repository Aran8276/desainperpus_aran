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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            bDelete = new Button();
            bEdit = new Button();
            bInsert = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 6;
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
            // textBox2
            // 
            textBox2.Location = new Point(271, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 8;
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
            // textBox3
            // 
            textBox3.Location = new Point(271, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 27);
            textBox3.TabIndex = 10;
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
            // textBox4
            // 
            textBox4.Location = new Point(728, 34);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
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
            // textBox5
            // 
            textBox5.Location = new Point(728, 86);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 14;
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
            // textBox7
            // 
            textBox7.Location = new Point(178, 295);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(205, 27);
            textBox7.TabIndex = 26;
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(85, 341);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(788, 134);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // MasterBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bInsert);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MasterBuku";
            Size = new Size(959, 569);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox7;
        private Label label8;
        private Button bDelete;
        private Button bEdit;
        private Button bInsert;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

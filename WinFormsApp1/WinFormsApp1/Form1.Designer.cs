namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            txtPassWord = new TextBox();
            txtHienThi = new TextBox();
            btHienThi = new Button();
            btTiep = new Button();
            btDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập password";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(47, 76);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "hiển thị";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(172, 27);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(100, 23);
            txtPassWord.TabIndex = 2;
            txtPassWord.TextChanged += textBox1_TextChanged;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(172, 76);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(100, 23);
            txtHienThi.TabIndex = 3;
            txtHienThi.TextChanged += textBox2_TextChanged;
            // 
            // btHienThi
            // 
            btHienThi.Location = new Point(61, 150);
            btHienThi.Name = "btHienThi";
            btHienThi.Size = new Size(75, 23);
            btHienThi.TabIndex = 4;
            btHienThi.Text = "hiển thị";
            btHienThi.UseVisualStyleBackColor = true;
            btHienThi.Click += button1_Click;
            // 
            // btTiep
            // 
            btTiep.Location = new Point(172, 150);
            btTiep.Name = "btTiep";
            btTiep.Size = new Size(75, 23);
            btTiep.TabIndex = 5;
            btTiep.Text = "tiếp";
            btTiep.UseVisualStyleBackColor = true;
            btTiep.Click += button2_Click;
            // 
            // btDong
            // 
            btDong.Location = new Point(299, 150);
            btDong.Name = "btDong";
            btDong.Size = new Size(75, 23);
            btDong.TabIndex = 6;
            btDong.Text = "đóng";
            btDong.UseVisualStyleBackColor = true;
            btDong.Click += btDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btDong);
            Controls.Add(btTiep);
            Controls.Add(btHienThi);
            Controls.Add(txtHienThi);
            Controls.Add(txtPassWord);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPassWord;
        private TextBox txtHienThi;
        private Button btHienThi;
        private Button btTiep;
        private Button btDong;
    }
}

namespace bai3
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
            label2 = new Label();
            label3 = new Label();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnDong = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 59);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ và Họ Lót";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 83);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            label3.Click += label3_Click;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(158, 167);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(75, 23);
            btnHo.TabIndex = 3;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(316, 167);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(75, 23);
            btnTen.TabIndex = 4;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(464, 167);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(75, 23);
            btnHoTen.TabIndex = 5;
            btnHoTen.Text = "Họ Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(316, 242);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(138, 23);
            btnDong.TabIndex = 6;
            btnDong.Text = "Thoát Chương Trình";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(133, 51);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(300, 23);
            txtHo.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 192, 255);
            txtTen.Location = new Point(133, 83);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(300, 23);
            txtTen.TabIndex = 8;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.BackColor = Color.FromArgb(0, 0, 192);
            lblHoTen.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(133, 9);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(74, 33);
            lblHoTen.TabIndex = 9;
            lblHoTen.Text = "ddđ";
            lblHoTen.Click += lblHoTen_Click;
            lblHoTen.DoubleClick += lblHoTen_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoTen);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(btnDong);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnDong;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label lblHoTen;
    }
}

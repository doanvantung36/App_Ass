namespace App_Ass
{
    partial class Login
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
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            btn_Login = new Button();
            btn_DangKi = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(102, 71);
            txt_UserName.Margin = new Padding(3, 2, 3, 2);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.PlaceholderText = "Nhập User Name";
            txt_UserName.Size = new Size(376, 23);
            txt_UserName.TabIndex = 0;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(102, 115);
            txt_Password.Margin = new Padding(3, 2, 3, 2);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Nhập Password";
            txt_Password.Size = new Size(376, 23);
            txt_Password.TabIndex = 1;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Lime;
            btn_Login.Location = new Point(175, 158);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(248, 29);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_DangKi
            // 
            btn_DangKi.BackColor = SystemColors.MenuHighlight;
            btn_DangKi.Location = new Point(175, 203);
            btn_DangKi.Margin = new Padding(3, 2, 3, 2);
            btn_DangKi.Name = "btn_DangKi";
            btn_DangKi.Size = new Size(248, 29);
            btn_DangKi.TabIndex = 3;
            btn_DangKi.Text = "Đăng kí";
            btn_DangKi.UseVisualStyleBackColor = false;
            btn_DangKi.Click += btn_DangKi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 4;
            label1.Text = "Đăng Nhập";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 265);
            Controls.Add(label1);
            Controls.Add(btn_DangKi);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Button btn_Login;
        private Button btn_DangKi;
        private Label label1;
    }
}

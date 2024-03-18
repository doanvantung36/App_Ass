namespace App_Ass.View
{
    partial class DangKi
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
            label1 = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            cb_User = new ComboBox();
            btn_DangKi = new Button();
            btn_Thoat = new Button();
            txt_CofimPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(264, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng kí";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(91, 82);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "Nhập userName";
            txt_Username.Size = new Size(454, 23);
            txt_Username.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(91, 120);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Nhập Password";
            txt_Password.Size = new Size(454, 23);
            txt_Password.TabIndex = 2;
            // 
            // cb_User
            // 
            cb_User.FormattingEnabled = true;
            cb_User.Items.AddRange(new object[] { "Admin", "User" });
            cb_User.Location = new Point(91, 192);
            cb_User.Name = "cb_User";
            cb_User.Size = new Size(454, 23);
            cb_User.TabIndex = 3;
            // 
            // btn_DangKi
            // 
            btn_DangKi.BackColor = SystemColors.MenuHighlight;
            btn_DangKi.Location = new Point(199, 229);
            btn_DangKi.Margin = new Padding(3, 2, 3, 2);
            btn_DangKi.Name = "btn_DangKi";
            btn_DangKi.Size = new Size(248, 29);
            btn_DangKi.TabIndex = 4;
            btn_DangKi.Text = "Đăng kí";
            btn_DangKi.UseVisualStyleBackColor = false;
            btn_DangKi.Click += btn_DangKi_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.Red;
            btn_Thoat.ForeColor = Color.Transparent;
            btn_Thoat.Location = new Point(199, 262);
            btn_Thoat.Margin = new Padding(3, 2, 3, 2);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(248, 29);
            btn_Thoat.TabIndex = 5;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // txt_CofimPassword
            // 
            txt_CofimPassword.Location = new Point(91, 156);
            txt_CofimPassword.Name = "txt_CofimPassword";
            txt_CofimPassword.PlaceholderText = "Nhập lại Password";
            txt_CofimPassword.Size = new Size(454, 23);
            txt_CofimPassword.TabIndex = 6;
            // 
            // DangKi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 318);
            Controls.Add(txt_CofimPassword);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangKi);
            Controls.Add(cb_User);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(label1);
            Name = "DangKi";
            Text = "DangKi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private ComboBox cb_User;
        private Button btn_DangKi;
        private Button btn_Thoat;
        private TextBox txt_CofimPassword;
    }
}
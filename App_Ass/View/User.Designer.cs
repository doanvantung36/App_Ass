namespace App_Ass.View
{
    partial class User
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txt_Id = new TextBox();
            txt_UserName = new TextBox();
            txt_employeename = new TextBox();
            id = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Password = new TextBox();
            btn_Them = new Button();
            btn_Xoa = new Button();
            btn_sua = new Button();
            btn_Dangxuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(515, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 1;
            label1.Text = "Quản lý người dùng";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(532, 65);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(257, 23);
            txt_Id.TabIndex = 2;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(532, 160);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(257, 23);
            txt_UserName.TabIndex = 4;
            // 
            // txt_employeename
            // 
            txt_employeename.Location = new Point(532, 111);
            txt_employeename.Name = "txt_employeename";
            txt_employeename.Size = new Size(257, 23);
            txt_employeename.TabIndex = 5;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(534, 45);
            id.Name = "id";
            id.Size = new Size(18, 15);
            id.TabIndex = 7;
            id.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 93);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 8;
            label3.Text = "Tên người dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(534, 143);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 9;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 194);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(532, 212);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(257, 23);
            txt_Password.TabIndex = 11;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(532, 278);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(257, 23);
            btn_Them.TabIndex = 12;
            btn_Them.Text = "Add";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(532, 336);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(257, 23);
            btn_Xoa.TabIndex = 13;
            btn_Xoa.Text = "Delete";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(532, 307);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(257, 23);
            btn_sua.TabIndex = 14;
            btn_sua.Text = "Update";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_Dangxuat
            // 
            btn_Dangxuat.Location = new Point(610, 415);
            btn_Dangxuat.Name = "btn_Dangxuat";
            btn_Dangxuat.Size = new Size(117, 23);
            btn_Dangxuat.TabIndex = 15;
            btn_Dangxuat.Text = "Đăng xuất";
            btn_Dangxuat.UseVisualStyleBackColor = true;
            btn_Dangxuat.Click += btn_Dangxuat_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 450);
            Controls.Add(btn_Dangxuat);
            Controls.Add(btn_sua);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(txt_Password);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(id);
            Controls.Add(txt_employeename);
            Controls.Add(txt_UserName);
            Controls.Add(txt_Id);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "User";
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_Id;
        private TextBox txt_UserName;
        private TextBox txt_employeename;
        private Label id;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Password;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button btn_sua;
        private Button btn_Dangxuat;
    }
}
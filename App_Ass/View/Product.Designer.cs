namespace App_Ass.View
{
    partial class Product
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_sua = new Button();
            btn_Xoa = new Button();
            btn_Them = new Button();
            button1 = new Button();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(781, 282);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ID";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(410, 5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Số lượng";
            textBox2.Size = new Size(208, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 42);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Tên sản phẩm";
            textBox3.Size = new Size(208, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(410, 42);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Loại sản phẩm";
            textBox4.Size = new Size(208, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(91, 80);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Size";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(410, 80);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Người thêm sản phẩm";
            textBox6.Size = new Size(208, 23);
            textBox6.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 8);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 45);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 8;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 88);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 9;
            label3.Text = "Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 13);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 45);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 11;
            label5.Text = "Loại sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 83);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 12;
            label6.Text = "Người thêm";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(7, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 112);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_sua);
            panel2.Controls.Add(btn_Xoa);
            panel2.Controls.Add(btn_Them);
            panel2.Location = new Point(643, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 114);
            panel2.TabIndex = 14;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(14, 45);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(116, 23);
            btn_sua.TabIndex = 17;
            btn_sua.Text = "Update";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(14, 74);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(116, 23);
            btn_Xoa.TabIndex = 16;
            btn_Xoa.Text = "Delete";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(14, 16);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(116, 23);
            btn_Them.TabIndex = 15;
            btn_Them.Text = "Add";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(670, 127);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 19;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(7, 127);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Nhập ID hoặc mã sản phẩm";
            textBox7.Size = new Size(627, 23);
            textBox7.TabIndex = 18;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Product";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Button btn_sua;
        private Button btn_Xoa;
        private Button btn_Them;
        private Button button1;
        private TextBox textBox7;
    }
}
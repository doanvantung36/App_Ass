namespace App_Ass.View
{
    partial class Cart
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
            dataGioHang = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGioHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGioHang
            // 
            dataGioHang.BackgroundColor = SystemColors.ButtonHighlight;
            dataGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGioHang.Location = new Point(6, 24);
            dataGioHang.Name = "dataGioHang";
            dataGioHang.RowTemplate.Height = 25;
            dataGioHang.Size = new Size(353, 414);
            dataGioHang.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(386, 53);
            button1.Name = "button1";
            button1.Size = new Size(222, 29);
            button1.TabIndex = 1;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EMS", "ViettelPost", "Giao Hàng Nhanh", "Shopee Express", "NinjaVan" });
            comboBox1.Location = new Point(386, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 23);
            comboBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(249, 314);
            dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(386, 88);
            button2.Name = "button2";
            button2.Size = new Size(222, 29);
            button2.TabIndex = 4;
            button2.Text = "Hủy đơn";
            button2.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGioHang);
            Name = "Cart";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dataGioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGioHang;
        private Button button1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}
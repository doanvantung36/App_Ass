using App_Ass.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ass.View
{
    public partial class DangKi : Form
    {
        private DangkiController dangkiController;
        public DangKi()
        {
            InitializeComponent();
            dangkiController = new DangkiController();
        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string confirmPassword = txt_CofimPassword.Text;
            string role = cb_User.SelectedItem.ToString(); // Lấy vai trò từ ComboBox

            // Thực hiện đăng kí người dùng
            string result = dangkiController.RegisterUser(username, password, confirmPassword, role);
            if (result == null)
            {
                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Sau khi đăng kí thành công, bạn có thể thực hiện các hành động khác ở đây
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Nếu đăng kí không thành công, hiển thị thông báo lỗi
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            // Đóng form đăng kí khi người dùng nhấp vào nút "Thoát"
            this.Close();
        }
    }
}

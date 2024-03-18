using App_Ass.Controller;
using App_Ass.View;

namespace App_Ass
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;

            // Kiểm tra thông tin đăng nhập ở đây (sử dụng LoginController)
            LoginController loginController = new LoginController();
            string role = loginController.GetRole(username, password); // Lấy vai trò của người dùng

            if (role == "admin")
            {
                // Đăng nhập thành công với vai trò admin, ẩn form đăng nhập và hiển thị form User
                this.Hide();
                User userForm = new User();
                userForm.Show();
            }
            else if (role == "user")
            {
                // Đăng nhập thành công với vai trò user, ẩn form đăng nhập và hiển thị form Product
                this.Hide();
                Product productForm = new Product();
                productForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!");
            }
        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            // Đóng form đăng nhập và hiển thị form đăng kí
            this.Hide();
            DangKi registrationForm = new DangKi();
            registrationForm.Show();
        }
    }
}

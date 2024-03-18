using App_Ass.Model;

namespace App_Ass.Controller
{
    internal class DangkiController
    {
        private readonly DbContext dbContext;

        public DangkiController()
        {
            dbContext = new DbContext();
        }

        public string RegisterUser(string username, string password, string confirmPassword, string role)
        {
            // Kiểm tra xác nhận lại mật khẩu
            if (password != confirmPassword)
            {
                return "Mật khẩu và xác nhận mật khẩu không khớp.";
            }

            // Kiểm tra xem người dùng đã tồn tại trong cơ sở dữ liệu chưa
            if (IsUserExists(username))
            {
                return "Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.";
            }

            // Thực hiện thêm người dùng mới vào cơ sở dữ liệu
            string query = $"INSERT INTO Users (username, password, role) VALUES ('{username}', '{password}', '{role}')";
            int rowsAffected = dbContext.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                return null; // Trả về null nếu đăng kí thành công
            }
            else
            {
                return "Đã xảy ra lỗi khi đăng kí người dùng. Vui lòng thử lại sau."; // Trả về thông báo lỗi nếu có lỗi khi thêm người dùng vào cơ sở dữ liệu
            }
        }

        private bool IsUserExists(string username)
        {
            // Thực hiện truy vấn để kiểm tra xem người dùng đã tồn tại trong cơ sở dữ liệu hay không
            string query = $"SELECT COUNT(*) FROM Users WHERE username = '{username}'";
            int count = Convert.ToInt32(dbContext.ExecuteQuery(query).Rows[0][0]);
            return count > 0;
        }
    }
}

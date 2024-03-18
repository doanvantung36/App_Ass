using System;
using App_Ass.Model;

namespace App_Ass.Controller
{
    internal class LoginController
    {
        private readonly DbContext dbContext;

        public LoginController()
        {
            dbContext = new DbContext();
        }

        public bool AuthenticateUser(string username, string password)
        {
            // Thực hiện truy vấn để kiểm tra người dùng từ cơ sở dữ liệu
            string query = $"SELECT COUNT(*) FROM Users WHERE username = '{username}' AND password = '{password}'";

            // Thực hiện truy vấn và kiểm tra kết quả
            int count = Convert.ToInt32(dbContext.ExecuteQuery(query).Rows[0][0]);
            return count > 0;
        }

            public string GetRole(string username, string password)
            {
                // Thực hiện truy vấn để lấy vai trò của người dùng từ cơ sở dữ liệu
                string query = $"SELECT role FROM Users WHERE username = '{username}' AND password = '{password}'";

                // Thực hiện truy vấn và trả về vai trò của người dùng
                object role = dbContext.ExecuteQuery(query).Rows[0]["role"];
                return role != DBNull.Value ? role.ToString() : null;
            }

    }
}

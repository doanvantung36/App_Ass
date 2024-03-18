using App_Ass.Model;
using System.Data;

namespace App_Ass.Controller
{
    internal class EmployeeController
    {
        private readonly DbContext dbContext;

        public EmployeeController()
        {
            dbContext = new DbContext(); // Khởi tạo đối tượng DbContext
        }

        public DataTable GetEmployees()
        {
            // Lấy dữ liệu của tất cả các nhân viên từ cơ sở dữ liệu
            string query = "SELECT * FROM Employees";
            return dbContext.ExecuteQuery(query);
        }

        public bool AddEmployee(string name, string username, string password)
        {
            // Thực hiện thêm nhân viên mới vào cơ sở dữ liệu
            string query = $"INSERT INTO Employees (employee_name, employee_username, employee_password) VALUES ('{name}', '{username}', '{password}')";
            int rowsAffected = dbContext.ExecuteNonQuery(query);

            // Trả về true nếu thêm thành công, ngược lại trả về false
            return rowsAffected > 0;
        }

        public bool UpdateEmployee(int employeeId, string name, string username, string password)
        {
            // Kiểm tra xem username mới đã tồn tại trong cơ sở dữ liệu chưa
            string checkQuery = $"SELECT COUNT(*) FROM Employees WHERE employee_username = '{username}' AND employee_id != {employeeId}";
            int count = Convert.ToInt32(dbContext.ExecuteQuery(checkQuery).Rows[0][0]);

            if (count > 0)
            {
                // Username đã tồn tại, không thể cập nhật
                return false;
            }

            // Thực hiện cập nhật thông tin nhân viên trong cơ sở dữ liệu
            string query = $"UPDATE Employees SET employee_name = '{name}', employee_username = '{username}', employee_password = '{password}' WHERE employee_id = {employeeId}";
            int rowsAffected = dbContext.ExecuteNonQuery(query);

            // Trả về true nếu cập nhật thành công, ngược lại trả về false
            return rowsAffected > 0;
        }


        public bool DeleteEmployee(int employeeId)
        {
            // Thực hiện xóa nhân viên khỏi cơ sở dữ liệu
            string query = $"DELETE FROM Employees WHERE employee_id = {employeeId}";
            int rowsAffected = dbContext.ExecuteNonQuery(query);

            // Trả về true nếu xóa thành công, ngược lại trả về false
            return rowsAffected > 0;
        }
    }
}

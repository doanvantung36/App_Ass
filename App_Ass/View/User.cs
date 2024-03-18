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
    public partial class User : Form
    {
        private EmployeeController employeeController;

        public User()
        {
            InitializeComponent();
            employeeController = new EmployeeController(); // Khởi tạo controller
            RefreshEmployeeData(); // Hiển thị dữ liệu khi form được khởi tạo
        }
        private void RefreshEmployeeData()
        {
            // Làm mới dữ liệu hiển thị trên DataGridView
            dataGridView1.DataSource = employeeController.GetEmployees();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string name = txt_employeename.Text;
            string username = txt_UserName.Text;
            string password = txt_Password.Text;

            if (employeeController.AddEmployee(name, username, password))
            {
                // Thêm thành công, làm mới dữ liệu hiển thị
                RefreshEmployeeData();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["employee_id"].Value);
            string name = txt_employeename.Text;
            string username = txt_UserName.Text;
            string password = txt_Password.Text;

            if (employeeController.UpdateEmployee(employeeId, name, username, password))
            {
                // Sửa thành công, làm mới dữ liệu hiển thị
                RefreshEmployeeData();
                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["employee_id"].Value);

            if (employeeController.DeleteEmployee(employeeId))
            {
                // Xóa thành công, làm mới dữ liệu hiển thị
                RefreshEmployeeData();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            // Đăng xuất
            this.Close(); // Đóng form User
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_employeename.Text = row.Cells["employee_name"].Value.ToString();
                txt_UserName.Text = row.Cells["employee_username"].Value.ToString();
                // Password không được hiển thị để bảo mật, bạn có thể cập nhật theo nhu cầu
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}

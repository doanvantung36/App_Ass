using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Ass.Model
{
    public class DbContext
    {
        private string connectionString;

        public DbContext()
        {
            // Khai báo chuỗi kết nối ở đây
            connectionString = "Data Source=LAPTOP-7HORMRAF\\SQLEXPRESS01;Initial Catalog=AssKTNC;Integrated Security=True;Trust Server Certificate=True";
        }

        // Phương thức để truy vấn dữ liệu từ cơ sở dữ liệu
        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Phương thức để thực hiện các thao tác không truy vấn (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}

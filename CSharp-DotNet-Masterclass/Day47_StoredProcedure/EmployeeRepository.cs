using System.Data.SqlClient;

namespace Day47_StoredProcedure
{
    public class EmployeeRepository
    {
        public string ConnectionString = "Data Source=Amey;Initial Catalog=testDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;";
        public EmployeeRepository() { }

        public void AddEmployee(Employee employee) 
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("sp_AddEmpNew", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id",employee.Id);
                sqlCommand.Parameters.AddWithValue("@Name",employee.Name);
                sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);

                con.Open();
                sqlCommand.ExecuteNonQuery();

            }
        }
    }
}

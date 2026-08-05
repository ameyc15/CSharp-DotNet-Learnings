using Day35_ADONET_EmpMgmtSys.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Day35_ADONET_EmpMgmtSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private string connectionString = "Data Source=AMEY;Initial Catalog=LocalDb;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;";
        public EmployeeController()
        {

        }
        [HttpPost("add-employee")]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Invalid Input provided ...");
            }

            try
            {
                string sqlQuery = "INSERT INTO Employees (FirstName,LastName,Email,Salary,IsActive) values (@FirstName,@LastName,@Email,@Salary,@IsActive)";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString)) 
                {
                    await sqlConnection.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery,sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        cmd.Parameters.AddWithValue("@Email", employee.Email);
                        cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@IsActive", employee.IsActive);

                       int rowsAffected= await cmd.ExecuteNonQueryAsync();
                        await sqlConnection.CloseAsync();

                        if(rowsAffected < 1)
                        {
                            Console.WriteLine("data insertion failed");
                            return StatusCode(500, "Error Occured");
                        }
                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                Console.WriteLine("Error Occured while Creating Employee" + ex.Message);
            }

            return Ok(employee);
        }

    }
}

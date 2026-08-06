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
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                        cmd.Parameters.AddWithValue("@Email", employee.Email);
                        cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@IsActive", employee.IsActive);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        await sqlConnection.CloseAsync();

                        if (rowsAffected < 1)
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

        [HttpGet("get-employee-by-id")]
        public async Task<IActionResult> GetEmployeeById([FromQuery] int id)
        {
            if (id < 1)
            {
                return BadRequest("Please enter valid id");
            }
            try
            {
                string sqlQuery = "SELECT * FROM Employees WHERE ID=@Id";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    await sqlConnection.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                var employee = new Employee
                                {
                                    FirstName = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    Email = reader.GetString(3),
                                    Salary = reader.GetDecimal(4),
                                    IsActive = reader.GetBoolean(5),
                                };
                                return Ok(employee);
                            }
                            else
                            {
                                return NotFound("Employee with Id : " + id + "Not Found");

                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Database Error While Processing" + ex.Message);
            }

        }
        [HttpGet("Get-all-employees")]
        public async Task<IActionResult> GetAllEmployees([FromQuery] int skip=0, int PageSize=2)
        {
            if (skip < 0 || PageSize <0) 
            {
                return BadRequest();
            }
            string sqlQuery = "SELECT * FROM Employees ORDER BY Id OFFSET @Skip ROWS FETCH NEXT @PageSize ROWS ONLY";
            List<Employee> employees = new List<Employee>();


            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                   await sqlConnection.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@Skip", skip);
                        cmd.Parameters.AddWithValue("@PageSize", PageSize);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())

                            while (await reader.ReadAsync())
                            {
                                Employee e = new Employee()
                                {
                                    FirstName = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    Email = reader.GetString(3),
                                    Salary = reader.GetDecimal(4),
                                    IsActive = reader.GetBoolean(5),
                                };
                                employees.Add(e);
                            }
                    }
                    sqlConnection.CloseAsync();
                }
                return Ok(employees);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
            

        }
    }
}

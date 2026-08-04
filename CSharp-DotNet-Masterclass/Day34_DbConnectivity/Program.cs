using System.Data.SqlClient;

namespace Day34_DbConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Need to Create SQL Connection : sqlConnection class object need to be created 
            // 2. Need to create sql Command : Select * from Person.person
            // 3. open the sqlConnection 
            // 4. execut and process the result
            // 5. close the connection
            string connectionString = "Data Source=Amey;Initial Catalog=AdventureWorks2019;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Person.Person",sqlConnection);

                try
                {
                    sqlConnection.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstname = reader.GetString(reader.GetOrdinal("FirstName"));
                            string lastname = reader.GetString(reader.GetOrdinal("LastName"));
                            Console.WriteLine("Record : " + firstname + lastname);
                        }
                    }
                    sqlConnection.Close();
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}

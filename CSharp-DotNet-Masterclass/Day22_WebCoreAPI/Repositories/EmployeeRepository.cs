namespace Day22_WebCoreAPI.Repositories
{
    public class EmployeeRepository
    {
        public string EmployeeName = "Amey Chaudhary";

        public string EmmployeeCity = "Pune";
        public EmployeeRepository() { }

        public string GetEmployeeData()
        {
            return EmployeeName;
        }
    }
}

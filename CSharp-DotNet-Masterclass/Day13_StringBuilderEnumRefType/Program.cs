namespace Day13_StringBuilderEnumRefType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 100;
            Employee e1 = new Employee();
            e1.Display();
            Console.WriteLine($"value of the value type salary is : {salary}");

           
            Update(e1, salary);
            Console.WriteLine($"updated data for reference type name {e1.name} and salary is {e1.salary}");
            Console.WriteLine($"value of the value type salary is : {salary}");

            


            // how to create a string using charcter array
            char[] chars = { 'A', 'M', 'E', 'Y','O','N','T','O','P' };
            string s1 = new string( chars );
            Console.WriteLine(s1);

            // string builder ..


        }
        public static void Update(Employee e2, int salary)
        {
            e2.name = "Real Name";
            e2.salary = 2000;
            
        }
    }
}

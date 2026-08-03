namespace Day30_LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student() {Age = 23, StudentName = "Amey"},
                new Student() {Age = 27, StudentName = "Padam"},
                new Student() {Age = 34, StudentName = "Tom"},
                new Student() {Age = 29, StudentName = "Rahul"},
                new Student() {Age = 25, StudentName = "Vinit"},
                new Student() {Age = 19, StudentName = "Chiku" },
                new Student() {Age = 20, StudentName = "Shubham"},
                new Student() {Age = 21, StudentName = "Shreyas" }
            };

            // if I want to fetch the students whose age is between 15 to 25 without using LINQ
            Console.WriteLine("---------------------USING IF AND FOR LOOPS--------------------");
            Student[] filteredStudents = new Student[10];
            int i = 0;
            foreach (Student s in students)
            {

                if(s.Age >= 18 && s.Age <= 25)
                {                    
                    filteredStudents[i] = s;
                    i++;
                }
            }
            foreach (Student s in filteredStudents.ToList()) 
            {
                if (s != null)
                {
                    Console.WriteLine($"Student Name :{s.StudentName}  And Age :{s.Age}");
                }
            }
            // now using LINQ
            // First Question
            Console.WriteLine("****************************************");
            Console.WriteLine("****************USING LINQ************************");

            Student[] outputStudents = students.Where(s => s.Age>=15 && s.Age <=25).ToArray();


            foreach(Student s in outputStudents)
            {
                if (s != null)
                {
                    Console.WriteLine($"Student Name :{s.StudentName} AND Age : {s.Age}");
                }
            }
            // Second Question :  List of Students whose name starts with 'S'
            Console.WriteLine("***********************Second Question*****************");
            List<Student> nameFilter = students.Where(s => s.StudentName.StartsWith("S")).ToList();
            foreach(Student s in nameFilter)
            {
                Console.WriteLine($" Name : {s.StudentName} Age: {s.Age}");
            }
            //Notes : 
            // Query Syntax
            // Define the Source : from ... in ...
            // Create Query      : where ...
            // Execute the Query : select ...
            int[] numbers = { 12, 67, 89, 91, 34, 2, 9, 17 };
            var num = from n in numbers
                      where n > 50
                      select n;
            Console.WriteLine(string.Join(",",num));

        }
    }
}

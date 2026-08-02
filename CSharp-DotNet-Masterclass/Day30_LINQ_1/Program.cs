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
            Student[] filteredStudents = new Student[10];
            int i = 0;
            foreach (Student s in students)
            {

                if(s.Age >= 18 && s.Age <= 25)
                {
                    Console.WriteLine($"Student Name : {s.StudentName.ToString()} and Age :  {s.Age.ToString()}" );
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
        }
    }
}

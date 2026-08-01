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
                new Student() {Age = 25, StudentName = "Vinit"}
            };

            // if I want to fetch the students whose age is between 18 to 25 without using LINQ
            foreach (Student s in students)
            {
                if(s.Age >= 18 && s.Age <= 25)
                {
                    Console.WriteLine($"Student Name : {s.StudentName.ToString()} and Age :  {s.Age.ToString()}" );
                }
            }
        }
    }
}

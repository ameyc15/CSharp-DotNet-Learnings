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
            // Find out even numbers in array
            var evenNum = from n in numbers
                          where n%2==0
                          select n;
            Console.WriteLine(string.Join(",", evenNum));

            // Find the strngs which has tutorial world in it
            List<String> domainList = new List<string>()
            {
                "Java Tutorials",
                "Data Science Masterclass",
                "MVC Lectures",
                "C# Tutorials",
                ".Net Core Tutorials"
            };
            
             var tutorials =  from t in domainList
                where t.Contains("Tutorial")
                select t;
            Console.WriteLine(string.Join(",",tutorials));

            // find the friends who has 'a' in their names and length<5 ordered by descending
            string[] friendnames = { "Amey", "Mikhail", "Adam", "David", "Bobby", "Christopher" };
            var friends  = from friend in friendnames
                           where friend.ToLower().Contains("a") && friend.Length <5
                           orderby friend descending
                           select friend;

            Console.WriteLine(string.Join("," , friends));

            // **********************Exercise**********************
            List<Employee> employees = new List<Employee>() 
            {
                new Employee{Id=1, FirstName="John", LastName="Doe",Email="john@email.com",Department="IT",Salary=60000},
                new Employee{Id=2,FirstName="Jane", LastName="Smith",Email="jane@email.com",Department="HR",Salary=35000},
                new Employee{Id=3,FirstName="Robert",LastName="Johnson",Email="rob@email.com",Department="Finance",Salary=85000},
                new Employee{Id=4,FirstName="Emily",LastName="Davis",Email="emily@gmail.com",Department="IT",Salary=90000},
                new Employee{Id=5,FirstName="Michael",LastName="Brown",Email="mich@email.com",Department="IT",Salary=87000},
                new Employee{Id=6,FirstName="Sarah",LastName="Wilson",Email="sarah@email.com",Department="HR",Salary=45000}
            };
            // Employee class has data of employee 
            // 1. Get All employee data from IT department
            var resultOne = from emp in employees
                            where emp.Department == "IT"
                            select emp;
            foreach (var item in resultOne)
            {
                Console.WriteLine($"Id : {item.Id} {item.FirstName} {item.LastName}  {item.Department}  {item.Email}  {item.Salary}");
            }
            // 2. Emplpyee Salary greater than 50000
            Console.WriteLine("*************2nd Question**************");
            var resultTwo  = from emp in employees
                             where emp.Salary>50000
                             select emp;
            foreach (var item in resultTwo)
            {
                Console.WriteLine($"Id : {item.Id}");
            }

            // 3. Employee from IT and salary > 80000
            Console.WriteLine("*************3rd Question**************");

            var resultThree = from emp in employees
                              where emp.Department == "IT" && emp.Salary > 80000
                              select emp;
            foreach (var item in resultThree) 
            {
               Console.WriteLine(item.FirstName + item.LastName);
            }



            // 4. Sort Employee by name 
            Console.WriteLine("*************4th Question**************");

            var resultfour = from e in employees
                             orderby e.FirstName
                             select e;
            foreach(var item in resultfour)
            {
                Console.WriteLine(item.FirstName);
            }





            // 5. Sort by Department Name then Salary High to Low
            Console.WriteLine("*************5th Question**************");
            var resultFive = from e in employees
                             orderby e.Department, e.Salary descending                             
                             select e;
           
            foreach (var item in resultFive)
            {
                Console.WriteLine(item.FirstName + item.Salary + item.Department);
            }


            // 6. Employee whose salary between 30k and 60k
            Console.WriteLine("*************6th Question**************");
            var resultSix = from e in employees
                            where e.Salary >= 30000 && e.Salary <= 60000
                            select e;

            foreach(var item in resultSix)
            {
                Console.WriteLine(item.FirstName + item.LastName + item.Salary);
            }
        }
    }
}

using System.Text;

namespace Day13_StringBuilderEnumRefType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 124;
            Employee e1 = new Employee();
            e1.Display();
            e1.salary = 200;
            e1.name = "real name";
            e1.Display();
            //Console.WriteLine($"value of the value type salary is : {salary}");


            Update(e1, salary);
            Console.WriteLine($"updated data for reference type name {e1.name} and salary is {e1.salary}");
            Console.WriteLine($"value of the value type salary is : {salary}");

            // verbitam string 
            string paragraph = @"The card has a ₹500 annual fee, which gets waived if you spend ₹3,50,000 in a year.
            To hit this safely, route general physical offline store spending (electronics, dining out, local malls)
            through this card to earn an unlimited 1% flat cashback.";


            // how to create a string using charcter array
            char[] chars = { 'A', 'M', 'E', 'Y', 'B', 'C' };
            string str = new string(chars);
            Console.WriteLine(str);

            // string builder ..
            string s1 = "Hi Amey";
            s1 = s1 + ".Net Developer ";  // new string is generated at new memory adress since stringss are immutable
            Console.WriteLine(s1);

            //Empty
            StringBuilder stringBuilder = new StringBuilder();

            //with capacity
            StringBuilder sb2 = new StringBuilder(100);

            // with some defualt value
            StringBuilder sb1 = new StringBuilder("Hello There", 25);
            Console.WriteLine(sb1.ToString());
            sb1.Append("Amey Chaudhhary");
            Console.WriteLine(sb1);

            sb1.Replace("Hello", "Hi");
            Console.WriteLine(sb1);

            StringBuilder sb3 = new StringBuilder("Amey Chaudhary", 25);
            sb3.Insert(4, " Bhaskar");
            Console.WriteLine(sb3);

            // Enum
            Employee e5 = new Employee();
            e5.gender = Gender.Male;
            Console.WriteLine(e5.gender);




        }
        public static void Update(Employee e2, int salary)
        {
            e2.name = "Real Name inside static method";
            e2.salary = 999;

            // value type int salary
            salary = 1246;

        }
    }
}

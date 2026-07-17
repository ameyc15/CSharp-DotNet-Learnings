namespace Day18_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string>daysInWeek = new Dictionary<int, string>();

            daysInWeek.Add(1, "Monday");
            daysInWeek.Add(2, "Tuesday");
            daysInWeek.Add(3, "Wednesday");
            daysInWeek.Add(4, "Thursday");

            Console.WriteLine(daysInWeek.Count());
            daysInWeek.Remove(1); // 
            Console.WriteLine(daysInWeek.Count());

            foreach(KeyValuePair<int, string> pair in daysInWeek)
            {
                Console.WriteLine(" "+ pair.Key + ": " + pair.Value);
            }
            daysInWeek.Add(1, "Monday");
            Console.WriteLine();
            foreach(var pair in daysInWeek)
            {
                Console.WriteLine(" " + pair.Key + ": " + pair.Value);
            }
            Console.WriteLine();
            string value;
            bool isPresent = daysInWeek.TryGetValue(2, out value);
            if (isPresent)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            // Updating the Value
            string day;
            if (daysInWeek.ContainsKey(2))
            {
                daysInWeek[2] = "Sunday";               
            }
           
            foreach(var pair in daysInWeek)
            {
                Console.WriteLine("Key : " + pair.Key + "   Value : " + pair.Value);
            }

            // Interview Question
            // Count the Number of character present in the string "MISISSIPI"
            //string str = "MISISSIPI";
            //Console.WriteLine("The Given String is : " +str);
            // Lets take input from console

            string str = Console.ReadLine();

            Dictionary<char, int> countOfChar = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (countOfChar.ContainsKey(c))
                {
                    countOfChar[c]++;
                }
                else
                {
                    countOfChar[c] = 1;
                }
            }

            foreach(var pair in countOfChar)
            {
                Console.WriteLine($"{pair.Key}  :   {pair.Value}");
            }

        }
    }
}

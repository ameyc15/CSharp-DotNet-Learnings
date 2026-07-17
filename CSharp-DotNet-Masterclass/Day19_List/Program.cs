namespace Day19_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Pune");
            cities.Add("Mumbai");

            Console.WriteLine(cities[0]);
            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.Insert(1, "London");

            foreach(var c in cities)
            {
                Console.WriteLine(c);
            }
            bool isPresent = cities.Contains("Pune"); // case sensitive you can use ToLower() and ToUpper()
            if(isPresent == true)
            {
                Console.WriteLine("Pune is present in the list");
            }
            else
            {
                Console.WriteLine("Pune is not in list");
            }
            //*** Interview Questions ***
            // Find the valid list of emails from the given list of emails 
            // a@.comgmail, @gmailcom.a, agmail.com, gmail.rohit.@, rahul@gmail.com, test@example.com, invalid@, user+domain@.co
            // @ should present
            // string should end with ".com" sbustring
            List<string> listEmails = new List<string>()
            {
                "@gmailcom.a" ,
                "agmail.com",
                "gmail.rohit.@",
                "rahul@gmail.com",
                "test@example.com",
                "invalid@",
                "user+domain@.co"
            };
            List<string> validEmails = new List<string>();
            foreach (var e in listEmails) 
            {
                if(e.Contains("@") && e.EndsWith(".com"))
                {
                    validEmails.Add(e);
                }
            }
            foreach(var e in validEmails)
            {
                Console.WriteLine(e);
            }
        }
    }
}

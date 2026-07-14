namespace Day14_JaggedMultiDimArrayInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // Find the duplicate number in Array : {3,8,,2,,1,5,3}
            // we will use nested loops
            int[] arrOne = { 3, 8, 2, 1, 5, 5 };
            int duplicateNumber = 0;
            bool found = false;
            for(int i=0; i<arrOne.Length-1; i++)
            {
                for(int j =i+1; j < arrOne.Length; j++)
                {
                    if (arrOne[i] == arrOne[j])
                    {
                        duplicateNumber = arrOne[i];
                        found = true;
                        break;
                    }
                }
                if(found)
                {
                    break;
                }
            }
            Console.WriteLine(duplicateNumber);



            // Find the non duplicate number in Array : {3,2 ,5,5,3}
            // we will use xor operator 
            int[] arr = { 2, 2, 5, 5, 3 };
            int xorResult = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                xorResult = xorResult ^ arr[i];
            }
            Console.WriteLine(xorResult);


            //Sorting 


        }
    }
}

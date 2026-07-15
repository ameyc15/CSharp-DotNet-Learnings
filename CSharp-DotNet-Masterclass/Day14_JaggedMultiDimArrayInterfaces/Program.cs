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
            for (int i = 0; i < arrOne.Length - 1; i++)
            {
                for (int j = i + 1; j < arrOne.Length; j++)
                {
                    if (arrOne[i] == arrOne[j])
                    {
                        duplicateNumber = arrOne[i];
                        found = true;
                        break;
                    }
                }
                if (found)
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


            //Sorting using nested loops
            int[] arrTwo = { 3, 8, 2, 1, 0, 5 };
            for (int i = 0; i < arrTwo.Length - 1; i++)
            {
                for (int j = i + 1; j < arrTwo.Length; j++)
                {
                    if (arrTwo[i] > arrTwo[j])
                    {
                        int temp = arrTwo[i];
                        arrTwo[i] = arrTwo[j];
                        arrTwo[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arrTwo.Length; i++)
            {
                Console.Write(arrTwo[i]);
            }


            // 2-d array
            int[,] array = new int[2, 2] { {4,5}, {3,6} }; // first is always rows 

            // jagged array
            // array of array is called jagged array
            int[][] jArray = new int[2][]
            {
                new int[3]{1,2,5},
                new int[4]{3,2,1,0}
            };


            // var dynamic null
            // var is anonymous type at run time it will be 

            //Interface
            //  FileInfo => IFileInfo
            // it should  have two  methods ReadFile and WriteFile (string text)
            FileInfo f1 = new FileInfo();
            f1.ReadFile();
            f1.WriteFile("Sample");

        }
    }
}

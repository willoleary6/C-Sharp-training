using System;

namespace looping_arrays_and_string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] favNums = new int[3];

            favNums[0] = 23;

            string[] customers = { "Bob", "Sally" };

            var employees = new[] { "John", "paul" };

            object[] random_arry = { "Paul", 1234 };

            Console.WriteLine(" index: {0}", random_arry[0]);

            for(int i = 0; i < random_arry.Length; i++)
            {
                Console.WriteLine(" index {0}: {1}", i, random_arry[i]);
            }

            string[,] customerNames = new string[2, 2] { { "John", "joe" }, { "mary", "tim" } };

            Console.WriteLine(" MD val: {0}", customerNames[1,1]);

            for (int i = 0; i < customerNames.GetLength(0); i++)
            {
                for (int j = 0; j < customerNames.GetLength(1); j++)
                {
                    Console.WriteLine("{0}", customerNames[i,j]);
                }
            }


            int []random_nums = { 1, 2, 3, 4, 5, 6, 7 };
            Array.Reverse(random_nums);

            PrintArray(random_nums, "foreach");

        }

        static void PrintArray(int[] random_nums, string mess)
        {
            foreach(int k in random_nums)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }
    }
}

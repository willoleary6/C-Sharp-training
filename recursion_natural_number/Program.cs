using System;

namespace recursion_natural_number
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // Natural number starting point
            int starting_print_val = 1;
            // n
            int target_val = 10;
            // begin recursion
            Natural_numbers_recursion(starting_print_val, target_val);
        }

        static int Natural_numbers_recursion(int starting_print_val, int target_val)
        {
            // dont want it to sink below natural number boundry
            if( target_val < 1)
            {
                // fall out of recursive loop
                return 0;
            }
            // decrementor of loop
            target_val--;
            Console.Write(" {0} ",starting_print_val);

            starting_print_val++;
            return Natural_numbers_recursion(starting_print_val, target_val);
        }
    }
}

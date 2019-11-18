using System;

namespace shell_short
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sort_me = { 2340, 4523, 3421 };
            // calculate interval
            int interval = 0;
            while(interval < sort_me.Length)
            {
                interval = interval * 3 + 1;
            }

            while(interval > 0)
            {
                for(int outer = interval; outer < sort_me.Length; outer++)
                {
                    // value to be inserted
                    int valueToInsert = sort_me[outer];
                    int inner = outer;

                    // shift element to the write
                    while(inner > interval -1 && sort_me[inner - interval] >= valueToInsert)
                    {
                        sort_me[inner] = sort_me[inner - interval];
                        inner -= interval;
                    }
                    // insert value on hole position
                    sort_me[inner] = valueToInsert;
                }
                // recalculate interval
                interval = (interval - 1) / 3;
            }

           for(int i = 0; i < sort_me.Length; i++)
           {
                Console.WriteLine(sort_me[i]);
           }
            
        }
    }
}

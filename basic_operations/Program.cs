using System;
using System.Numerics;

namespace basic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();
            // take command line arguments and pump it out as a string

            Console.WriteLine(string.Join(", ",myArgs));

            // functions
            // SayHello();


            // data types

            bool canIVote = true;

            Console.WriteLine("Biggest integer : {0}", int.MaxValue);

            Console.WriteLine("smallest integer : {0}", int.MinValue);


            Console.WriteLine("Biggest long : {0}", long.MaxValue);

            Console.WriteLine("smallest long : {0}", long.MinValue);


            decimal decPiVal = 3.141592653589793238462643383279502M;
            Console.WriteLine(decPiVal);

            decimal decBigNum = 3.00000000000000000000000000000011M;
            Console.WriteLine("DEC : PI = bigNum = {0}", decBigNum + decPiVal);

            Console.WriteLine("Biggest decimal : {0}", decimal.MaxValue);
            Console.WriteLine("smallest decimal : {0}", decimal.MinValue);


            double dblePiVal = 3.14159265358979;
            double dbleBigNum = 3.0000000000000;
            Console.WriteLine("Double : PI = bigNum = {0}", dbleBigNum + dblePiVal);

            Console.WriteLine("Biggest double : {0}", double.MaxValue.ToString("#"));
            Console.WriteLine("smallest double : {0}", double.MinValue);


            double fltPiVal = 3.14159;
            double fltBigNum = 3.0000;
            Console.WriteLine("Float : PI = bigNum = {0}", fltBigNum + fltPiVal);

            Console.WriteLine("Biggest float : {0}", float.MaxValue.ToString("#"));
            Console.WriteLine("smallest float : {0}", float.MinValue);



            // type conversion

            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("100.00");

            // date and time

            DateTime myDate = new DateTime(1997, 2, 21);
            Console.WriteLine("Day Of Week : {0}", myDate.DayOfWeek);

            myDate = myDate.AddDays(4);
            myDate = myDate.AddMonths(1);
            myDate = myDate.AddYears(1);

            Console.WriteLine("New Date: {0}", myDate);


            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));

            Console.WriteLine("New Time : {0}", lunchTime.ToString());



            // big ints
            BigInteger bigNum = BigInteger.Parse("12345454545485648666666666666666666666666666666666666666666666666666666666666");
            Console.WriteLine("Big Num * 2 = {0}", bigNum*2);


            // formatting
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);

            Console.WriteLine("3 Decimals : {0:f3}", 23.4555454);
            Console.WriteLine("commas and decimals : {0:n4}", 2300);
        }


        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            // transposing variables into strings
            Console.WriteLine("Hello {0}", name);
        } 
    }
}

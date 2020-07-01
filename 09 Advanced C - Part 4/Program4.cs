using System;

namespace _09_Advanced_C___Part_4
{
    class NullableTypes
    {
        static void Main(string[] args)
        {
            DateTime? myDate = null;
            Console.WriteLine(myDate);

            int? number = null;
            Console.WriteLine(number);
            //number = 5;

            int numberTwo = 10;

            Console.WriteLine(number ?? numberTwo);

            string firstName = null;
            firstName = "John";

            string message = null;
            message = "first name is null";

            Console.WriteLine(firstName ?? message);
        }
    }
}

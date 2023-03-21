using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fundamentals_of_C_Programming_Part_1
{
    class DataTypesVariables
        //data types and variables
    {
        static void Main(string[] args)
        {
		    Console.WriteLine("Hello World!");
            //   Console.ReadLine();
            int x = 1;
            int y = 4;
            int z = x + y;
            Console.WriteLine("the number is " + y);
            Console.WriteLine("the number is " + x);
            Console.WriteLine("the number is " + z);

            double double_num = 0.3d; // i dont know why you have to add the letter right after the value? weird.
            float float_num = 1.4f;
            decimal decimal_num = 0.0m;

            Console.WriteLine(double_num);
            Console.WriteLine(float_num);
            Console.WriteLine(decimal_num);

            double_num = 1.1;
            float_num = 9.7f;
            decimal_num = 105.3m;

            Console.WriteLine("double is " + double_num + " float is " + float_num + " decimal is " + decimal_num);

            //char letter_a = 'an'; //this gives an error when more than 1 letter, so use string. uncomment it to see.
            //string firstName = "Jon";
            //string lastName = " Snow"; //adding a space at the front of lastname, for display reasons.

            string firstName, lastName, House;
            firstName = "Jon";
            lastName = " Snow";
            House = "Stark";
            Console.WriteLine("Hello, " + firstName + lastName + " of house " + House);//this plus thing is called concatenation.

            //Booleans

            bool isWorking;
            isWorking = false;
            Console.Write(isWorking); //this isnt good for displaying purposes.
            Console.WriteLine(isWorking);

            int sum;
            sum = 0;

            int number1, number2;

            number1 = 5;
            number2 = 100;
            sum = number1 + number2;
            Console.WriteLine(sum);

            int a = 5;
            string name = "Ahmad";

            var fullName = "Jon Snow";
            var test = name; // this tells it that name is the same as test.
            Console.WriteLine("the letter a is equal to = " + a);
            Console.WriteLine(fullName);
            Console.WriteLine(test);

            //this block is just to see what their values are.
            sbyte d = sbyte.MaxValue;
            sbyte f = sbyte.MinValue;
            byte g = byte.MaxValue;
            byte h = byte.MinValue;
            int b = int.MaxValue;
            int c = int.MinValue;
            double p = double.MaxValue;
            long i = long.MaxValue;
            ulong o = ulong.MaxValue;
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine("ulong is = " + o);
            Console.WriteLine("double is = " + p);


            //Type Conversion.

            int serialNo = 150;
            string accountNo = "";
            float anyNo = 3.1f;

            //accountNo = serialNo //this breaks cos it cant convert explicetly.
            accountNo = serialNo.ToString(); //the tostring converts ints to string. That is numbers to letters.
            Console.WriteLine(accountNo);
            //anyNo = serialNo;// this works cos float CAN handle integers but not the other way.
            Console.WriteLine(anyNo);

            serialNo = Convert.ToInt32(anyNo);//this doesnt round up numbers.
            serialNo = (int)anyNo;// this line is even shorter, simply convert anyNo to int and put in serialNo variable. 
            Console.WriteLine(serialNo);

            //var keyword.
            //var keyword is powerful cos it handles different types of casts. You throw whatever at it can change.
            int j = 5;
            string name2 = "Ahmad";

            var test2 = name2;
            Console.WriteLine(j);
            Console.WriteLine(test2);
        }
    }
}

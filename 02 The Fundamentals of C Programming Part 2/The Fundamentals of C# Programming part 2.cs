using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fundamentals_of_C_Programming_Part_2
{
    class MoreDataTypes
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = int.MaxValue; //MaxValue is an inbuild call/option from the drop-down menu. 

            Console.WriteLine(x); // this will diplay what maxValue is.

            int y = 2147483647;
            //int y = 2147483648; //this gives an error cos the data type int only stores up to 2147483647, just read it.
            uint z = 0;
            z = (uint)x + (uint)y;//this is how you cast the variables to fit.
            //uint y = -1; //this gives error, cos uint cant be negative numbers.
            Console.WriteLine(y);
            Console.WriteLine("value of z = " + z); // i dont know why its -2?

            uint l = uint.MaxValue;
            Console.WriteLine(l);

            uint q = uint.MinValue; //this is 0 as a value, thats the minimum.
            Console.WriteLine(q);


            Console.WriteLine(typeof(int).IsPrimitive); //what this does, is check if int belong to C# primitive types.
            Console.WriteLine(typeof(double).IsPrimitive);
            Console.WriteLine(typeof(decimal).IsPrimitive);
            Console.WriteLine(typeof(char).IsPrimitive);
            Console.WriteLine(typeof(string).IsPrimitive);


            float f_no = 4.0f;
            double d_no = 3.3d;
            decimal m_no = 5.1m;

            f_no = 1 / 3f;
            d_no = 1 / 3d;
            m_no = 1 / 3m;

            //place holder
            Console.WriteLine("float no. is {0}", f_no); //what it does here is use {0} as a placeholder for the value of f_no.
            Console.WriteLine("double no. is {0}", d_no);
            Console.WriteLine("decimal no. is {0}", m_no);


            //DateTime
            DateTime myDate = new DateTime(); //begining of time.
            DateTime myDate2 = new DateTime /*you can setup the date manually, like so..*/(1999, 10, 5);
            DateTime myDate3 = DateTime.Today; // today is a function of the DateTime data type.
            DateTime myDate4 = DateTime.Now; //PCs internal clock time.

            Console.WriteLine(myDate);
            Console.WriteLine(myDate2);
            Console.WriteLine(myDate3);
            Console.WriteLine(myDate4);
            Console.WriteLine(myDate.ToShortDateString()); //this function only displays the date.
            Console.WriteLine(myDate.ToShortTimeString()); // you can add functions to the variables like here.
            Console.WriteLine(myDate.ToLongTimeString());
            Console.WriteLine(myDate.AddDays(10));
            //Console.WriteLine(myDate.AddDays(-6)); //this gives an error of un-representable time.
            Console.WriteLine(myDate4.AddDays(-14)); //this is working off the Now function, and variable myDate4.
            Console.WriteLine(myDate4.AddYears(2)); //this adds 2 years.

            string formattedDate = string.Format("Date is {0:yyyy M d}", myDate4); //the placeholder {0}, you can give it a "pattern" by adding :yyyy to it. Aswell as M for the month and d (notice is case sensitive) for the day.
            string formattedDate2 = string.Format("Date is {0:yyyy MMMM dddd mm ss tt}", myDate4); //add 3 more Ms for full month name, same with day.
            string formattedDate4 = string.Format("{0:yyyy M d}", myDate4);
            //string formattedDate4 = string.Format(myDate4); //notice this error. cannot convert datetime to string.
            Console.WriteLine(formattedDate);
            Console.WriteLine(formattedDate2);
            Console.WriteLine("date 4 is " + formattedDate4);



            //DateTime Exercise:

            DateTime myDate5 = DateTime.Now;
            string formattedDate3;

            //first format : 30-09-2017 01:15:55
            formattedDate3 = string.Format("{0:dd-MM-yyyy HH:mm:ss}", myDate5);//string has a function named format like in use here.
            //Regular expressions. anything after the placeholder is where the format display takes place.
            Console.WriteLine(formattedDate3);

            //second format: saturday of month september 2017
            formattedDate3 = string.Format("{0:dddd 'of month' MMMM 'of year' yyyy}", myDate5);
            Console.WriteLine(formattedDate3);

            /* third format:
             * day saturday
             * month september
             * year 2017
             */
            formattedDate3 = string.Format("{0:'Day' dddd \n'Month' MMMM \n'of the year' yyyy}", myDate5);
            Console.WriteLine(formattedDate3);

            //Error types

            int a, b, c;
            a = 0; b = 1; c = 0;
            //a = ""; b = 1; c = 0; //this gives an syntax error. cos it cant convert strings to int.
            //c = b / a; //this gives an unhandled exception error. it wont divide by zero.
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //ReadLine
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine(); //this one waits to input your name.

            Console.WriteLine("welcome {0}", name); //the {0} gets replaced by the variable "name".
            Console.WriteLine("welcome " + name + ", welcome back.");


            //arithmetic operators

            int m = 7;
            int n = 2;
            //int result = 0; // he does this alot, first gives 0 value to the variable then uses it.
            int result = m % n; // you can simply state that result is an integer in the same line.
            Console.WriteLine("this isnt what you thought: " + m + n);//cant carry out operations here.
            Console.WriteLine("Remainder: " + result); //this is 1 cos the remainder of 7-6 is 1, after 3*2.
            //or whats the closest you can get to the whole with that number.


            //Arithmetic Exercise.

            int w, e;
            int add, sub, mult, rem;
            float div;

            Console.WriteLine("Enter no 1");
            w = int.Parse(Console.ReadLine());//int.Parse converts to int32.

            Console.WriteLine("Enter no 2");
            e = int.Parse(Console.ReadLine());

            add = w + e;
            Console.WriteLine(w + " + " + e + " = " + add);

            sub = w - e;
            Console.WriteLine(w + " - " + e + " = " + sub);

            mult = w * e;
            Console.WriteLine(w + " * " + e + " = " + mult);

            div = (float)w / (float)e;//they all have to be of the same type. float.
            Console.WriteLine(w + " / " + e + " = " + div);

            rem = w % e;
            Console.WriteLine(w + " % " + e + " = " + rem);

            //precedence of operators.

            int r = 0;
            int t = 0;
            r = (2 + 3) * 2 - 4 + 2;
            t = 2 + 3 * 2 - 4 + 2;
            Console.WriteLine("r = " + r);
            Console.WriteLine("t = " + t);
        }
    }

    class ConditionalStatements
    //conditional statements IF.
    {
        static void Main(string[] args)
        {
            int t = 0;
            int u = 0;
            {
                Console.WriteLine("input first number");
                t = int.Parse(Console.ReadLine()); //this line waits for the user to enter a number.


                {
                    Console.WriteLine("input second number");
                    u = int.Parse(Console.ReadLine());
                }


                if (t > u) //notice how curly brakets for the console are not really necesary.
                    Console.WriteLine("first number is greater than second number");

                else if (t < u)
                    Console.WriteLine("first number is less than second number");

                else if (t == u)
                    Console.WriteLine("They are even");

                //switch statement.

                Console.WriteLine("are you enjoying C#?(yes or no)");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "yes": Console.WriteLine("Thats good"); break;
                    case "no": Console.WriteLine("Thats not good"); break;
                    default: Console.WriteLine("this is not correct answer"); break;
                }

                int i = 0;
                int o = 0;

                i = 5; o = 7;

                Console.WriteLine("Enter 2 numbers please");
                i = int.Parse(Console.ReadLine());
                o = int.Parse(Console.ReadLine());


                if (i == o)
                    Console.WriteLine("i is equal to o");
                else if (i != o)
                    Console.WriteLine("i is not equal to o");
                {
                    // nested if
                    if (i > o)
                        Console.WriteLine("i is greater than o");

                    else if (i < o)
                        Console.WriteLine("i is less than o");
                }



                //Comparison operators.
                int p = 0;
                int s = 0;

                p = 5; s = 7;
                if (p == s) //this are the operators.
                    Console.WriteLine("p is equal to s");
                else if (p != s) //this are the operators.
                    Console.WriteLine("p is not equal to s");



                //AND operator && thats how you write AND, Booleans aswell.
                bool HasLicence = false;
                bool KnowsHowToDrive = true;

                if (HasLicence == true && KnowsHowToDrive == true)
                {
                    Console.WriteLine("you are good to go!");
                }
                else if (HasLicence == true && KnowsHowToDrive == false)
                {
                    Console.WriteLine("Cheater!");
                }
                else if (HasLicence == false && KnowsHowToDrive == true)
                {
                    Console.WriteLine("you need a licence!");
                }
                else if (HasLicence == false && KnowsHowToDrive == false)
                {
                    Console.WriteLine("you are not ready!");

                    //OR operator ||
                    bool WentForSwim = false;
                    bool TookShower = false;

                    if (!WentForSwim || !TookShower)
                        Console.WriteLine("you are wet pal");

                    else
                        Console.WriteLine("you are not wet");
                }
                //more logical operators
                bool username = true;
                bool email = true;
                bool password = true;

                //if (username && email && password)
                if ((username || email) && password)
                    Console.WriteLine("user is valid");
                else
                    Console.WriteLine("something went wrong");

                //Even OR odds
                int f = 0;
                Console.WriteLine("write another number");
                f = int.Parse(Console.ReadLine());
                if (f % 2 == 0)//what this does is calculate if the number inputed has a remainder of 0 after divisioned by 2.
                    Console.WriteLine(f + " is an even number");
                else
                    Console.WriteLine(f + " is an odd number");

                //assignments:

                Console.WriteLine("what is your name?");
                string name2 = Console.ReadLine();
                Console.WriteLine("Nice to meet you {0}, my name is C#, How old are you?", name2);
                int.TryParse(Console.ReadLine(), out int age);//here age has been declared an int.
                if (age == 0)
                    Console.WriteLine("that is not good input");
                else
                    Console.WriteLine("{0} is good, As for me I was born on 2002. Which makes me {1} years old.", age, DateTime.Now.Year - 2002);//2002 was when c# was made.


                //Which day it was.

                Console.WriteLine("Enter the day...");
                var day = Console.ReadLine();

                Console.WriteLine("Enter the month...");
                var month = Console.ReadLine();

                Console.WriteLine("Enter the year...");
                var year = Console.ReadLine();

                DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                Console.WriteLine("it was a..." + date.DayOfWeek);



                //colour the day app.
                //Console.WriteLine("please enter a day of the week");


                var day2 = DateTime.Now.DayOfWeek.ToString();


                //string input2 = Console.ReadLine();

                switch (day2)

                {
                    case "Saturday":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Today is saturday"); break;
                    case "Sunday":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Today is sunday"); break;
                    case "Monday":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("today is monday"); break;
                    case "Tuesday":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("today is tuesday"); break;
                    case "Wednesday":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("today is wednesday"); break;
                    case "Thursday":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("today is thursday"); break;
                    case "Friday":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("today is friday"); break;
                }
            }
        }
    }
}

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = 0;
            x = rand.Next(1, 13);
            Console.WriteLine("Month : " + x);

            int z = 0;
            x = rand.Next(1, 7);
            Console.WriteLine("Dice : " + z);

            double y = 0;
            y = rand.NextDouble() * 10;
            Console.WriteLine("Random double no is " + Math.Round(y, 2)); //the 2 is the decimal to round up to.
        }
    }
}
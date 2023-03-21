using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumbers;

namespace The_Fundamentals_of_C_Programming_Part_3
{
    class Parse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a letter or number");
            //int x = 3;//theres no need to declare it.
            //int.Parse(Console.ReadLine());//this can crash if you dont enter an interger aka number.
            int.TryParse(Console.ReadLine(), out int x);//the out keyword is part of the tryparse shit here. Aswell as declaration.
            if (x == 0)
            {
                Console.WriteLine("you have entered the wrong input");
            }
            else
            {
                Console.WriteLine("you have entered no " + x);
            }

            //Constants
            const double gravityforce = 9.8;
            double PI = 3.14159265359;

            //gravityforce = 1; //this cant be assigned cos gravityforce has been declared a constant. 

            Console.WriteLine("Gravity Force is " + gravityforce + " and PI is " + PI);


            //String manipulation.

            //indexes.
            string moviename = "    lord of the rings    ";
            Console.WriteLine(moviename[0]);// this is an index.

            //trim
            Console.WriteLine(moviename.Trim());

            //Upper Case.
            Console.WriteLine(moviename.ToUpper().Trim());

            ////Lower Case.
            Console.WriteLine(moviename.Trim().ToLower());

            //Length
            Console.WriteLine(moviename.Length);
            Console.WriteLine(moviename.Trim().Length);

            //Replace
            Console.WriteLine(moviename.Replace("l", "L").Trim());



            //string manipulation 2.

            string tvshow = "game of thrones";

            //index of
            Console.WriteLine(tvshow.IndexOf('o'));//this are all functions of the variable inside writeline.
            //last index of
            Console.WriteLine(tvshow.LastIndexOf('o'));
            //substring
            Console.WriteLine(tvshow.Substring(5, 2));
            //remove
            Console.WriteLine(tvshow.Remove(4));
            //insert
            Console.WriteLine(tvshow.Insert(0, "the "));

            //string exercise.

            string tvshow2 = "game of thrones     ";
            string season1 = "- season 1";
            string newname = "";

            //add - season 1 without determining start index.

            newname = tvshow2.Insert(tvshow.Trim().Length, season1);
            Console.WriteLine(newname);

            //Espape Sequences

            Console.WriteLine("And Jon said \" bend the knee \" "); //this is to add double quatations.
            Console.WriteLine("And Jon said \" bend \t \t \n \a the knee \" ");
            // \t adds a tab \n is new line \a makes sound.
            Console.WriteLine("D:\\Movies");

            //String interpolation.

            string name = "";
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Welcome back" + name);
            Console.WriteLine("Welcome back {0} ", name);
            Console.WriteLine($"Welcome back again {name}");
            //this are various types of interpolations. its a form of string injections.
        }
    }


    class loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("simple loop");
            Console.WriteLine("---------------");

            for (int i = 0; i <= 10; i++)
            {
                //Console.WriteLine("C# rocks");
                Console.WriteLine("The value of i is : " + i);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Count down loop");
            Console.WriteLine("---------------");
            for (int i = 10; i >= 1; i--) //this counts down from starting point 10.
            {
                if (i == 3) break;
                Console.WriteLine("The value of i is : " + i);
            }

            //While loops.
            Console.WriteLine("---------------");
            Console.WriteLine("while Loop");
            Console.WriteLine("---------------");

            int w = 1;
            while (w <= 10)
            {
                if (w == 8) break;
                Console.WriteLine("Games of thrones season 0" + w);
                w++;
            }


            //Do while Loop.
            Console.WriteLine("-----------"); //this is just to separate it.
            Console.WriteLine("Do while Loop");
            Console.WriteLine("---------------");

            int e = 1;
            do
            {
                Console.WriteLine("this is line no." + e); e++;
            } while (e <= 10);


            //nested loops.
            Console.WriteLine("---------------");
            Console.WriteLine("Nested loops");
            Console.WriteLine("---------------");

            for (int r = 1; r <= 10; r++)
            {
                //Console.WriteLine("first loop r = " + r);
                for (int t = 1; t <= 10; t++)
                {
                    //Console.WriteLine("second loop t" + t);
                    Console.Write(0);
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Another nested loop");
            Console.WriteLine("---------------");

            for (int r = 1; r <= 5; r++)
            {
                Console.WriteLine("first loop r = " + r);
                for (int t = 1; t <= 5; t++)
                {
                    Console.WriteLine("second loop t = " + t);
                    //Console.Write(0);
                }
                Console.WriteLine();
            }

            //Loop exercise.
            Console.WriteLine("---------------");
            Console.WriteLine("Exercises of loops");
            Console.WriteLine("---------------");

            //Display even numbers
            for (int y = 0; y < 201; y++)
            {
                if (y % 2 == 0)//if the remainder is zero that means the number is even so display it.
                {
                    Console.Write(y + ", ");
                }
            }
            Console.WriteLine(Environment.NewLine); //enviroment.newline here adds a separation, its just so it looks nicer :).

            //the 0s triangle.
            for (int u = 1; u <= 10; u++)
            {
                for (int o = 1; o <= u; o++) //pay close attention here to the variable u.
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("When counting down from 20 the odd values are: ");
            Console.WriteLine("--------------------------------------------------");

            for (int p = 30; p >= 0; p--)
            {
                if (p % 2 != 0) Console.Write(" " + p);
            }
            Console.WriteLine();
        }
    }
    class maths
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------");
            Console.WriteLine("Maths");
            Console.WriteLine("------------");
            Console.WriteLine();

            double a = 4.6;

            //ceiling
            Console.WriteLine("ceiling: " + Math.Ceiling(a));
            //floor
            Console.WriteLine("floor: " + Math.Floor(a));
            //round
            Console.WriteLine("round : " + Math.Round(a, 1));
            //truncate
            Console.WriteLine("truncate : " + Math.Truncate(a));


            int s = 9;
            int d = 6;
            double p = Math.PI;
            Console.WriteLine();

            //max
            Console.WriteLine("Max : " + Math.Max(s, d));//this are functions of the math method.
            //min
            Console.WriteLine("Min : " + Math.Min(s, d));
            //sqrt
            Console.WriteLine("SQR : " + Math.Sqrt(s));
            //pow
            Console.WriteLine("PWR : " + Math.Pow(3, 2));
            //Pi
            Console.WriteLine("Pi  : " + p);
            //Console.WriteLine("Pi : " + Math.PI()); //this gives an error. why is Pi there for?
            Console.WriteLine();
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
            z = rand.Next(1, 7);
            Console.WriteLine("Dice : " + z);

            double y = 0;
            y = rand.NextDouble() * 10;
            Console.WriteLine("Random double no is " + Math.Round(y, 2));
        }
    }
}


//its noteworthy to point out that you can have just a class by itself with no containing namespace. :/
class Arrays
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5] { 1, 10, 100, 1000, 10000 };

        string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        string[] months = new string[12] { "january", "february", "march", "april", "may",
                "june", "july", "august", "september", "october", "november", "december" };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("---------------");
        foreach (var item in weekdays)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------");

        foreach (var item in months)
        {
            Console.WriteLine(item);
        }
    }
}



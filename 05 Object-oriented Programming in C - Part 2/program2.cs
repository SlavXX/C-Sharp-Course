using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnNamespace.GameOfThrones; //this is from the namespaces lection.

namespace Object_oriented_Programming_in_C_Part_2
{
    class SealedClasses
        //sealed classes are just another form of protection i guess.
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.name = "flu";
            dog.dogBreed = "doberman";
            Console.WriteLine($"dog breed is {dog.dogBreed}");
        }
    }

    //sealed class Animal //this had to omitted for dogs class to work.
    class Animal
    {
        public string name;
    }
    

    class Dogs : Animal // you will need to remove the sealed keyword in order for inheritance to work
    {
        public string dogBreed;
    }

    class StaticClass
        //Static Class only have static members, variables, cannot be copied and are sealed.
    {
        static void Main(string[] args)
        {
            Animal2.GetAge();
        }
    }

    static class Animal2
    {
        static public string name;

        static public void GetAge()
        {
            Console.WriteLine(DateTime.Now.Year - DateTime.Now.AddYears(-4).Year);//this does some kind of math.
        }
    }
    class NestedClasses
        //nested classes are classes inside other classes basically.
    {
        static void Main(string[] args)
        {
            Animal3 animal = new Animal3();
            Animal3.Dogs dog = new Animal3.Dogs();//in order to access the methods of dogs/cats you need to .dogs .cats to it and then they'll be avaliable in the drop menu.
            Animal3.Cats cat = new Animal3.Cats();
            dog.dogNickname = "Puffy";
            cat.catName = "Obi";
            animal.animalCountry = "Portugal";
            
            Console.WriteLine($"{dog.dogNickname} and { cat.catName} and they are from {animal.animalCountry}");
        }
    }

    class Animal3
    {
        public string animalName;
        public string animalCountry;

        public class Dogs //this is a nested class.
        {
            public string dogBreed;
            public string dogNickname;
        }

        public class Cats //this is a nested class.
        {
            public string catName;
        }
    }
    class PartialClasses
        //partial classes are basically different .cs files that can access each other. with the keyword partial in front.
    {
        static void Main(string[] args)
        {
            //Animal4 animal = new Animal4(); //i dont know why it doesnt work. Probably cos the other .cs havent been done during the same session.
            //animal.GetName();
        }
    }
}

namespace Namespaces
    //namespaces are basically a super-class container 
    //the "using" stuff up there are all namespaces.
{
    class namespaces
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            MyOwnNamespace.Animal animal = new MyOwnNamespace.Animal();
            animal.SayHi();
            MyOwnNamespace.GameOfThrones.HouseStark.sayQuote();
            HouseStark.sayQuote();
        }
    }
}

namespace MyOwnNamespace
{
    class Animal
    {
        public string animalColor;
        public void SayHi()
        {
            Console.WriteLine("Hi from the custom namespace");
        }
    }

    class Trainers
    {
    }
    namespace GameOfThrones
    {
        class HouseStark
        {
            public static void sayQuote()
            {
                Console.WriteLine("The north remembers");
            }
        }
    }
}
namespace Structs
{
    class Structs
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.employeeName = "James";
            newEmployee.employeeJob = "Programmer";
            newEmployee.Salary = 5000;
            Console.WriteLine($"Employee name is {newEmployee.employeeName} and his job is {newEmployee.employeeJob} and starting salary is {newEmployee.Salary}");
            newEmployee.SayHi();
        }
    }

    struct Employee
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;

        public decimal Salary
        {   //this are properties, this get set stuff.
            get { return salary; }
            set { salary = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hi from the method in struct");


            //Enumerations.
            //Enumations are there to define lists. Like a list of the days of the week.

            //string weekDayName = WeekDay.Monday //this gives an error, can you see why? the tostring function is necesary.
            string weekDayName = WeekDay.Monday.ToString();
            WeekDay day = WeekDay.Sunday;

            Console.WriteLine(weekDayName);
            Console.WriteLine((int)day); //to access the int value for any enum list, you add int to it.
        }

    }

    enum WeekDay //to create an enum or list you simply type enum.
    {   //as he says it, theres integer value "behind" the enum list.
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 40, //you can even set the int value. here its 40.
        Saturday = 50,
        Sunday = 60
    }
    class ThisKeyword
    //this is a reference to the current instance of a class.
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.DisplayName("James", "Morrison");//this is call to execute the method.
        }
    }

    class Person
    {
        string firstName;
        string lastName;

        public void DisplayName()// public voids are methods.
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void DisplayName(string firstName, string lastName)//an overloaded method.
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(this.firstName + " " + this.lastName);//this refers to the very instance of the class.
        }

        public Person()//this is a constructor cos it has the same name as the class its in.
        {
            firstName = "David";
            lastName = "Smith";
        }
    }
}

namespace interfaces
//Interfaces & exception handling.
{
    class interfaces
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Attack();
            dog.SayHi();
            dog.Run();
        }
    }

    public interface IAnimals
    {
        void Run();
    }

    interface Trainer
    {

    }

    interface IDogCommands : IAnimals
    {
        void Stay(); //only declarations of functions are allowed in interfaces. Try to add more gives error.
        void Sit();
        void Attack();

        string DogName
        {
            get;
            set;
        }
    }

    class Animals
    {
        string AnimalName;

        public void SayHi()
        {
            Console.WriteLine("Hi from the animals class");
        }
    }

    class Dogs : Animals, IDogCommands, Trainer
    {
        private string DogBreed;
        public void Stay()
        {
            Console.WriteLine("Dog staying");
        }
        public void Sit()
        {
            Console.WriteLine("Dog sitting");
        }
        public void Attack()
        {
            Console.WriteLine("Dog attacking");
        }
        public void Run()
        {
            Console.WriteLine("Dog running");
        }

        public string DogName { get; set; }
    }
    //ExceptionHandling
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 0;
            double div = 0;

            try // exceptions are expected to happen. thats why you use try.
            {
                div = x / y;
            }
            catch (Exception e) //this is called handler (of the exception).
            {
                Console.WriteLine("Error is: " + e.Message); //the message call is for seeing what the error is.
            }
            finally //finally is for executing code afterwards.
            {
                Console.WriteLine("Result is " + div);
            }

            //ExceptionExercise

            int firstnumber = 0;
            int secondnumber = 0;
            double divResult = 0;
            startAgain: // it needs the ":".

            try
            {
                Console.WriteLine("Enter first number");
                firstnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                secondnumber = int.Parse(Console.ReadLine());

                divResult = (double)firstnumber / (double)secondnumber;
                Console.WriteLine("Result is " + divResult);
            }
            catch (DivideByZeroException f)
            {
                Console.WriteLine("cannot divide by zero");
                goto startAgain; //makes it go to startAgain line.
            }
            catch (FormatException f) //you can keep adding catches for different exceptions/errors.
            {
                Console.WriteLine("invalid input");
                goto startAgain;

                // finally isnt needed sometimes as you see here.
            }
        }
    }
}












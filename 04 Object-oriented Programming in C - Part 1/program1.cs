using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_Programming_in_C_Part_1
{
    class A
    //object-oriented programming
    {
        static void Main(string[] args)

        {
            //methods part 1
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 3;
            //addResult = a + b;
            Console.WriteLine($" {a} + {b} = {addResult}");
            //Console.WriteLine("The process is done");
            DisplayMessage();   //heres the method being called.
            addResult = PerformAddOperation(a, b);

            c = 5;
            d = 3;
            //addResult = c + d;
            Console.WriteLine($" {c} + {d} = {addResult}");
            //Console.WriteLine("The process is done");
            DisplayMessage();
            addResult = PerformAddOperation(c, d);

        }
        static int PerformAddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            Console.WriteLine($" {x} + {y} = {addResult}");
            DisplayMessage();
            return addResult;
        }

        static void DisplayMessage()    //this is a new method. it will run every time is called.
        {
            Console.WriteLine("process is done");
            Console.WriteLine("this process was run by Salv");
            Console.WriteLine("time:" + DateTime.Now.ToShortTimeString());
        }


        //method exercise. Ask for a name.

        static void ReadOutName()
        {
            GetName(); //this calls the object/function.
        }
        static void GetName()
        {
            string name = string.Empty;
            name = Console.ReadLine();
            SayHi(name);
        }

        static void SayHi(string name)
        {
            Console.WriteLine($" Welcome back {name}");
        }

        static void ReadMessage()
        {
            Console.ReadLine();
        }
    }
    class B
    //object-oriented program
    {
        static void Main(string[] args)
        {
            string firstEmployee, secondEmployee;

            firstEmployee = "David Smith";
            secondEmployee = "Sophia Watson";

            Console.WriteLine($"Inside Main Method\n---------\n{firstEmployee} \n{secondEmployee}\n\n");

            //ChangeNames(firstEmployee, secondEmployee); //this calls the function from within this block.
            //ChangeNames(ref firstEmployee, ref secondEmployee);
            ChangeNames(out firstEmployee, out secondEmployee); //when you use out keyword, you dont need to declare the variables.
            Console.WriteLine($"Inside Main Method\n---------\n{firstEmployee} \n{secondEmployee}\n\n");
        }

        //static void ChangeNames(string firstEmp, string secEmp) //again this is a function.
        //static void ChangeNames(ref string firstEmp, ref string secEmp) //if you use reference keyword it does change the last/output values.
        static void ChangeNames(out string firstEmp, out string secEmp)
        {
            //this is called passing by value, without changing the variables.
            firstEmp = "Olivia Aaron";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method\n---------\n{firstEmp} \n{secEmp}\n\n");

        }
    }
    class C
    //Method Overloaded.
    {
        static void Main(string[] args)

        {

            string guestName = "";
            Console.WriteLine("Hello, dear guest, what is your name?");

            guestName = Console.ReadLine();

            if (guestName == string.Empty)
                WelcomeGuest();
        }

        static void WelcomeGuest()
        {
            Console.WriteLine("Okay, we hope you enjoy your stay");

            //Console.ReadLine();

        }

    }
    class D
    //Overloaded Exercise, add up functions.
    {
        static void Main(string[] args)
        {
            int a, b, c, intResult; //this creates an end-result varible to store the end result.
            double x, y, z, douResult;
            intResult = 0;
            a = 1;
            b = 2;
            c = 3;

            douResult = 0;
            x = 0.50;
            y = 1.50;
            z = 2.0;
            Console.WriteLine(PerformAdd(a, b));// you can add the function name inside the console.writeline together with the variables.
            Console.WriteLine(PerformAdd2(a, b, c));
            Console.WriteLine(PerformAdd3(x, y, z));
        }

        static int PerformAdd(int num1, int num2)// as you can see, you can put different variable names as long as they work, like a is num1, it doesnt matter.
        {
            return num1 + num2;
        }

        static int PerformAdd2(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        static double PerformAdd3(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
    }
    class E
    //Classes
    {
        static void Main(string[] args)
        {
            Person perOne = new Person();//here you can insert it into other classes and use it. This is a constructor.
            perOne.FirstName = "Ahmad";
            perOne.LastName = "Mohey";
            perOne.Country = "Egypt";

            Person perTwo = new Person(); //this is a constructor. They have the same name.
            perTwo.FirstName = "Tim";
            perTwo.LastName = "David";
            perTwo.Country = "Australia";

            Console.WriteLine(perOne.FirstName, perOne.LastName);
            Console.WriteLine(perTwo.FirstName, perTwo.LastName);

        }

        class Person //this is a new class called, you guessed, person.

        {
            string firstName; //to make them visible inside others you gotta add public to it.
            string lastName;
            DateTime birthDate;
            string country;

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public DateTime BirthDate { get; set; }
            public string Country { get; set; }

        }

    }
    class F
    //Datetime exploration.
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();//just press F12 or view/object browser too see stuff.
            Console.WriteLine(date);
            SayHi();//this is the call of the say hi method created after. Didnt want to make more classes.
            Person person = new Person();// for non-static methods i need to create an instance like this first.
            person.SayHi(); //then add the name of the variable followed by the method. which is SayHi here.//this is the say hi from the class "Person"
        }


        //static methods.
        static void SayHi()
        //void SayHi() //if you put this on it wont work. cos its not instanciated/started with static.
        {
            Console.WriteLine("Hi, from the static method");
        }

    }
    class Person
    {
        public void SayHi()
        {
            Console.WriteLine("Hi, from the non-static method");
        }
    }
    class dogs
    //Scope exercise, what scope esencially is, is a methods capacity to be inside and used 
    //in other methods. Thats why sometimes they dont show in the drop down menu.
    {
        string dogname;
        string dogbreed;
        string dogcolor;
        string trainername;

        public void traindog()
        {
            string trainername;
            trainername = "Daniel";

        }
        public void feeddog()
        {
            string foodname;
        }

    }
    class H
    {
        static string name = "Sam";
        static void Main(string[] args)
        {
            SayHi2();
        }
        static void SayHi2()
        {
            name = "Jori"; //this overwrites the static string up there, Sam. Because its been declared locally.
            Console.WriteLine("Hi," + name);

        }
    }
    class inheritance
    //inheritance exercise
    {
        static void Main(string[] args)
        {
            animal animal = new animal();// you can call the variable (in black) anything you want it could be a cat.
            dogs2 dog = new dogs2();//this is constructed the following way. First, the name of the class.
                                  //then the variable name, which is dog, then equals, then the keyword "new" followed
                                  //by the class name again, dogs.
            birds bird = new birds();
            bird.FeedAnimal(); //now FeedAnimal method has been "inherited" or shared basically with other classes.
        }
    }
    class animal
    {
        public string animalName;
        public DateTime animalBirthDate;

        public void FeedAnimal()
        {

        }
    }
    class dogs2 : animal //this is literally what makes inheritance work, just the addition of : followed by the class you want.
    {
        public string dogBreed;
        public string dogIntelligence;
        public bool isEasyToTrain;
    }
    class birds : animal //same again.
    {
        public string birdColor;
        public string birdCountry;
    }
   
    class Encapsulation
        //Encampsulation
    {
        private string privateVariable;
        public string publicVariable;
        protected string protectedVaraible;
        internal string internalVariable;

        private void TrainAnimalPrivate()
        { }
        public void TrainAnimalPublic()
        { }
        protected void TrainAnimalProtected()
        { }
        internal void TrainAnimalInternal()
        { }
    }
    //what encapsulation is all about is about the declaration of different variables, for security purposes.
    //private, protected, internal, see beggining of the video to check what they are.
    class Dogs : Encapsulation
    {
        Dogs dog = new Dogs();

        void FeedDog()//this void method is just an empty, all purposes method that can be created on the fly i believe thus void.
        {

        }
    }

    class Cats
    {
        Encapsulation animal = new Encapsulation();

        void FeedCat()
        {

        }
    }
    class Vehicle
    //vehicle inheritance exercise.
    {
    }

    class WheeledVehicles : Vehicle
    {
        private string color;
        private decimal price;

        public string Color { get; set; }
        public decimal Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine("Color is changing.\nColor has changed");
        }
    }

    class FourWheeledVehicles : WheeledVehicles
    {
        private string brandName;
        private int capacity;

        public string BrandName { get; set; }
        public int Capacity { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Car has started");
        }

        public void RunAtFullSpeed()
        {
            Console.WriteLine("Car is running on full speed");
        }
    }
    class RunVehicleProgram
    {
        static void Main(string[] args)
        {
            FourWheeledVehicles car = new FourWheeledVehicles();
            car.ChangeColor();
            car.StartVehicle();
            car.RunAtFullSpeed();
        }
    }
    class Polymorphism
        //polymorphism means "many forms"
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = new Shapes[4];//this is an array, eventhough we havent studied arrayed he created one with 4 spaces.
            shapes[0] = new Shapes();//this is whats in each array space.
            shapes[1] = new Circles();
            shapes[2] = new Lines();
            shapes[3] = new Triangle();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    class Shapes
    {
        public virtual void Draw()//by putting virtual you tell it that this method can be "overwritten"
        {
            Console.WriteLine("I am a simple shape");
        }
    }

    class Circles : Shapes
    {
        public new void Draw()//this will tell it to repeat shapes. cos its just another "new" shape.
        {
            Console.WriteLine("I am circle");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()//this tells it to override with whatever you tell it to next.
        {
            Console.WriteLine("I am line");
        }
    }

    class Triangle : Shapes
    {
        public override void Draw()//overwrite whatever is the original template, virtual shapes.
        {
            Console.WriteLine("I am triangle");
        }
    }
    class Abstraction
        //im not %100 what abstraction is about.
    {
        static void Main(string[] args)
        {
            Lines2 line2 = new Lines2();
            line2.SayHi();
            line2.Draw();
        }
    }

    abstract class Shapes2
    {
        abstract public void Draw();
        public void SayHi()
        {
            Console.WriteLine("Hi from the abstact class");
        }
    }

    class Lines2 : Shapes2
    {
        public override void Draw()
        {
            Console.WriteLine("Hi I am a line");
        }
    }
    #region //you can section off parts of code with region.
    class CarExercise
        //display values then override them.
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            Volvo volvo = new Volvo();
            mer.DisplayInfo();
            volvo.DisplayInfo();
        }
    }

    class Cars
    {
        #region - you can section off inside classes too. Variables
        private decimal price;
        protected int maxSpeed;
        public string color;
        #endregion
        protected decimal Price//you gotta type this is to use the price in the override field,
            //because its set to private, or it'll give an error, check it.
        {
            get { return price; }
            set { price = value; }
        }

        public virtual void DisplayInfo()//virtual tells it the next things can be overwriten.
        {
            price = 10000;
            maxSpeed = 300;
            color = "Black";
            Console.WriteLine($"Default values : price is {price}, max speed is {maxSpeed} and the color is {color}");
        }
    }

    class Mercedes : Cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();//to snipped/access the functions of the base class just type base.

            base.Price = 15000;
            base.color = "blue";
            base.maxSpeed = 200;
            Console.WriteLine($"Overriden values : price is {Price}, max speed is {maxSpeed} and the color is {color}");
        }
    }
    class Volvo : Cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            base.Price = 5000;
            base.color = "grey";
            base.maxSpeed = 160;
            Console.WriteLine($"Overriden values 2: price is {Price}, max speed is {maxSpeed} and the color is {color}");
        }
    }
    #endregion
}




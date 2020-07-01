using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _08_Advanced_C___Part_3
{
    class Recursive_Method
    {
        static void Main(string[] args)
        {
            int number = 5;

            Console.WriteLine("Non recursive way");
            Console.WriteLine("----------------");
            Console.WriteLine(FactorialNonRecursive(number));

            Console.WriteLine("Recursive way");
            Console.WriteLine("----------------");
            Console.WriteLine(Factorial(number));
        }

        //Non-Recursive way
        public static int FactorialNonRecursive(int n)
        {
            if (n == 0)
                return 1;
            int value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
                Console.WriteLine(i);
            }
            return value;
        }

        // Recursive way
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
    }
    class Recursive_Methods_Exercise_1
    {
        static void Main(string[] args)
        { //displays the folder structure of any path you give it.
            string path = string.Empty;
            path = @"C:\Users\Salv\source\repos\C Sharp Course"; //you can give it any directory as the path variable.
            Console.WriteLine(path);
            DisplayFolders(path, 0); //the 0 represents the indent.
        }

        public static void DisplayFolders(string path, int indent) //this whole method displays the folder structure.
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{ new string(' ', indent)} {Path.GetFileName(folder)}"); //he doesnt get into much detail about what this means.
                DisplayFolders(folder, indent + 2);
            }
        }
    }
    class Optional_Arguments
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformation(7, "Ronaldo", 60, "Portugal", "Real Madrid"); //uses first method.
            DisplayPlayerInformation(10, "Messi", 20); //uses overloaded method.
            DisplayPlayerInformation(9, "Neymar", 30, "Brazil", "Paris FC");//uses first method again.
        }

        public static void DisplayPlayerInformation(int no, string name, int goals = 0, string country = "", string club = "")
        {
            Console.WriteLine("Hi from the first method");
            Console.WriteLine("---------------");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);
            Console.WriteLine();
        }

        public static void DisplayPlayerInformation(int no, string name, int goals)
        /*if i delete this method, it will use the first method.
         * this is whats called an overloaded method, it has the same name.*/
        {

            Console.WriteLine("Hi from the overloaded method");
            Console.WriteLine("---------------");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine();
        }
    }
    class Named_Arguments
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformation(country: "Portugal", playerName: "Ronaldo", playerGoals: 55, playerNo: 7);
            /*by specificaly using names of the paramenters, you can ommit the order in which they are placed in the method.*/
        }
        public static void DisplayPlayerInformation(int playerNo, string playerName, int playerGoals, string country = "Unknown")
        {
            Console.WriteLine(playerNo);
            Console.WriteLine(playerName);
            Console.WriteLine(playerGoals);
            Console.WriteLine(country);
        }
    }
    class Generic_Arguments
    {       //this block displays everything cos its overloaded a number of times.
        static void Main(string[] args)
        {
            DisplayInfo("John"); //Notice here you are using the arguments field to directly place the values in the call. String here.
            DisplayInfo(2); //int here
            DisplayInfo(2.5);// double here.
            DisplayInfo(DateTime.Now); //time here.

            var playerInfo = (7, "Ronaldo", 55);// it also display tuplets.
            DisplayInfo(playerInfo);
        }

        public static void DisplayInfo<T>(T info) //Note the variable type inside is generic. Which lets the method accept any data type.
        {
            Console.WriteLine(info);
        }
    }
    class Params_Keyword
    {
        static void Main(string[] args)
        {
            LoopThroughArray(new string[4] { "Jack", "Tiffany", "Sandra", "Charles" });//this is an old syntax.
            LoopThroughArray("Ahmad", "Martha", "Thomas", "Emmy");// the params allows you to add strings from here directly.
            Console.WriteLine("-------------");
        }

        public static void LoopThroughArray(params string[] names) //params keyword allows it to accept any number of strings.
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Params_Exercise
    {
        static void Main(string[] args)
        {
            LoopThroughArray(10, 50, 25, 3);

            LoopThroughArray("Ahmad", "Ned", "Emma");

            LoopThroughArray(DateTime.Now, new DateTime(2017, 10, 10));
        }

        public static void LoopThroughArray<T>(params T[] items)//writing the T and params keyword here allows it to accept any data type.
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
        }
    }
    class Local_Functions
    {
        static void Main(string[] args)
        {
            PerformMathOperations(1, 2, 3, 4);
            PerformMathOperations(5, 20);
            PerformMathOperations(2, -5, 13, -4, 10);
        }

        public static void PerformMathOperations(params int[] numbers)//params accepts/handles the numbers up there.
        {
            Console.WriteLine("Add = " + AddNumbers());
            int AddNumbers()
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result = result + number; //adds the array items to result variable and stores it in variable, to do this you gotta set it to 0 first.
                }
                return result;
            }

            Console.WriteLine("Multi = " + MultiNumebrs());
            int MultiNumebrs()
            {
                int result = 1;
                foreach (var number in numbers)
                {
                    result = result * number;
                }
                return result;
            }
            Console.WriteLine("----------");
        }
    }
    class Extension_Methods //he means extended methods, that is custom methods.
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x.IsGreater(10));

            string text = "100";
            Console.WriteLine(text.IsNumber());
        }
    }

    static class MyCustom_Extension //this is the custom method or function, they are the drop-down optional methods. Now its avaiable.
    {
        public static bool IsGreater(this int value, int number) //im not sure what the "this" does here. Maybe an instance?
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int result);
        }
    }
    class ExtensionMethod_Exercise_2
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2000, 11, 1); //this is the date to use.
            Console.WriteLine(myDate.MyCustomFormat()); //this is the call.
        }
    }
    static class MyExtensions
    {
        public static string MyCustomFormat(this DateTime date)
        {
            return string.Format("{0:dddd dd MMMM yyyy}", date); //the format which to place the time date.
            return string.Format("{0:dddd dd \nMMMM yyyy}", date); //you can place a new date, but it'll ignore it. wont use it.
        }
    }
    class StopWatch
    {       //this code uses the diagnostics namespace.
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Loop(200_000_000);
            watch.Stop();

            Console.WriteLine("Milliseconds " + watch.Elapsed.Milliseconds);
            Console.WriteLine("Total Milliseconds " + watch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Total Seconds " + watch.Elapsed.TotalSeconds);
            Console.WriteLine("Seconds " + watch.Elapsed.Seconds);
            Console.WriteLine(watch.Elapsed.Ticks);
        }

        public static void Loop(long number)
        {
            for (long i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process done.");
        }
    }
    // void delegate with no argument
    public delegate void PlayerInfoDel();

    // void delegate with one string argument
    public delegate void PlayerInfoWithNameDel(string playerName);

    // void delegate with one string argument and one int
    public delegate void PlayerInfoNameWithGoalsDel(string name, int goals);

    // string delegate with one int argument 
    public delegate string PlayerBasedOnNumber(int number);

    class Delegates
    {
        static void Main(string[] args)
        {
            PlayerInfoDel ronaldinho = new PlayerInfoDel(DisplayInformation);
            //delegate     //variable      new deletegate      //method. Thats how this works.
            ronaldinho(); //this calls the first displaymethod.

            PlayerInfoWithNameDel playerName = new PlayerInfoWithNameDel(DisplayInformation);
            playerName("Messi"); //Another way of writting the same line, but separating the variable.

            PlayerInfoNameWithGoalsDel newPlayer = new PlayerInfoNameWithGoalsDel(DisplayInformation);
            newPlayer("Ronaldo", 60); //detects which variable has a string and int and runs the corresponding display method on them.
            newPlayer("Rooney", 25);
            newPlayer("Almeida", 35);


            PlayerBasedOnNumber number = new PlayerBasedOnNumber(DisplayInformation);
            Console.WriteLine(number(8));
            Console.WriteLine(number(10));
            Console.WriteLine(number(7));
        }
        public static void DisplayInformation()
        {
            Console.WriteLine("Information about player : Ronaldinho from brazil");
        }

        public static void DisplayInformation(string playerName)
        {
            Console.WriteLine("Information about player : " + playerName);
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about player : " + playerName + " and he score " + goals + " goals");
        }

        public static string DisplayInformation(int number)
        {
            string playerName = string.Empty;
            switch (number)
            {
                case 7: playerName = "Ronaldo"; break;
                case 8: playerName = "Iniesta"; break;
                case 10: playerName = "Messi"; break;
                default: break;
            }
            return playerName;
        }
    }
    // void delegate with one string argument and one int
    public delegate void PlayerInformationWithGoals(string playerName, int playerGoals);

    // string delegate with one int argument and one string
    public delegate string PlayerInformationBasedOnNumberAndClub(int playerNo, string club, string country = "Unknown");


    class More_About_Delegates
    {
        static void Main(string[] args)
        {
            PlayerInformationWithGoals playerOne = new PlayerInformationWithGoals(DisplayInformation);
            PlayerInformationBasedOnNumberAndClub playerTwo = new PlayerInformationBasedOnNumberAndClub(DisplayInformation);

            //playerOne("Ronaldo", 50);
            //playerTwo(7, "Real Madrid","Portugal");

            Console.WriteLine(playerTwo.Method); //method keyword get parameters from below and displays them.
            Console.WriteLine("------------");

            foreach (var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.ParameterType.Name}, {item.Name}, {item.Position}, {item.IsOptional}, {item.DefaultValue} ");
                //access and displays each of the parameters in the display method.
                Console.WriteLine("------------");
            }
        }


        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about player : " + playerName + " and he score " + goals);
        }

        public static string DisplayInformation(int number, string club, string country = "Unknown")
        {
            // Some logic goes in here
            Console.WriteLine("Hi...");
            return string.Empty;
        }
    }
    public delegate void DoSomethingDelegate();

    class Delegates_Vs_DirectCalls
    {
        static void Main(string[] args)
        {
            Stopwatch watchOne = new Stopwatch();
            Stopwatch watchTwo = new Stopwatch();
            DoSomethingDelegate taskOne = new DoSomethingDelegate(DoSomething);

            // Using delegates 
            Console.WriteLine("Delegate Method \n--------------");
            watchOne.Start();
            taskOne();
            watchOne.Stop();
            var elapsedOne = watchOne.Elapsed;
            Console.WriteLine(Math.Round(elapsedOne.TotalSeconds, 2));

            // Using direct calls
            Console.WriteLine("\nDirect Method\n--------------");
            watchTwo.Start();
            DoSomething();
            watchTwo.Stop();
            var elapsedTwo = watchTwo.Elapsed;
            Console.WriteLine(Math.Round(elapsedTwo.TotalSeconds, 2)); //truncate to 2 digits.

            Console.WriteLine("\nDelegates saved you " + Math.Round((elapsedTwo.TotalMilliseconds - elapsedOne.TotalMilliseconds), 4) + " milliseconds ");
            Console.WriteLine("Delegates saved you " + Math.Round((elapsedTwo.TotalSeconds - elapsedOne.TotalSeconds), 4) + " seconds ");
        }

        public static void DoSomething()
        {
            double number = 8.543231;
            List<double> list = new List<double>();
            for (double i = 0; i < 60_000_000; i++)
            {
                number += i + DateTime.Now.Second;
                list.Add(number);
            }
            list.Reverse();
        }
    }

    public delegate void DisplayPlayer(Dictionary<int, string> players);

    class Delegate_Exercise_3
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> listofPlayers = new Dictionary<int, string>();
            listofPlayers.Add(7, "Ronaldo");
            listofPlayers.Add(10, "Messi");
            listofPlayers.Add(8, "Iniesta");

            DisplayPlayer player = new DisplayPlayer(DisplayPlayerInfo);
            player(listofPlayers);

        }

        public static void DisplayPlayerInfo(Dictionary<int, string> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player no : {player.Key}, Player name : {player.Value}");
            }
        }
    }
    public delegate void SayHiDelegate();

    class Multicast_Delegate
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;

            sayHi = new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiSpanish);
            sayHi += new SayHiDelegate(SayHiJapanese);
            sayHi += new SayHiDelegate(SayHiItalian);
            sayHi += new SayHiDelegate(SayHiGerman);
            sayHi += new SayHiDelegate(SayHiArabic);

            sayHi();
        }

        // Say hi in English
        public static void SayHiEnglish()
        {
            Console.WriteLine("Hi there.");
        }

        // Say hi in Spanish
        public static void SayHiSpanish()
        {
            Console.WriteLine("Hola.");
        }

        // Say hi in Italian
        public static void SayHiItalian()
        {
            Console.WriteLine("Ciao.");
        }

        // Say hi in German
        public static void SayHiGerman()
        {
            Console.WriteLine("Hallo.");
        }

        // Say hi in Arabic (مرحباً)
        public static void SayHiArabic()
        {
            Console.WriteLine("Marhabaan.");
        }

        // Say hi in Japanese (こんにちは)
        public static void SayHiJapanese()
        {
            Console.WriteLine("Kon'nichiwa");
        }
    }
    public delegate T DisplayInfo<T>(T value); //creates delegate class called displayinfo

    class Generic_Delegates
    {
        static void Main(string[] args)
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayValue); //new instance of class delegate variable named mynumber.
            Console.WriteLine(myNumber(100)); //pass it the value 100 to mynumber variable.

            DisplayInfo<double> myDoubleNumber = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(myDoubleNumber(3.5));

            DisplayInfo<DateTime> myDate = new DisplayInfo<DateTime>(DisplayValue);
            Console.WriteLine(myDate(new DateTime(2010, 2, 28)));
        }

        public static T DisplayValue<T>(T value) //method
        {
            Console.WriteLine("Now we are accessing variable of type " + value.GetType().Name); //display each of the type that the delegate holds.
            return value;
        }
    }
    delegate void DisplayInfo();
    delegate void DisplayInfoBasedOnNumber(int number);

    class Anonymous_Methods
    {
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);
            normalDelegate();

            DisplayInfoBasedOnNumber oneParameterDelegate = new DisplayInfoBasedOnNumber(GetInformation);
            oneParameterDelegate(100);

            Console.WriteLine("----------------------\n");

            DisplayInfo normalDelegateAnonymous = delegate { Console.WriteLine("Hi from the anonymous method"); };
            normalDelegateAnonymous();

            DisplayInfoBasedOnNumber oneParameterDelegateAnonymous =
                delegate (int x) { Console.WriteLine("Hi from the anonymous method which takes one int parameter " + x); };
            oneParameterDelegateAnonymous(150);

        }

        public static void GetInformation()
        {
            // Some logic goes in here
            Console.WriteLine("Delegate with no parameter");
        }

        public static void GetInformation(int x)
        {
            // Some logic goes in here
            Console.WriteLine("Delegate with one parameter : " + x);
        }
    }
    
    delegate void DisplayMessage();
    delegate int Multiply(int n);

    class Lambda_Expression
    {
        static void Main(string[] args)
        {
            //Multiply MultiplyNumber = delegate (int n) { { return n * 3; } };
            Multiply MultiplyNumber = n => n * 3; //this => is the lambda expression.
            Console.WriteLine(MultiplyNumber(60));


            //DisplayMessage Message = delegate { Console.WriteLine("Hi from the anonymous method"); };
            DisplayMessage Message = () => Console.WriteLine("Hi from the lambda expression");
            Message();

        }
    }
    class LambdaWithGenericList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(5); list.Add(8); list.Add(6); list.Add(15);
            list.Add(7); list.Add(2); list.Add(1); list.Add(12);

            var oddList = list.Where(n => n % 2 != 0).ToList();
            var evenList = list.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("Odd Numbers");
            foreach (var item in oddList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Even Numbers");
            foreach (var item in evenList)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Func_Delegate //funcs are build-in generic delegates, that has up to 16 parameters.
    {
        static void Main(string[] args)
        {
            Func<int, int, int> funcOne = AddTwoNumbers; //this is two ways of outcoming the same result.
            Console.WriteLine(AddTwoNumbers(3, 10));

            Func<int> funcTwo = AddTwoNumbers; //this is shorter to write but has a slightly longer class.
            Console.WriteLine(funcTwo());

        }
        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
        public static int AddTwoNumbers()
        {
            int z = 0;
            int x = 5;
            int y = 5;

            z = x + y;

            return z;
        }
    }
    class Action_Delegate //action delegates are the same as the func delegates except they dont return value.
    {
        static void Main(string[] args)
        {
            Action<int> actionOne = DisplayInformation;
            actionOne(16);

            Action actionTwo = DisplayInformation;
            actionTwo();
        }

        public static void DisplayInformation(int number)
        {
            Console.WriteLine("Daniele De Rossi number is " + number);
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Gabriel Batistuta");
        }
    }
    class Predicate_Delegate
    {//not much about the predicates, they return true/false statements.
        static void Main(string[] args)
        {
            Predicate<int> checkIfAvailable = isAdmin;
            Console.WriteLine(checkIfAvailable(50));

            Predicate<int> checkIfAvailable2 = isAdmin;
            Console.WriteLine(checkIfAvailable2(10));
        }

        public static bool isAdmin(int empNo)
        {
            if (empNo == 10)
                return true;
            else
                return false;
        }
    }
    class Func_with_Anonymous_AndLambda
    {
        static void Main(string[] args) //3 ways of doing the same thing.
        {
            string name = "Jack Sparrow";

            //func
            Func<string, string> convertToUpperCase = UppercaseString; /*<string, string> the first string is parameter second is return type
                                                                        UppercaseString: this is the method down there*/
            Console.Write("Using Func ");
            Console.WriteLine(convertToUpperCase(name)); //this is the func and variable "name" used in the same cw line.

            //anonymous
            Func<string, string> anonymousMethod = delegate (string myName) { return myName.ToUpper(); };//func being turned into delegate.
            Console.Write("Using anonymous Method ");
            Console.WriteLine(anonymousMethod(name)); //func delegate and name used at the same time.

            //lambda
            Func<string, string> lambdaExpression = text => text.ToUpper();
            Console.Write("Using lambda Expression ");
            Console.WriteLine(lambdaExpression(name));
        }
        public static string UppercaseString(string inputString)
        {
            return inputString.ToUpper(); //toUpper is the function that turns all upper cases.
        }
    }
    class Action_WithAnonymous_AndLambda
    {
        public static void Main()
        {
            string name = "Jack"; //this is the only variable where if you take it off, it breaks. So its essencial. 
            //Not sure how it assigns names.

            // Action
            Action<string> Message = ShowMessage;
            Message(name);

            // Anonymous method
            name = "John";
            Action<string> anonymousMethod = delegate (string myName) { Console.WriteLine($"Hi, how are you today, {myName}?"); };
            anonymousMethod(name);  //using delegate

            // Lambda expression
            name = "Sandra";
            Action<string> lambdaExpression = x => Console.WriteLine($"Hi, how are you today, {x}?");
            lambdaExpression(name);

        }
        public static void ShowMessage(string name)
        {
            Console.WriteLine($"Hi, how are you today, {name}?");
        }
    }

    public delegate void myDelegate(string holdsname);
    class Events //events are user actions such as keystrokes/mouse clicks and other things.
    {
        public event myDelegate myEvent; //creates an event of myDelegate type and calls it myEvent.

        public Events()
        {
            myEvent += new myDelegate(SayHiEnglish); //creates a new myEvent/delegate with the public void methods as arguments.
            myEvent += new myDelegate(SayHiArabic);
            myEvent += new myDelegate(SayHiItalian);
        }

        static void Main(string[] args)
        {
            Events prog = new Events(); //creates new event called prog.
            prog.myEvent("Jack"); //uses prog myEvent and places "jack" as string.
            Console.WriteLine("--------------");
            prog.myEvent("Steve"); //you can have as many additions of names as you want.
        }

        public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi " + name);
        }

        public void SayHiArabic(string name)
        {
            Console.WriteLine("Marhaaban " + name);
        }

        public void SayHiItalian(string name)
        {
            Console.WriteLine("Caio " + name);
        }
    }

    class MoreEvents
    {
        static void Main(string[] args)
        {
            Football info = new Football(); //new instance of class "football"
            info.DisplayClub("Manchester United", "England"); //info variable using methods inside "football" class, with values/arguments included.
            info.DisplayPlayerInformation("Ronaldo", "Real Madrid"); //gives values here.
        }
    }

    class Football
    {
        private DisplayInformation displayInfoInstance; //creation of DisplayInformation class and instance named displayInfoInstance.

        public Football() //constructor of class football.
        {
            displayInfoInstance = new DisplayInformation(); //initializing the DisplayInformation instance. So new instance.
            /* method can be accessed when you create new instance*/
            displayInfoInstance.DisplayDateAfterEvent += DisplayInfoInstance_DisplayDateAfterEvent; //event handler display. Just Scroll over it.
            /*instance*/       /*event*/       /* += operator*/     /*method*/
            displayInfoInstance.DisplayMessageBeforeEvent += DisplayInfoInstance_DisplayMessageBeforeEvent; //property/function 2.

        }

        private void DisplayInfoInstance_DisplayMessageBeforeEvent() //property/function 1.
        {
            Console.WriteLine("Program is about to display information...");
        }
        private void DisplayInfoInstance_DisplayDateAfterEvent() //property/function 2.
        {
            Console.WriteLine("Information has been displayed on " + DateTime.Now.ToShortTimeString());
        }


        public void DisplayClub(string club, string country) //just a public void. With string/string fields. Returns no value/nothing.
        {
            displayInfoInstance.DisplayClub2(club, country); //this is the call to execute DisplayClub2 method. Manchester from England.
        }
        public void DisplayPlayerInformation(string name, string club)
        {
            displayInfoInstance.DisplayPlayer2(name, club); //Display Ronaldo and from what Club.
        }
    }

    class DisplayInformation
    {
        public delegate void DisplayDateAfterDelegate(); //delegate and variable name. Doest return a value, therefore void.
        public delegate void DisplayMessageBeforeDelegate();
        public event DisplayDateAfterDelegate DisplayDateAfterEvent; //event of type delegate called, DisplayDateAfterEvent.
        public event DisplayMessageBeforeDelegate DisplayMessageBeforeEvent;

        public void DisplayClub2(string clubName, string country) //method 1.
        {
            DisplayMessageBeforeEvent(); //call of the event DisplayInfoInstance_DisplayMessageBeforeEvent.
            Console.WriteLine($"{clubName} from {country}");
            DisplayDateAfterEvent(); //call of the event DisplayInfoInstance_DisplayDateAfterEvent.

            Console.WriteLine("----------------------------"); 
        }

        public void DisplayPlayer2(string playerName, string clubName)  //method 2. Same thing as method 1.
        {
            DisplayMessageBeforeEvent();
            Console.WriteLine($"{playerName} plays for {clubName}");
            DisplayDateAfterEvent();
        }
    }

    class TimerApp
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(); //new timer class called timer.
            timer.Elapsed += OnEachSecond; //recalls the OnEachSecond class.
            timer.Interval = 1000; //original time lapse was 500. So every half second.
            timer.Enabled = true;

            Console.WriteLine("Press (x) to exit");
            while (Console.Read() != 'x'); //exits if you enter X. Plus the enter
        }

        private static void OnEachSecond(object sender, ElapsedEventArgs e) //this was created using a snippet. Tab Tab. From elapsed Method.
        {
            Console.WriteLine("Yes it is working, time now is.. " + DateTime.Now.ToLongTimeString());
        }
    }

    class Expression_bodied_Members
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbers(5, 10));
            Console.WriteLine(AddTwoNumbersFaster(15, 15));
            SayHi();
            Animals dog = new Animals();
            dog.Name = "Max";
            Console.WriteLine(dog.Name);
            dog.Age = 8;
            Console.WriteLine("The dog's age is " + dog.Age);
        }

        public static void SayHi() => Console.WriteLine("Welcome back Walter");

        public static int AddTwoNumbersFaster(int x, int y) => x + y; //lambda operator => makes it faster.

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }

    class Animals
    {
        public Animals() => Console.WriteLine("A new animal has been created!");

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
    }

    class AssignmentNo16
    {
        static void Main(string[] args)
        {
            ShowAllFoldersUnder(@"C:\Users\Salv\source\repos\C Sharp Course", 0);
        }

        private static void ShowAllFoldersUnder(string path, int indent)
        {
            foreach (string folder in Directory.GetDirectories(path))
            {
                files(folder, indent);
                Console.WriteLine("{0}{1}", new string(' ', indent), Path.GetFileName(folder) + " : created on (" + File.GetCreationTime(folder) + ")");
                ShowAllFoldersUnder(folder, indent + 2);
            }
        }

        public static void files(string folder, int indent)
        {
            string[] dirs = Directory.GetFiles(folder);
            //Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
            foreach (string dir in dirs)
            {
                //Console.WriteLine(dir,indent+3);
                Console.WriteLine("{0}{1}", new string(' ', indent), dir + " : created on (" + File.GetCreationTime(dir) + ")");
            }
        }
    }

    class AssignmentNo17
    {
        static void Main(string[] args)
        {
            //string name = "lord of the rings";
            string name = "the quick brown fox jumps over the lazy dog";
            Console.WriteLine(name.CapitalizeFirstLetter());
        }
    }

    public static class MyExtensions2
    {
        public static string CapitalizeFirstLetter(this string value)
        {
            char[] letters = value.ToLower().ToCharArray();
            if (letters.Length >= 1)
            {
                if (char.IsLower(letters[0]))
                {
                    letters[0] = char.ToUpper(letters[0]);
                }
            }
            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i - 1] == ' ')
                {
                    if (char.IsLower(letters[i]))
                    {
                        letters[i] = char.ToUpper(letters[i]);
                    }
                }
            }
            return new string(letters);
        }
    }

    public delegate void MathDelegate(int x, int y);
    class AssignmentNo18
    {
        static void Main(string[] args)
        {
            MathDelegate performMathOperations = null;
            performMathOperations += Add;
            performMathOperations += Multiply;
            performMathOperations += Divide;
            performMathOperations += Substract;
            performMathOperations += Remainder;

            performMathOperations(20, 3);
        }

        public static void Add(int x, int y) => Console.WriteLine($"{x} + {y} = " + (x + y));
        public static void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = " + (x * y));
        public static void Divide(int x, int y) => Console.WriteLine($"{x} / {y} = " + ((double)x / (double)y));
        public static void Substract(int x, int y) => Console.WriteLine($"{x} - {y} = " + (x - y));
        public static void Remainder(int x, int y) => Console.WriteLine($"{x} % {y} = " + (x % y));
    }
}






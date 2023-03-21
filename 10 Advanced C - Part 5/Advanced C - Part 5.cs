using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;
using static System.Math;
using static System.Console; //this is for the StaticDirective lesson.
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Xml.Serialization;

namespace _10_Advanced_C___Part_5
{
    class SpeechSynthesizerApp
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();

            robot.SelectVoiceByHints(VoiceGender.Female);
            robot.Volume = 50;
            robot.Rate = 2;
            robot.SpeakAsync("Hello, What is your name?");
            Console.WriteLine("Hello, What is your name?");
            var name = Console.ReadLine();
            robot.SpeakAsync("Hello " + name);
            Console.WriteLine("Hello " + name);

            Console.ReadLine();

            robot.SetOutputToWaveFile(@"c:\sounds\app.wav");
            robot.Speak("Application is complete, please visit us again");
        }
    }

    class SpeakMethodExercise
    {
        static void Main(string[] args)
        {
            string name = "Wilson";
            name.Speak();
        }
    }

    static class Extensions
    {
        public static void Speak(this string objectToSpeak)
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();
            robot.Speak(objectToSpeak);
        }
    }

    class StartingAndStoppingProcess
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");
            //Process.Start(@"C:\");
            //Process.Start("chrome.exe");
            //Process.Start("devenv.exe");
            //Process.Start("https://www.facebook.com");

            Process[] notepads = Process.GetProcessesByName("notepad");
            foreach (var process in notepads)
            {
                process.Kill();
            }
        }
    }
    class NotePadExercise
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText(@"C:\Files\notepadExercise.txt", "Hello from the notepad exercise");
            System.Diagnostics.Process.Start(@"C:\Files\notepadExercise.txt");
        }
    }

    class MultidimensionalArrays
    {
        static void Main(string[] args)
        {
            string[,] Array2D = new string[3, 2]; //the [,] denotes that its a 2D Array, with 3 rows and 2 columns
            Array2D[0, 0] = "Item 00"; //this just adds items, manually into the array
            Array2D[0, 1] = "Item 01";
            Array2D[1, 0] = "Item 10";
            Array2D[1, 1] = "Item 11";
            Array2D[2, 0] = "Item 20";
            Array2D[2, 1] = "Item 21";

            int[,] Array2DA = new int[4, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } }; //hes inputting the values directely here.
            string[,] NumbersArray = new string[,] { { "One", "Two" }, { "Three", "Four" }, { "Five", "Six" }, { "Seven", "Eight" }, { "Nine", "Ten" } };

            //foreach (var item in NumbersArray)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Now we are accessing ROW no " + i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Now we are acessing COLUMN " + j);
                    Console.WriteLine("the value is: " + NumbersArray[i, j]);
                }
            }


            Console.WriteLine();
        }
    }

    class MultidimensionalArraysExercise
    {
        static void Main(string[] args)
        {
            string[,] array = new string[4, 4];
            array[0, 0] = "Item00";
            array[0, 1] = "Item01";
            array[0, 2] = "Item02";
            array[1, 0] = "Item10";
            array[1, 1] = "Item11";
            array[1, 2] = "Item12";
            array[2, 0] = "Item20";
            array[2, 1] = "Item21";
            array[2, 2] = "Item22";

            Console.WriteLine("\tColumn 1 \tColumn 2 \tColumn 3");
            Console.WriteLine("\t------- \t------- \t-------");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Row " + (i + 1));
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("\t");
                    Console.Write(array[i, j]);
                    Console.Write("\t");
                    if (j == 2)
                        Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }

    class JaggedArrays
    {
        static void Main(string[] args)
        {    // a jagged array is an array that indexes other arrays.
            int[][] jaggedArrayOne = new int[3][]; // it can compromise of other types of arrays.
            jaggedArrayOne[0] = new int[5] { 0, 1, 2, 3, 4 };
            jaggedArrayOne[1] = new int[2] { 10, 20 };
            jaggedArrayOne[2] = new int[3] { 1, 3, 5 };

            int[][] jaggedArrayTwo = {
            new int[] { 0,1,2,3,10,200},
            new int[] { 10,20,30,40,50,500,5000}
            };

            //Console.WriteLine(jaggedArrayTwo[1][4]);

            for (int i = 0; i < jaggedArrayTwo.Length; i++)
            {
                Console.WriteLine("Now acessing array number " + i);
                for (int j = 0; j < jaggedArrayTwo[i].Length; j++)
                {
                    Console.WriteLine(jaggedArrayTwo[i][j]);
                }
            }

            Console.WriteLine();
        }
    }

    class JaggedMultidimensionalExercise
    {
        static void Main(string[] args)
        {
            int[][,] jaggedMultiArray = new int[3][,];

            jaggedMultiArray[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            jaggedMultiArray[1] = new int[3, 2] { { 10, 10 }, { 20, 20 }, { 30, 30 } };
            jaggedMultiArray[2] = new int[2, 2] { { 3, 5 }, { 1, 2 } };
            Console.WriteLine();
        }
    }

    class IndexersApp
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();

            animals[0] = "Dog";
            animals[1] = "Tiger";
            animals[2] = "Horse";

            Console.WriteLine(animals[2]);
        }
    }

    class Animals
    {
        private string[] name = new string[100];

        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }

    class DynamicKeyword
    {
        static void Main(string[] args)
        {
            dynamic value = 0;
            Console.WriteLine("Value is " + value);
            Console.WriteLine("Value type is " + value.GetType().Name);
            Console.WriteLine();

            value = "Game of Thrones";
            Console.WriteLine("Value is " + value);
            Console.WriteLine("Value type is " + value.GetType().Name);
            Console.WriteLine();

            value = new Animals2();
            value.Name = "Dog";
            Console.WriteLine("Value is " + value.Name);
            Console.WriteLine("Value type is " + value.GetType().Name);
            Console.WriteLine();

        }
    }

    class Animals2
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class ReadonlyKeyword
    {
        static void Main(string[] args)
        {
            Animals3 dog = new Animals3("Dog");
            Console.WriteLine(dog.AnimalName);

            dog = new Animals3("Another Dog");
            Console.WriteLine(dog.AnimalName);

        }
    }

    class Animals3
    {
        readonly private string animalName;

        public string AnimalName
        {
            get => animalName;
        }

        public Animals3(string name)
        {
            animalName = name;
        }
    }

    class StaticDirectives
    {
        static void Main(string[] args)
        {
            WriteLine(Round(2.5465, 2));
        }
    }

    class PreprocessorDirectives
    {
        static void Main(string[] args)
        {
            int x;
            /*
               #define #if  #else #endif #warning #error #pragma warning disable 
            */

#if(underDev)
            Console.WriteLine("This app is under development");
//#error This app is not yet finished Oh my God this is so amaaazing
#else
            Console.WriteLine("This app is Complete");
#warning This app is complete and ready to be published
#endif
            //you can disable warnings as well using this methodology.
        }
    }

    class IsNullOrEmptyApp
    {
        static void Main(string[] args)
        {
            string name = " ";
            if (name == "" || name is null)
                Console.WriteLine("Empty");
            else
                Console.WriteLine("Has a value");

            if (string.IsNullOrWhiteSpace(name))
                Console.WriteLine("Empty");
            else
                Console.WriteLine("Has a value");
        }
    }

    class DestructorsApp
    {
        static void Main(string[] args)
        {
            Animals4 dog = new Animals4();
            var name = Console.ReadLine();
        }
    }

    class Animals4
    {
        public Animals4()
        {
            Console.WriteLine("A new animal is created");
        }

        ~Animals4() //the ~ is used to destroy an object.
        {
            Console.WriteLine("Animal object is about to be destroyed");
        }
    }

    class UsingStatement
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(@"c:\files\heroes.txt"))
            {
                sw.WriteLine("Superman");
                sw.WriteLine("Batman");
                sw.WriteLine("Wonder Woman");
                sw.WriteLine("Aquaman");
                sw.WriteLine("Flash");
            }
        }
    }

    class AssembliesApp
    {
        static void Main(string[] args)
        {
            Assembly assemObject = Assembly.GetEntryAssembly();
            AssemblyName assemName = assemObject.GetName();

            Console.WriteLine(assemName.Name);
        }
    }

    class CultureInfoApp
    {
        static void Main(string[] args)
        {
            Assembly assemObject = Assembly.GetEntryAssembly();
            AssemblyName assemName = assemObject.GetName();

            Console.WriteLine(assemName.FullName);

            Console.WriteLine(assemName.CultureName);
            CultureInfo cultureInfo = new CultureInfo("en-GB");
            assemName.CultureInfo = cultureInfo;
            Console.WriteLine(assemName.CultureInfo.DisplayName);
            Console.WriteLine(assemName.CultureInfo.NativeName);
            Console.WriteLine(assemName.CultureInfo.NumberFormat.CurrencySymbol);
            Console.WriteLine(assemName.CultureInfo.Calendar);
        }
    }

    class VersionsApp
    {
        static void Main(string[] args)
        {
            Assembly assemObject = Assembly.GetEntryAssembly();
            AssemblyName assemName = assemObject.GetName();

            Console.WriteLine(assemName.FullName);

            Console.WriteLine(assemName.CultureName);
            CultureInfo cultureInfo = new CultureInfo("en-GB");
            assemName.CultureInfo = cultureInfo;
            Console.WriteLine(assemName.CultureInfo.DisplayName);
            Console.WriteLine(assemName.CultureInfo.NativeName);
            Console.WriteLine(assemName.CultureInfo.NumberFormat.CurrencySymbol);
            Console.WriteLine(assemName.CultureInfo.Calendar);

            Console.WriteLine(assemName.Version);
            assemName.Version = new Version(2, 0, 0, 0);
            Console.WriteLine(assemName.Version);
        }
    }

    class RegionInfoApp
    {
        static void Main(string[] args)
        {
            RegionInfo info = new RegionInfo("AE");

            Console.WriteLine(info.DisplayName);
            Console.WriteLine(info.IsMetric);
            Console.WriteLine(info.CurrencyEnglishName);
            Console.WriteLine(info.ThreeLetterISORegionName);
        }
    }

}

namespace _10_Advanced_C___Part_5_part2
{

    class AttributesApp
    {
        static void Main(string[] args)
        {
            Persons.SayHi();
            Persons.SayHello();
            Persons.DisplayMessage("We are in the debugging mode");
        }
    }

    class Persons
    {
        [Obsolete("This method is not going to be included in the upcoming versions", false)]
        //this is the use of the "Obsolete" attribute. //Notice how it gives a warning set to false.
        public static void SayHi()
        {

        }

        public static void SayHello()
        {

        }

        [Conditional("DEBUG")]
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class Developer : System.Attribute
    {
        private string developerName;
        private bool isReviewed;
        private string message;

        public Developer(string developerName, bool isReviewed, string message)
        {
            this.developerName = developerName;
            this.isReviewed = isReviewed;
            this.message = message;
        }

        public string DeveloperName
        { get => developerName; set => developerName = value; }

        public bool IsReviewed
        { get => isReviewed; set => isReviewed = value; }

        public string Message
        { get => message; set => message = value; }
    }

    class CustomAttributes
    {
        static void Main(string[] args)
        {

        }
    }

    [Developer("Ahmad Mohey", false, "This need to be finished by next friday")]
    class Animals5
    {

    }

    class ReflectionsApp 
        //this is only a partial entry point of the lesson,
        //it uses the previous lesson text.
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(Animals5);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }
    }

    class SerializationAndDeserialization
    {
        static void Main(string[] args)
        {
            string xmlText = string.Empty;
            List<Employees> listOfEmployees = new List<Employees>
            {
                new Employees { EmployeeID=1150, FirstName="Jack",LastName="Steven", Salary=5000m, Age=35,Appraisal = new List<int>{7,7,8,9,7} },
                new Employees { EmployeeID=1150, FirstName="Debora",LastName="Watson", Salary=10000m, Age=45,Appraisal = new List<int>{9,9,8,9,8} },
                new Employees { EmployeeID=1150, FirstName="Claire",LastName="Adam", Salary=7500m, Age=32,Appraisal = new List<int>{9,7,8,9,7} },
                new Employees { EmployeeID=1150, FirstName="Michael",LastName="Rob", Salary=3500m, Age=22,Appraisal = new List<int>{6,7,8,7,7} },
                new Employees { EmployeeID=1150, FirstName="Matthew",LastName="Forest", Salary=4500m, Age=28,Appraisal = new List<int>{7,7,6,6,7} },
                new Employees { EmployeeID=1150, FirstName="Charles",LastName="Kris", Salary=8000m, Age=27,Appraisal = new List<int>{8,9,7,8,8} },
                new Employees { EmployeeID=1150, FirstName="Robert",LastName="Wilson", Salary=8000m, Age=28,Appraisal = new List<int>{8,9,8,9,9} },
                new Employees { EmployeeID=1150, FirstName="Emma",LastName="Brooks", Salary=6000m, Age=23,Appraisal = new List<int>{8,6,9,9,7} },
                new Employees { EmployeeID=1150, FirstName="Jennifer",LastName="Blake", Salary=3000m, Age=38,Appraisal = new List<int>{6,7,7,6,6} },
                new Employees { EmployeeID=1150, FirstName="Terry",LastName="Loyd", Salary=9000m, Age=49,Appraisal = new List<int>{9,9,9,8,7} },
                new Employees { EmployeeID=1150, FirstName="Adam",LastName="Spencer", Salary=7000m, Age=33,Appraisal = new List<int>{8,8,8,6,7} },
                new Employees { EmployeeID=1150, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} }
            };

            XmlSerializer xmlWriter = new XmlSerializer(typeof(List<Employees>)); //this is a serializer class.
            using (StringWriter sw = new StringWriter()) //a stringwriter class that uses the following code.
            {
                xmlWriter.Serialize(sw, listOfEmployees); //this is what does the job.
                xmlText = sw.ToString();
                Console.WriteLine(sw.ToString());
                Console.WriteLine();
            }

            //Deserialization: It means turning text back into a List.
            XmlSerializer xmlReader = new XmlSerializer(typeof(List<Employees>));
            using (StringReader sr = new StringReader(xmlText)) //reads the text.
            {
                List<Employees> tempList = (List<Employees>) //this casts xmlReader.Deserialize(sr);
                                                             //into a List called tempList.
                    xmlReader.Deserialize(sr);

                foreach (var employee in tempList)
                {
                    Console.WriteLine(employee.EmployeeID);
                    Console.WriteLine(employee.FirstName);
                    Console.WriteLine(employee.Age);
                    Console.WriteLine(employee.Salary);
                    Console.WriteLine("--------------");
                }
            }
        }
    }

    [Serializable()]
    public class Employees
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private decimal salary;
        private int age;

        private List<int> appraisal;
        [XmlElement("EmployeeNumber")] //this is an attribute.
                                       //It changes "EmployeeID" to "EmployeeNumber"

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
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
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        //[XmlIgnore] //this is like a decorator in python. Again, an attribute.
        //this time the ignore Xml.
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        [XmlIgnore]
        public List<int> Appraisal
        {
            get { return appraisal; }
            set { appraisal = value; }
        }
        public Employees()
        {

        }
    }
    class GUIDApp

    {
        static void Main(string[] args)
        {
            Guid g = new Guid();
            Console.WriteLine(g); //he doesnt explain exatly why this Guid is "empty"

            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);

            guid = Guid.NewGuid();
            Console.WriteLine(guid);
        }
    }

    class StringBuilderApp
    {  //lesson is about the stringbuild construct, it plays with strings basically.
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder(10, 50);
            builder.Append(" Jon welcome back again");
            Console.WriteLine(builder);
            builder.Insert(5, "Snow ");
            builder.Insert(0, "Hello");
            Console.WriteLine(builder);
            builder.Remove(0, 5);
            Console.WriteLine(builder);
            //builder.Replace('o', '0');
            builder.Replace('o', '0', 4, 8);
            //builder.Replace("Jon Snow","Ned Stark");
            Console.WriteLine(builder);
            string text = builder.ToString();
            Console.WriteLine(text);
        }
    }

    class PatternMatchingApp
    {
        static void Main(string[] args)
        {
            Dog max = new Dog();
            max.DogName = "Max";
            Lion simba = new Lion();
            Snake solidSnake = new Snake();
            Lizard liz = new Lizard();
            AnimalSound(solidSnake);
            AnimalSoundWithSwitchAndWhen(max);
            AnimalSoundWithSwitch(simba);
            AnimalSoundWithSwitch(solidSnake);
            AnimalSoundWithSwitch(liz);

        }

        // using IS
        public static void AnimalSound(object animal)
        {
            if (animal is Dog)
                Console.WriteLine("Woof");
            else if (animal is Cat)
                Console.WriteLine("Meow");
            else if (animal is Lion)
                Console.WriteLine("Roarrrrr");
            else if (animal is Duck)
                Console.WriteLine("Quack");
            else if (animal is Snake)
                Console.WriteLine("Snakes are actually mute :D");
            else
                Console.WriteLine("Unknown animal");

        }
        // using SWITCH
        public static void AnimalSoundWithSwitch(object animal)
        {
            switch (animal)
            {
                case Dog d: Console.WriteLine("Woof"); break;
                case Cat c: Console.WriteLine("Meow"); break;
                case Lion l: Console.WriteLine("Roar"); break;
                case Duck u: Console.WriteLine("Quack"); break;
                case Snake s: Console.WriteLine("Snake is mute"); break;
                default: Console.WriteLine("Unknown animal"); break;
            }
        }
        // using SWITCH and WHEN
        public static void AnimalSoundWithSwitchAndWhen(object animal)
        {
            switch (animal)
            {
                case Dog d when d.DogName == null: Console.WriteLine("Name is not set"); break;
            }
        }
    }


    class Dog
    {
        // Woof Woof
        public string DogSound { get; set; }
        public string DogName { get; set; }
    }

    class Cat
    {
        // Meow Meow
        public string CatSound { get; set; }
        public string CatName { get; set; }
    }

    class Lion
    {
        //Roar
        public string LionSound { get; set; }
        public string LionName { get; set; }
    }

    class Duck
    {
        // Quack
        public string DuckSound { get; set; }
        public string DuckName { get; set; }
    }
    class Snake
    {
        // Silent
        public string SnakeSound { get; set; }
        public string SnakeName { get; set; }
    }
    class Lizard
    {

    }

    class RefLocalRefReturn
    {
        static void Main(string[] args)
        {
            int X1 = 3;
            ref int X2 = ref X1; //this is for ref local.

            //X1 = 100;
            Console.WriteLine(X1);
            Console.WriteLine(X2);

            ref var returnValue = ref ReturnByReference();
            Console.WriteLine(returnValue);
        }

        public static ref string ReturnByReference()
        {
            string[] arrayOfNames = { "Ella", "Liz", "Eve", "Claire" };
            return ref arrayOfNames[0]; //just by adding ref to return, it makes it
                                        //return the value itself.
        }
    }

    class IEnumerableApp
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = from value in Enumerable.Range(1, 10)
                                      select value;

            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            double avg = result.Average();
            Console.WriteLine(avg);

            List<int> list = result.ToList(); //converts to list method.
            int[] array = result.ToArray(); //converts to array, using ToArray method.

            list.Add(11);list.Add(12);list.Add(13);list.Add(14);list.Add(15);list.Add(100);

            Console.WriteLine("What is in the list now");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            result = list.AsEnumerable();
            Console.WriteLine("What is in the ienumrable now");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");

            IEnumerator<int> enumrator = list.GetEnumerator();
            while (enumrator.MoveNext())
            {
                Console.WriteLine(enumrator.Current);
            }
        }
    }

    class YieldKeywordApp
    {
        static void Main(string[] args)
        {
            foreach (var item in PerformMathOperations(3, 2))
            {
                Console.WriteLine(item);
            }

        }

        public static IEnumerable<double> PerformMathOperations(int numberOne, int numberTwo)
        {
            yield return numberOne + numberTwo;
            yield return numberOne * numberTwo;
            yield return numberOne - numberTwo;
            yield return Math.Round(((double)numberOne / (double)numberTwo), 2);
        }
    }

    class Program
    {
        // Multidimensional Arrays Assignment
        static void Main(string[] args)
        {
            int RowsNumber = 25;
            int ColumnsNumber = 7;
            int offset = 0;
            string[,] Array2D = new string[RowsNumber, ColumnsNumber];

            #region FillArrayManually
            //Array2D[0, 0] = "R0C0";
            //Array2D[0, 1] = "R0C1";
            //Array2D[0, 2] = "R0C2";
            //Array2D[1, 0] = "R1C0";
            //Array2D[1, 1] = "R1C1";
            //Array2D[1, 2] = "R1C2";
            //Array2D[2, 0] = "R2C0";
            //Array2D[2, 1] = "R2C1";
            //Array2D[2, 2] = "R2C2";
            //Array2D[3, 0] = "R3C0";
            //Array2D[3, 1] = "R3C1";
            //Array2D[3, 2] = "R3C2";
            //Array2D[5, 3] = "R5C3";
            //Array2D[6, 2] = "R6C2";
            //Array2D[10, 1] = "R10C1";
            //Array2D[10, 2] = "R10C2";
            //Array2D[10, 3] = "R10C3";
            //Array2D[10, 4] = "R10C4";
            //Array2D[10, 5] = "R10C5";
            //Array2D[9, 5] = "R9C5";
            //Array2D[8, 5] = "R8C5";
            //Array2D[11, 5] = "R11C5";
            //Array2D[10, 6] = "R10C6";
            //Array2D[12, 6] = "R12C6";
            //Array2D[14, 5] = "R14C5";
            //Array2D[15, 1] = "R15C1";
            //Array2D[15, 2] = "R15C2";
            #endregion

            #region FillArrayAutomatically
            FillArrayAutomatically(Array2D, RowsNumber, ColumnsNumber, offset);
            #endregion

            ShowInRowsAndColumnsFormat(Array2D, RowsNumber, ColumnsNumber, offset);

        }

        #region Methods Sections
        public static void FillArrayAutomatically(dynamic array2D, int row, int column, int numberOffset)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array2D.GetType().Name == "String[,]")
                        array2D[i, j] = "R" + (i + numberOffset) + "C" + (j + numberOffset);
                }
            }
        }

        public static void ShowInRowsAndColumnsFormat(dynamic array2D, int row, int column, int numberOffset)
        {
            for (int i = 0; i < column; i++)
            {
                Console.Write("\tColumn " + (i + numberOffset));
            }
            Console.WriteLine();
            for (int i = 0; i < column; i++)
            {
                Console.Write("\t--------");
            }
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                Console.Write("Row " + (i + numberOffset));
                for (int j = 0; j < column; j++)
                {
                    Console.Write("\t");
                    Console.Write(array2D[i, j]);
                    Console.Write("\t");
                    if (j == (column - 1))
                        Console.WriteLine();
                }
            }
        }
        #endregion

        class AssignmentNo23
        {
            // Multidimensional Arrays Assignment
            static void Main(string[] args)
            {
                int RowsNumber = 25;
                int ColumnsNumber = 7;
                int offset = 0;
                string[,] Array2D = new string[RowsNumber, ColumnsNumber];

                #region FillArrayManually
                //Array2D[0, 0] = "R0C0";
                //Array2D[0, 1] = "R0C1";
                //Array2D[0, 2] = "R0C2";
                //Array2D[1, 0] = "R1C0";
                //Array2D[1, 1] = "R1C1";
                //Array2D[1, 2] = "R1C2";
                //Array2D[2, 0] = "R2C0";
                //Array2D[2, 1] = "R2C1";
                //Array2D[2, 2] = "R2C2";
                //Array2D[3, 0] = "R3C0";
                //Array2D[3, 1] = "R3C1";
                //Array2D[3, 2] = "R3C2";
                //Array2D[5, 3] = "R5C3";
                //Array2D[6, 2] = "R6C2";
                //Array2D[10, 1] = "R10C1";
                //Array2D[10, 2] = "R10C2";
                //Array2D[10, 3] = "R10C3";
                //Array2D[10, 4] = "R10C4";
                //Array2D[10, 5] = "R10C5";
                //Array2D[9, 5] = "R9C5";
                //Array2D[8, 5] = "R8C5";
                //Array2D[11, 5] = "R11C5";
                //Array2D[10, 6] = "R10C6";
                //Array2D[12, 6] = "R12C6";
                //Array2D[14, 5] = "R14C5";
                //Array2D[15, 1] = "R15C1";
                //Array2D[15, 2] = "R15C2";
                #endregion

                #region FillArrayAutomatically
                FillArrayAutomatically(Array2D, RowsNumber, ColumnsNumber, offset);
                #endregion

                ShowInRowsAndColumnsFormat(Array2D, RowsNumber, ColumnsNumber, offset);

            }

            #region Methods Sections
            public static void FillArrayAutomatically(dynamic array2D, int row, int column, int numberOffset)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (array2D.GetType().Name == "String[,]")
                            array2D[i, j] = "R" + (i + numberOffset) + "C" + (j + numberOffset);
                    }
                }
            }

            public static void ShowInRowsAndColumnsFormat(dynamic array2D, int row, int column, int numberOffset)
            {
                for (int i = 0; i < column; i++)
                {
                    Console.Write("\tColumn " + (i + numberOffset));
                }
                Console.WriteLine();
                for (int i = 0; i < column; i++)
                {
                    Console.Write("\t--------");
                }
                Console.WriteLine();

                for (int i = 0; i < row; i++)
                {
                    Console.Write("Row " + (i + numberOffset));
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write("\t");
                        Console.Write(array2D[i, j]);
                        Console.Write("\t");
                        if (j == (column - 1))
                            Console.WriteLine();
                    }
                }
            }
            #endregion
        }
    }

    class AssignmentNo24
    {
        //JaggedMultidimensionalExercise
        static void Main(string[] args)
        {
            // Assignment 24 - create jagged array of multuidimemal arrays with any type and sizes and access its data
            var multiJaggedArray = new object[3][,];

            multiJaggedArray[0] = new object[2, 2] { { "Superman", "Clarck Kent" }, { "Batman ", "Bryce Wayne" } };
            multiJaggedArray[1] = new object[3, 2] { { 10, 10 }, { 20, 20 }, { 30, 30 } };
            multiJaggedArray[2] = new object[2, 2] { { 3.5, 5.75 }, { 1.25, 3.67 } };


            foreach (var item in multiJaggedArray)
            {
                Console.WriteLine(item);
                for (int i = 0; i < item.GetLength(0); i++)
                {
                    for (int j = 0; j < item.GetLength(1); j++)
                    {
                        Console.Write(item[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

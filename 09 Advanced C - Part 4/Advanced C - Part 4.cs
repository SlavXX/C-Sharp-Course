using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Collections.Concurrent;
using System.Threading;


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
            //number = 5; //this can be switched with the null, thats the gist of this lesson.

            int numberTwo = 10;

            Console.WriteLine(number ?? numberTwo);

            string firstName = null;
            firstName = "John";

            string message = null;
            message = "first name is null";

            Console.WriteLine(firstName ?? message);
        }
    }

    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            //if (IsAdmin())
            //{
            //    Console.WriteLine("yes he is an admin");
            //}
            //else
            //{
            //    Console.WriteLine("Not an admin");
            //}

            Console.WriteLine(IsAdmin() ? "Yes an admin" : "No not an admin"); //? is the ternary operator, its for writing if statements quickly.
        }

        public static bool IsAdmin()
        {
            return false;
        }
    }
    class ConditionalOperatorExercise
    {   //if its even or odd program
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Even Number" : "Odd Number");
        }
    }

    class SafeNavigationOperator
    {
        static void Main(string[] args)
        {
            Cars bmwM3 = new Cars();
            bmwM3.Brand = "BMW";
            bmwM3.Model = "M3";
            bmwM3.Price = 60_000;

            Cars mercedesAmgGt = new Cars();
            mercedesAmgGt.Brand = "Mercedes";
            mercedesAmgGt.Model = "AMG GT";
            mercedesAmgGt.Price = 150_000;

            Cars porscheCarreraGT = new Cars();
            porscheCarreraGT.Brand = "Porsche";
            porscheCarreraGT.Model = "Carrera GT";
            porscheCarreraGT.Price = 500_000;

            Cars ferrariEnzo = new Cars();
            //ferrariEnzo.Brand = "Ferrari";
            //ferrariEnzo.Model = "Enzo";
            //ferrariEnzo.Price = 2_500_000;

            Console.WriteLine("Car Information");
            Cars.DisplayCarDetails(bmwM3);
            Cars.DisplayCarDetails(porscheCarreraGT);
            Cars.DisplayCarDetails(mercedesAmgGt);
            Cars.DisplayCarDetails(ferrariEnzo);


            List<Cars> listofCars = new List<Cars>();
            //List<Cars> listofCars = null;
            listofCars.Add(bmwM3);
            listofCars.Add(mercedesAmgGt);
            listofCars.Add(porscheCarreraGT);
            //listofCars.Add(ferrariEnzo);

            int? count = 0;
            count = listofCars?.Count;
            Console.WriteLine(count);
        }
    }

    class LINQMethodSyntax
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
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

            Employees.DisplayWithAppraisal(listOfEmployees, "All Employees");

            //Salary is greater than or equal to 6000 and age greater than 40
            filteredList = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40).ToList();

            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000
            filteredList = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40 || e.Salary >= 8000).ToList();

            //foreach (var employee in listOfEmployees)
            //{
            //    if (employee.Salary >= 6000 && employee.Age >= 40)
            //        Console.WriteLine(employee.FirstName);
            //}

            foreach (var employee in filteredList)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.WriteLine();
        }
    }

    class LINQQuerySyntaxExercise
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
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

            Employees.DisplayWithAppraisal(listOfEmployees, "All Employees");


            //Apparisal less than 8 and salary greater than  4000
            filteredList = (from emp in listOfEmployees
                            where emp.Salary > 4000 && emp.Appraisal[0] < 8
                            select emp).ToList();
            Employees.DisplayWithAppraisal(filteredList, "Employees with apprisal less than 8 and salary higher than 4000");
        }
    }

    class SortingDataUsingLINQ
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
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

            Employees.DisplayWithAppraisal(listOfEmployees, "All Employees");

            filteredList = (from emp in listOfEmployees
                            orderby emp.Age descending, emp.Appraisal[0]
                            select emp).ToList();

            Employees.DisplayWithAppraisal(filteredList, "Employees after sorting");
        }
    }

    class LINQQueriesWithMethods
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
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

            Employees.DisplayWithAppraisal(listOfEmployees, "Before Sorting");

            Employees.DisplayWithAppraisal(SortEmployees(listOfEmployees), "After Sorting");


        }


        public static List<Employees> SortEmployees(List<Employees> employees)
        {
            var list = from emp in employees
                       orderby emp.Age descending
                       select emp;
            return list.ToList();
        }
    }

    class TimeSpanApp
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(26, 10, 15);
            Console.WriteLine(ts.TotalHours);

            ts = ts.Add(new TimeSpan(0, 0, 30));
            Console.WriteLine(ts);

            DateTime myDateOne = new DateTime(1990, 10, 30);
            DateTime myDateTwo = new DateTime(2017, 10, 30);

            TimeSpan sub = myDateTwo - myDateOne;
            sub = myDateTwo.Subtract(myDateOne);
            Console.WriteLine(sub.TotalDays / 365.25);
        }
    }
}

// 192 Introduction to Multithreading

namespace _09_Advanced_C___Part_4_part2
{
    class CreatingThreads
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "Thread Number 1 (English)";
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Thread Number 2 (Spanish)";
            t2.Start();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " Hi...");
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " Hola...");
            }
        }
    }
    class ManagingThreads
    {
        static Thread t1;
        static Thread t2;
        static void Main(string[] args)
        {
            t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "Thread Number 1 (English)";
            t1.Start();

            t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Enlace Numero 2 (Spanish)";
            t2.Start();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Starting to execute. " + Thread.CurrentThread.Name);

            for (int i = 0; i < 25; i++)
            {
                //Thread.Sleep(1000);
                //if (i == 31)
                //{
                //    Console.WriteLine(Thread.CurrentThread.Name + " is about to be aborted");
                //    t1.Abort();
                //}
                Console.WriteLine(i + " Hi...");
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Empezando a ejecutar. " + Thread.CurrentThread.Name);
            for (int i = 0; i < 25; i++)
            {
                t1.Join();
                //Thread.Sleep(new TimeSpan(0, 0, 1));
                Console.WriteLine(i + " Hola...");
            }
        }
    }

    class ThreadsExercise1
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(() => //this is the lambda expression
            Console.WriteLine("Hello from lambda expression")));
            t1.Start(); //starts the thread.
        }
    }

    class ThreadsExercise2
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello from the anonymous method assigned to the t1 thread");
                }
            }));
            t1.Start();
        }
    }
    class WithMultithreading
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 1 started");
                Console.WriteLine("Process 1 is running");
                for (long i = 0; i < 2_500_000_000; i++)
                { }
                Console.WriteLine("Process 1 has been completed \n");
            }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 2 started");
                Console.WriteLine("Process 2 is running");
                for (long i = 0; i < 5_000_000_000; i++)
                { }
                Console.WriteLine("Process 2 has been completed \n");
            }));
            t2.Start();

            Thread t3 = new Thread(new ThreadStart(delegate ()
            {
                Thread.Sleep(1);
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name + " welcome back");
            }));
            t3.Start();
        }
    }

    public delegate void loopOne();
    public delegate void loopTwo();
    public delegate void loopThree();
    class WithoutMultithreading
    {
        static void Main(string[] args)
        {
            loopOne loop1 = (delegate ()
            {
                Console.WriteLine("Process 1 started");
                Console.WriteLine("Process 1 is running");
                for (long i = 0; i < 2_500_000_000; i++)
                { }
                Console.WriteLine("Process 1 has been completed \n");
            });
            loop1();

            loopTwo loop2 = (delegate ()
            {
                Console.WriteLine("Process 2 started");
                Console.WriteLine("Process 2 is running");
                for (long i = 0; i < 5_000_000_000; i++)
                { }
                Console.WriteLine("Process 2 has been completed \n");
            });
            loop2();

            loopThree loop3 = (delegate ()
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name + " welcome back");
            });
            loop3();
        }
    }

    class ParameterizedThreadApp
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
            t1.Start(500);
        }
    }

    class Helper
    {
        public void Loop(object number)
        {
            for (int i = 0; i < int.Parse(number.ToString()); i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Deadlocks
    {
        static void Main(string[] args)
        {
            Files file = new Files(); //this is a class below there.
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"c:\\accounts{i}.txt.." + " NOT!");
                //doesnt really write into files.
            }
        }
    }

    class Files
    {
        public Object thisLock = new Object();
        public void Write(object path)
        {
            lock (thisLock) //this is what makes access the following code at a time.
            {
                // some logic of writing in files goes in where
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("Writing process has been completed");
            }
        }

        public void Read(object path)
        {
            lock (thisLock)
            {
                // some logic of writing in files goes in here
                Console.WriteLine("Reading from " + path);
                Thread.Sleep(1000);
                Console.WriteLine("Reading process has been completed");
            }
        }
    }

    class MonitorClassApp
    {   //this lesson is about monitor class, just read the help of dropdown.
        static void Main(string[] args)
        {
            Files2 file = new Files2();
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"c:\\accounts{i}.txt");
            }
        }
    }

    class Files2
    {
        public void Write(object path)
        {   
            Monitor.Enter(path); //this is the critical part of the code.
            try   //notice how he uses try, to try catch error if theres one
            {
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("Writing process has been completed");
            }
            finally
            {
                Monitor.Exit(path); //Exits monitor Class object.
            }
        }

        public void Read(object path) //name of object here is 'path'.
        {
            Console.WriteLine("Reading from " + path);
            Thread.Sleep(1000);
            Console.WriteLine("Reading process has been completed\n");
        }
    }

    class MutexApp
    {
        private static Mutex mut = new Mutex();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    for (int d = 0; d < 2; d++)
                    {
                        UseResource();
                    }
                }));
                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();
            }
        }

        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);
            mut.WaitOne();

            Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
            Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

            mut.ReleaseMutex();
            Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);
        }
    }

    class SemaphoreApp
    {
        private static Semaphore semaphore = new Semaphore(2, 2);
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    for (int d = 0; d < 1; d++)
                    {
                        UseResource();
                    }
                }));
                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();
            }
        }

        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting to enter", Thread.CurrentThread.Name);
            semaphore.WaitOne();

            Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
            Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

            semaphore.Release();
            Console.WriteLine("{0} has left the critical section", Thread.CurrentThread.Name);
        }
    }
}

// 204 Introduction to Asynchronous Programming

namespace _09_Advanced_C___Part_4_part3
{
    class TasksApp
    {
        static void Main(string[] args)
        {   //hover over the text to see what each does.
            Task task = new Task(new Action(SayHi));
            task.Start();

            Task task2 = new Task(delegate ()
            {
                Console.WriteLine("Task 2 is starting");
                Console.WriteLine("Task 2 is running");
                Console.WriteLine("Hi there from task 2");
                Thread.Sleep(7000);
                Console.WriteLine("Task 2 is complete");
            });
            task2.Start();

            Task task3 = new Task(() =>
            {
                Console.WriteLine("Task 3 is starting");
                Console.WriteLine("Task 3 is running");
                Console.WriteLine("Hi there from task 3");
                Thread.Sleep(7000);
                Console.WriteLine("Task 3 is complete");
            });
            task3.Start();

            Console.WriteLine("What is your name");
            var name = Console.ReadLine();
            Console.WriteLine("Welcome back " + name);

            Console.ReadLine();
        }

        public static void SayHi()
        {
            Console.WriteLine("Task 1 is starting");
            Console.WriteLine("Task 1 is running");
            Console.WriteLine("Hi there from task 1");
            Thread.Sleep(5000);
            Console.WriteLine("Task 1 is complete");
        }
    }

    class TasksWithParameters
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(new Action<object>(SayHi), "Jennifer");
            task1.Start();

            Task task2 = new Task(delegate (object name)
            {
                Console.WriteLine("Welcome back " + name);
            }, "Ahmad");
            task2.Start();

            Task task3 = new Task(n => { Console.WriteLine("Welcome back " + n); }, "Jack");
            task3.Start();

            Console.ReadLine();
        }

        public static void SayHi(object name)
        {
            Console.WriteLine("Welcome back " + name);
        }
    }

    class TasksWithReturnValue
    {
        static void Main(string[] args)
        {
            Task<int> task = new Task<int>(() => //this is a lambda expression.
            {
                int result = 0;
                for (int i = 1; i <= 4; i++)
                {
                    result += i;
                    Console.WriteLine(i);
                }
                return result;
            });
            task.Start();
            Console.WriteLine(task.Result);
            Console.ReadLine();
        }
    }

    class CheckingTasksStatus
    {
        static System.Timers.Timer timer;
        static Task task;
        static void Main(string[] args)
        {
            task = new Task(() =>
            {
                for (int i = 1; i <= 500; i++)
                {
                    Console.WriteLine(i);
                }
            });
            task.Start();

            timer = new System.Timers.Timer();
            timer.Elapsed += CheckTheTask; //this links the timer with the method.
            timer.Interval = 100;
            timer.Enabled = true;

            Console.ReadLine();
        }

        private static void CheckTheTask(object sender, ElapsedEventArgs e)
        {
            if (task.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task is running.....");
            }
            else if (task.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Task is complete!");
                timer.Enabled = false;
            }
        }
    }

    class CancellingTasks
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = new Task(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task is cancelled!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(i + 1);
                    }
                }
                Console.WriteLine("Task is Complete!");
            });

            task.Start();

            //Thread.Sleep(3000);
            //cancellationTokenSource.Cancel();
            cancellationTokenSource.CancelAfter(5000);

            Console.ReadLine();
        }
    }

    class WaitingForTasks
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() =>
            {
                Console.WriteLine("Task 1 started");
                Console.WriteLine("Task 1 running...\n");
                Thread.Sleep(8000);
                Console.WriteLine("Task 1 finished!");
            });
            t1.Start();
            t1.Wait();

            Task t2 = new Task(() =>
            {
                Console.WriteLine("Task 2 started");
                Console.WriteLine("Task 2 running...\n");
                Thread.Sleep(6000);
                Console.WriteLine("Task 2 finished!");
            });
            t2.Start();
            t2.Wait();

            Task t3 = new Task(() =>
            {
                Console.WriteLine("Task 3 started");
                Console.WriteLine("Task 3 running...\n");
                Thread.Sleep(2000);
                Console.WriteLine("Task 3 finished!");
            });
            t3.Start();

            Task.WaitAll(t3);
        }
    }

    class TaskRunApp
    {
        static void Main(string[] args)
        {
            SayHiTask();

            AddNumbersTask(10, 2, 12);

            Console.ReadLine();
        }

        private static Task SayHiTask()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Hi there from the task");
            });
        }

        public static Task AddNumbersTask(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Add numbers task started...");
                int result = 0;
                foreach (var number in numbers)
                {
                    result += number;
                }
                Console.WriteLine("Total = " + result);
            });
        }
    }
    class AsyncAwaitApp
    {
        static string processConnectToDatabase = "(Connecting to database)";
        static string processGetDataFromDatabase = "(Getting data from database)";

        static void Main(string[] args)
        {
            Console.WriteLine("First we are inside the main method.");
            RunProcess(1, 1_000_000);

            var dbTask = ConnectToDatabaseProcessAndGetData();
            Console.WriteLine("Back to the main method.");
            if (dbTask.Status == TaskStatus.RanToCompletion)
                Console.WriteLine($"Process {processConnectToDatabase} is completed.");
            else
                Console.WriteLine($"Process {processConnectToDatabase} is NOT completed.");

            RunProcess(2, 1_000_000);
            RunProcess(3, 1_000_000);
            RunProcess(4, 1_000_000);

            Console.ReadLine();
        }

        public static async Task ConnectToDatabaseProcessAndGetData()
        {
            Console.WriteLine($"\nControl is with process {processConnectToDatabase}.");
            Console.WriteLine($"Process {processConnectToDatabase} has started.");
            Console.WriteLine($"Process {processConnectToDatabase} is running...");
            await Task.Run(() =>
            {
                Console.WriteLine("Start executing process in the await section.");
                Thread.Sleep(7000);
                RunProcess(10, 100000);
                Console.WriteLine("\nProcess in the await section is complete!");
            });
            Console.WriteLine($"\nProcess {processConnectToDatabase} is complete!");
            Console.WriteLine($"Control is with process {processGetDataFromDatabase} again");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Getting data..... " + i);
            }
            Console.WriteLine($"Process {processGetDataFromDatabase} is complete!");
        }


        private static void RunProcess(int processNumber, int processLoopCondition)
        {
            Console.WriteLine("\nControl is with process " + processNumber);
            Console.WriteLine($"Process ({processNumber}) has started.");
            Console.WriteLine($"Process ({processNumber}) is running...");
            for (int i = 1; i <= processLoopCondition; i++)
            {
            }
            Console.WriteLine($"Process ({processNumber}) is complete!");
            Console.WriteLine("\nControl is back to main method.");
        }
    }

    class ConcurrentBagApp
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("Thread (1) has started");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Thread (1) added number " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread (1) is complete!");
            });

            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("Thread (2) has started");
                for (int i = 11; i <= 25; i++)
                {
                    Console.WriteLine("Thread (2) added number " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread (2) is complete!");
            });

            Thread t3 = new Thread(() =>
            {
                t1.Join();
                t2.Join();
                Console.WriteLine("Thread (3) has started");
                foreach (var item in bag)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Thread (3) is complete!");
            });

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }

    class AssignmentNo19
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
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

            Employees.DisplayWithAppraisal(listOfEmployees, "All Employees", true);

            // New
            //Salary is greater than or equal to 6000 and age greater than 40
            filteredList = (from emp in listOfEmployees
                            where emp.Salary >= 6000 && emp.Age > 40
                            select emp).ToList();
            Employees.DisplayWithAppraisal(filteredList, "Salary is greater than or equal to 6000 and age greater than 40", true);

            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000
            filteredList = (from emp in listOfEmployees
                            where emp.Salary >= 6000 && emp.Age > 40 || emp.Salary >= 8000
                            select emp).ToList();
            Employees.DisplayWithAppraisal(filteredList, "Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000", true);

            //Exercise
            //Apparisal less than 8 and salary greater than  4000
            filteredList = (from emp in listOfEmployees
                            where emp.Salary > 4000 && emp.Appraisal[0] < 8
                            select emp).ToList();

            Employees.DisplayWithAppraisal(filteredList, "Apparisal less than 8 and salary greater than 5000", true);
            //
        }
    }
    class AssignmentNo20
    {
        static void Main(string[] args)
        {
            SayHi hi = new SayHi(); string name = "Ahmad"; int count = 2;
            List<Thread> listofThreads = new List<Thread>();

            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiEnglish(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiKorean(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiFrench(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiGreek(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiHindi(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiRussian(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiSwedish(name, count))));

            foreach (var thread in listofThreads)
            {
                thread.Start();
            }
        }
    }

    class SayHi
    {
        public void SayHiEnglish(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hi " + name);
            }
        }

        public void SayHiKorean(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Annyeong " + name);
            }
        }
        public void SayHiFrench(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Salut " + name);
            }
        }

        public void SayHiGreek(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Geia " + name);
            }
        }

        public void SayHiHindi(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Namaste " + name);
            }
        }

        public void SayHiRussian(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Zdravstvuy " + name);
            }
        }

        public void SayHiSwedish(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hej " + name);
            }
        }
    }

    class AssignmentNo21
    {
        static Task t1;
        static Task t2;
        static void Main(string[] args)
        {
            int loopConditionCount = 10;
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task t1 = new Task(() =>
            {
                int max = 0;
                for (int i = 1; i <= loopConditionCount; i++)
                {
                    if (token.IsCancellationRequested)
                        break;
                    else
                    {
                        Console.WriteLine($"Task One run number {i} ");
                        max = i;
                    }
                }
                Console.WriteLine();
                if (max == loopConditionCount)
                    Console.WriteLine("TASK ONE IS COMPLETE!");
                else
                {
                    Console.WriteLine("Task One is cancelled");
                    Console.WriteLine("Task One Maximum " + max);
                }
                cancellationTokenSource.Cancel();
            });

            t2 = new Task(() =>
            {
                int max = 0;
                for (int i = 1; i <= loopConditionCount; i++)
                {
                    if (token.IsCancellationRequested)
                        break;
                    else
                    {
                        Console.WriteLine($"Task Two run number {i} ");
                        max = i;
                    }
                }
                Console.WriteLine();
                if (max == loopConditionCount)
                    Console.WriteLine("TASK TWO IS COMPLETE!");
                else
                {
                    Console.WriteLine("Task Two is cancelled");
                    Console.WriteLine("Task Two Maximum " + max);
                }
                cancellationTokenSource.Cancel();
            });

            t1.Start();
            t2.Start();

            Task.WaitAll(t1, t2);
        }
    }

    class AssignmentNo22
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            int threadThreeAccessCounter = 0;
            int threadFourAccessCounter = 0;

            Thread t1 = new Thread(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    stack.Push(i);
                }
            });
            t1.Start();

            Thread t2 = new Thread(() =>
            {
                for (int i = 11; i <= 20; i++)
                {
                    stack.Push(i);
                }
            });
            t2.Start();

            Thread t3 = new Thread(() =>
            {
                int stackValue = 0;
                foreach (int item in stack)
                {
                    stack.TryPop(out stackValue);
                    if (stackValue != 0)
                    {
                        Console.WriteLine("Now Thread (3) is accessing " + stackValue);
                        threadThreeAccessCounter++;
                    }

                }
            });
            t3.Start();

            Thread t4 = new Thread(() =>
            {
                int stackValue = 0;
                foreach (int item in stack)
                {
                    stack.TryPop(out stackValue);
                    if (stackValue != 0)
                    {
                        Console.WriteLine("Now Thread (4) is accessing " + stackValue);
                        threadFourAccessCounter++;
                    }
                }
            });
            t4.Start();

            Thread.Sleep(10);
            Console.WriteLine("\nThread (3) accessed " + threadThreeAccessCounter);
            Console.WriteLine("Thread (4) accessed " + threadFourAccessCounter);
        }
    }
}

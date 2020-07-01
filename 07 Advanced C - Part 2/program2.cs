using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Advanced_C___Part_2
{
    class Non_Generic_ArrayList
    {
        static void Main(string[] args)
        {
            //creating
            ArrayList array = new ArrayList(); //creates an arraylist named "array".

            //adding
            //array.Add("first"); //this adds to the arraylist the string "first".
            //array.Add("second");
            array.Add("james");
            array.Add("david");
            array.Add("charles");
            array.Add("ahmad");
            //array.Add(3); //this ones had to be dismissed for sorting down there to work. arraylist only takes same types.
            //array.Add(4.5d);

            Console.WriteLine("----------");
            Console.WriteLine("NAMES");
            Console.WriteLine("----------");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");
            Console.WriteLine("after insertion");
            Console.WriteLine("count is " + array.Count); //this would be 4 indexes.
            array.Insert(2, "tim"); //this inserts the value string "tim" into arraylist index number 2. erasing the previous.
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //index
            Console.WriteLine("-------");
            Console.WriteLine(array[0].ToString()); //tells it to display index 0 in arraylist.

            //capacity
            Console.WriteLine("-------");
            Console.WriteLine("count is " + array.Count); //tells it to count the index numbers, how many in the array.

            //sorting
            Console.WriteLine("-------");
            array.Sort();
            Console.WriteLine("after sorting");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //reversing
            Console.WriteLine("-------");
            array.Reverse(); //this method reverses the order of the array indexes. figures.
            Console.WriteLine("after reversing");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //removing
            Console.WriteLine("-------");
            //array.Remove("james"); //this method removes the "james" from the arraylist.
            array.RemoveAt(2); //takes an index number to remove, removes "david".
            Console.WriteLine("after removing");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //remove all
            Console.WriteLine("-------");
            //array.Clear(); //this method clears/removes all in the array.
            Console.WriteLine("after removing some");
            array.RemoveRange(1, 2); //removes a range of indexes, so from 1 to 2.
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //contains
            Console.WriteLine("-------");
            Console.WriteLine("after asking if it contains");
            Console.WriteLine(array.Contains("tim")); //it asks if theres an item in arraylist named "tim". returns a boolean.
            Console.WriteLine(array.Contains("james"));

            //getRange
            Console.WriteLine("-------");
            Console.WriteLine("getrange method");
            ArrayList names = new ArrayList(); //new arraylist for getrange only.
            names = array.GetRange(0, 2); /*tells it to add index 0 to 2 from the array up there and assign it to variable "names"
                                          so from one array to another. */
            foreach (var item in names)
            {
                Console.WriteLine(names); //this displays System.Collections.ArrayList+Range.
                Console.WriteLine(item);
            }
        }
    }
    class Non_Generic_HashTable
    {
        static void Main(string[] args)
        {
            //creating
            Hashtable hash = new Hashtable();

            //adding
            hash.Add("microsoft", "USA");
            hash.Add("sony", "japan");
            hash.Add("ikea", "sweden");
            hash.Add("mercedes", "germany");

            //displaying
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            //capacity
            Console.WriteLine("count is " + hash.Count);

            //remove
            Console.WriteLine("--------------");
            Console.WriteLine("after removing");
            hash.Remove("ikea"); //this removes from hashtable string "ikea".
            foreach (DictionaryEntry item in hash) //dictionaryEntry has to be used here for hash.remove to work.
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //contains
            Console.WriteLine("--------------");
            Console.WriteLine("contains condition");

            if (hash.Contains("sony")) //you can place the hash.contains query/method inside an if statement.
            {
                Console.WriteLine("yes the collection has sony");
            }
            else
            {
                Console.WriteLine("no it does not have it");
            }

            Console.WriteLine("--------------");
            if (hash.Contains("panasonic")) //same shit but for the else condition.
            {
                Console.WriteLine("yes the collection has sony");
            }
            else
            {
                Console.WriteLine("no it does not have it");
            }

            //copy to ArrayList
            Console.WriteLine("--------------");
            Console.WriteLine("after copying");
            //ArrayList array = new ArrayList(hash.Values); //you can place the hastable values here directly with hash.
            ArrayList array = new ArrayList(hash.Keys);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Non_Generic_SortedList
    {
        static void Main(string[] args)
        {
            // Creating
            SortedList sortedList = new SortedList();

            // Adding
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");

            // Displaying

            //foreach
            foreach (DictionaryEntry item in sortedList) //read description, hover mouse over it.
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            //for
            for (int i = 0; i < sortedList.Count; i++) //tells it to increment by 1 for each of places in the sortlist.
            {
                Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
            }

            // Index
            Console.WriteLine(sortedList[5].ToString()); //i guess it asks for the values stored.

            // Capacity
            Console.WriteLine(sortedList.Count);

            // Remove

            //sortedList.Remove(1);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // Contains
            Console.WriteLine(sortedList.ContainsValue("Apr")); //returns back a boolean value, true in this case.

            // Copy to ArrayList
            Console.WriteLine("Now we are inside the array list");
            ArrayList array = new ArrayList(sortedList.Values);
            foreach (var item in array) //the var here is so that the loop knows what to loop.
            {
                Console.WriteLine(item);
            }
        }
    }
    class Non_Generic_Stacks_Queues_BitArrays
    {
        static void Main(string[] args)
        {
            //STACKS represent a last-in first-out (LIFO) collection object.
            Console.WriteLine("----------");
            Console.WriteLine("STACKS");
            Console.WriteLine("----------");
            //creating
            Stack stack = new Stack();

            //adding
            stack.Push("david");
            stack.Push("emmy");
            stack.Push("jack");
            stack.Push("emmy");

            //removing
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            //QUEUES represent a first-in first-out collection object.
            Console.WriteLine("----------");
            Console.WriteLine("QUEUES");
            Console.WriteLine("----------");

            //creating
            Queue queue = new Queue();

            //adding
            queue.Enqueue("cavin");
            queue.Enqueue("tom");
            queue.Enqueue("emma");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //removing         
            Console.WriteLine("removing");
            Console.WriteLine();
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            //BITARRAYS represent a compact array of bit values. Which are represented as booleans.
            Console.WriteLine("----------");
            Console.WriteLine("BITARRAYS");
            Console.WriteLine("----------");

            //creating
            bool[] boolArray = new bool[4];
            boolArray[0] = true;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;

            BitArray firstArray = new BitArray(4);
            BitArray SecondArray = new BitArray(boolArray); //you pass it the variable name.

            //setting values
            firstArray.Set(0, true);
            firstArray.Set(1, false);
            firstArray.Set(2, false);
            firstArray.Set(3, true);

            foreach (var item in firstArray)
            {
                Console.WriteLine(item);
            }

            //AND or OR, NOT
            BitArray result = new BitArray(4);
            result = firstArray.And(SecondArray); //you pass it the array that you want the AND method applied to. Compares the two arrays.
            Console.WriteLine("----------");
            Console.WriteLine("AND");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            result = firstArray.Or(SecondArray); //you pass it the array that you want the OR method applied to.
            Console.WriteLine("----------");
            Console.WriteLine("OR");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            result = firstArray.Not(); //it does not need the name of a second array.
            Console.WriteLine("----------");
            Console.WriteLine("NOT");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
    class AnimalsAndTrainers_Exercise1 //exercise 1.
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Max";

            Animals cat = new Animals();
            cat.Name = "Lucy";

            Animals elephant = new Animals();
            elephant.Name = "Fofy";

            Trainers john = new Trainers();
            john.TrainerName = "John Jackson";

            ArrayList list = new ArrayList();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);
            list.Add(john);

            foreach (var item in list)
            {
                if (typeof(Animals) == item.GetType()) //this gettype distinguiges structures. So if it isnt Animals struct then its the other.
                {
                    ((Animals)item).SayHi(); //you gotta put the animals struct first then, item, then method name. Its the correct syntax.
                    ((Animals)item).Feed();
                }
                else
                {
                    ((Trainers)item).SayHi();
                }
            }
        }
    }
    struct Animals
    {
        private string name;

        public string Name //you can type snipet "propfull" and double tab to get the snippet.
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello my name is " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is now eating");
        }
    }
    struct Trainers
    {
        private string trainerName;
        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }
        public void SayHi()
        {
            Console.WriteLine("Hello I am the new trainer");
        }
    }
    class Generic_List
    {
        //Lists are the same as arraylists except that these collections are generic, meaning data must be of all the same type.
        static void Main(string[] args)
        {
            // Creating    
            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>(); //you can create them either using list or Ilist. Same thing.

            // Adding
            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");
            firstList.Add("Egypt");

            // Displaying
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Index
            firstList[2] = "South Korea"; //this replaces string in index 2.
            //Console.WriteLine(firstList[2]);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Capacity
            Console.WriteLine("Count is " + firstList.Count);

            // Sorting
            Console.WriteLine("------------");
            Console.WriteLine("After Sorting...");
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Reversing
            //Console.WriteLine("After Reversing...");
            firstList.Reverse();
            //foreach (var item in firstList)
            //{
            //    Console.WriteLine(item);
            //}

            // Removing
            Console.WriteLine("------------");
            Console.WriteLine("After Removing...");
            firstList.Remove("Germany");
            firstList.RemoveAt(0);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count now is " + firstList.Count);

            // Remove all
            //firstList.Clear();

            // Contains
            Console.WriteLine("------------");
            Console.WriteLine(firstList.Contains("Egypt")); //show true or false if it contains Egypt.

            // GetRange
            secondList = firstList.GetRange(0, 3); //getrange from first list and place in secondlist by index.
            Console.WriteLine("Now we are in the second list");
            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Generic_Dictionary
    {
        static void Main(string[] args)
        {
            // Creating
            Dictionary<string, string> capitals = new Dictionary<string, string>(); //creates a dictionary data with two fields type string.

            // Creating with initialization
            Dictionary<int, string> names = new Dictionary<int, string>() //another dictiionary of different field type.
            {
                { 1,"James"},
                { 2,"Jack"},
                { 3,"Emma"},
            };

            Console.WriteLine("---------");
            Console.WriteLine("NAMES");
            Console.WriteLine("---------");
            foreach (var item in names)
            {
                Console.WriteLine(item.Value); //displays value i guess.               
            }
            Console.WriteLine("---------");

            // Add
            capitals.Add("Russia", "Moscow"); //this adds the key and value, in this case "russia" is the key and "moscow" is the value.
            capitals.Add("Italy", "Rome");
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "Berlin");

            //Displaying
            Console.WriteLine("DISPLAYING");
            Console.WriteLine("---------");
            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key); //displays capital cities.
            }

            Console.WriteLine("---------");
            Console.WriteLine("DISPLAYING 2");
            Console.WriteLine("---------");

            for (int i = 0; i < capitals.Count; i++) //lenght = capitals.count. Grab the lenght from counting the number of indexes in dictionary.
            {
                Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
                //Console.WriteLine(capitals.Values.ElementAt(i)); //this is the same as the line above.


                //Console.WriteLine(capitals[capitals.Values.ElementAt(i)]);
                /*this gives an error cos it looks up in the keys and doest find it, cos its using Values as a searh query.
                 * eventhough the error finder doesnt highlight it.
                 */
            }

            // Index
            Console.WriteLine("--------");
            capitals["Italy"] = "Venice"; //this is how you tell it to add "venice" as value for the key "italy" in capitals dictionary.
            Console.WriteLine("whats in italy?");
            Console.WriteLine(capitals["Italy"]);

            //Capacity
            Console.WriteLine("--------");
            Console.WriteLine("Capacity");
            Console.WriteLine("--------");
            Console.WriteLine(capitals.Count);
            Console.WriteLine("--------");

            // Try get value
            capitals.TryGetValue("Russia", out string result);
            if (result != null)
                Console.WriteLine("Result is " + result);

            // Remove
            capitals.Remove("Italy");
            Console.WriteLine("--------");
            Console.WriteLine("After removing");
            Console.WriteLine("--------");

            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
            }

            // Remove all
            //capitals.Clear();

            // Contains
            Console.WriteLine("--------");
            Console.WriteLine("contains france?");
            Console.WriteLine("--------");
            Console.WriteLine(capitals.ContainsKey("France"));
        }
    }

    class Generic_SortedList
    {
        static void Main(string[] args)
        {
            // Creating
            SortedList sortedList = new SortedList();

            // Adding
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");

            // Displaying

            //foreach
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //for
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
            }

            // Index
            Console.WriteLine(sortedList[5].ToString());

            // Capacity
            Console.WriteLine(sortedList.Count);

            // Remove

            //sortedList.Remove(1);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // Contains
            Console.WriteLine(sortedList.ContainsValue("Apr"));

            // Copy to ArrayList
            Console.WriteLine("Now we are inside the array list");
            ArrayList array = new ArrayList(sortedList.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Generic_SortedDictionary
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> colors = new SortedDictionary<int, string>();

            colors.Add(4, "Blue");
            colors.Add(2, "Yellow");
            colors.Add(1, "Orange");
            colors.Add(5, "Black");
            colors.Add(3, "White");

            Console.WriteLine("-----------");
            foreach (var item in colors)
            {
                Console.WriteLine(item.Value);
            }

            colors[2] = "Purple";

            Console.WriteLine("-----------");
            foreach (var item in colors)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("-----------");
            Console.WriteLine("After Removing");
            colors.Remove(1); //removes the first index, so color orange.
            Console.WriteLine("-----------");
            foreach (var item in colors)
            {
                Console.WriteLine(item.Value);
            }

            colors.Clear();
        }
    }
    class Generic_Stacks
    {               //stacks represent a last-in first-out collection of objects. 
        static void Main(string[] args)
        {
            Stack<string> Ram = new Stack<string>();

            Ram.Push("Visual Studio");
            Ram.Push("Photoshop");
            Ram.Push("Google Chrome");
            Ram.Push("NotePad");
            Ram.Push("Excel");

            Console.WriteLine("What is on the top is " + Ram.Peek());
            Ram.Pop();
            Ram.Pop();
            Console.WriteLine("--------------");
            Console.WriteLine("What is on the top is " + Ram.Peek());
            foreach (var item in Ram)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Generic_Queues //represents a first-in first-out collection of objects.
    {
        static void Main(string[] args)
        {
            Queue<DateTime> arrivals = new Queue<DateTime>();

            arrivals.Enqueue(new DateTime(2017, 01, 01));
            arrivals.Enqueue(new DateTime(2016, 10, 27));
            arrivals.Enqueue(new DateTime(2018, 07, 02));

            Console.WriteLine("At the top " + arrivals.Peek());
            Console.WriteLine("--------");
            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }

            arrivals.Dequeue();
            arrivals.Dequeue();

            Console.WriteLine("At the top " + arrivals.Peek());
            Console.WriteLine("--------");
            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Generic_KeyValuePair //stores to pair of values together. It is a single generic struct.
    {
        static void Main(string[] args)
        {
            var capitals = new List<KeyValuePair<string, string>>();

            capitals.Add(new KeyValuePair<string, string>("Norway", "Oslo"));
            capitals.Add(new KeyValuePair<string, string>("Sweden", "Stockholm"));
            capitals.Add(new KeyValuePair<string, string>("Portual", "Lisbon"));
            capitals.Add(new KeyValuePair<string, string>("Japan", "Tokyo"));

            capitals.RemoveAt(1);

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(GetFirstAndLastName().Value);
        }

        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstName = "Tony";
            string lastName = "Stark";

            return new KeyValuePair<string, string>(firstName, lastName);
        }
    }

    class Generic_NameValueCollection
    {
        static void Main(string[] args)
        {
            // Creating 
            NameValueCollection cities = new NameValueCollection();

            // Adding 
            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Hamburg");
            cities.Add("Germany", "Frankfurt");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Milan");

            // Displaying
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }

            // Set
            cities.Set("Italy", "Venice");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }

            // Contains
            //cities.Clear();
            //Console.WriteLine(cities.HasKeys());

            // Remove
            cities.Remove("Italy");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
        }
    }
    class List_Animal_Exercise_2
    {
        static void Main(string[] args)
        {
            Animals2 dog = new Animals2();
            dog.Name = "Roy";

            Animals2 cat = new Animals2();
            cat.Name = "Koky";

            Animals2 elephant = new Animals2();
            elephant.Name = "Fofy";

            List<Animals2> list = new List<Animals2>();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);

            foreach (var item in list)
            {
                item.SayHi();
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

            public void SayHi()
            {
                Console.WriteLine("Hello my name is " + name);
            }

            public void Feed()
            {
                Console.WriteLine(name + " is now eating");
            }
        }
    }

    class Generic_exercise_3_buildings
    {
        static void Main(string[] args)
        {
            /*
             * Empire State : 381m, 443m, 365000t, NY
             * Burj Khalifa : 828m, 830m, 450000t, Dubai
             * Eiffel Tower : 300m, 324,  7300t  , Paris 
             */

            Buildings<int> empireState = new Buildings<int>();
            empireState.Name = "Empire State";
            empireState.City = "New York";
            empireState.Height = 443;
            empireState.Weight = 365000;

            Console.WriteLine("Name " + empireState.Name);
            Console.WriteLine("City " + empireState.City);
            Console.WriteLine("Height " + empireState.Height);
            Console.WriteLine("Weight " + empireState.Weight);


            Buildings<double> burjKhalifa = new Buildings<double>();
            burjKhalifa.Name = "Burj Khalifa";
            burjKhalifa.City = "Dubai";
            burjKhalifa.Height = 830;
            burjKhalifa.Weight = 450000;

            Console.WriteLine("-------------");
            Console.WriteLine("Name " + burjKhalifa.Name);
            Console.WriteLine("City " + burjKhalifa.City);
            Console.WriteLine("Height " + burjKhalifa.Height);
            Console.WriteLine("Weight " + burjKhalifa.Weight);

            Buildings<float> eiffelTower = new Buildings<float>();
            eiffelTower.Name = "Eiffel Tower";
            eiffelTower.City = "Paris";
            eiffelTower.Height = 324;
            eiffelTower.Weight = 7300;
        }

        class Buildings<T> //the T here declares that this buildings class is a generic class (same elements).
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string city;

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            private T height;

            public T Height
            {
                get { return height; }
                set { height = value; }
            }

            private T weight;

            public T Weight
            {
                get { return weight; }
                set { weight = value; }
            }
        }
    }

    class Generic_exercise_4_movies
    {
        static void Main(string[] args)
        {
            /*
             * 1. (The Lord of the Rings: The Fellowship of the Ring) (19 Dec 2001) (8.8) (Peter Jackson)
             * 2. (The Lord of the Rings: The Two Towers) (18 Dec 2002) (8.7) (Peter Jackson)
             * 3. (The Lord of the Rings: The Return of the King) (8.9) (17 Dec 2003) 
             * -------------------------------------------------------------------------------------
             * 1. (Batman Begins) (15 Jun 2005) (8.3) (Christopher Nolan)
             * 2. (The Dark Knight) (18  Jul 2008) (9.0) (Christopher Nolan)
             * 3. (The Dark Knight Rises) (20 Jul 2012) (8.4) (Christopher Nolan)
             */

            var firstList = new List<Movies<double, DateTime>>();
            var secondList = new List<Movies<float, int>>();

            var darkKnight1 = new Movies<float, int>();
            darkKnight1.MovieName = "Batman Begins";
            darkKnight1.Director = "Christopher Nolan";
            darkKnight1.Rate = 8.3f;
            darkKnight1.ReleaseDate = 2005;

            var darkKnight2 = new Movies<float, int>();
            darkKnight2.MovieName = "The Dark Knight";
            darkKnight2.Director = "Christopher Nolan";
            darkKnight2.Rate = 9.0f;
            darkKnight2.ReleaseDate = 2008;

            var darkKnight3 = new Movies<float, int>();
            darkKnight3.MovieName = "The Dark Knight Rises";
            darkKnight3.Director = "Christopher Nolan";
            darkKnight3.Rate = 8.4f;
            darkKnight3.ReleaseDate = 2012;

            var lordofTheRings1 = new Movies<double, DateTime>();
            lordofTheRings1.MovieName = "The Lord of the Rings: The Fellowship of the Ring";
            lordofTheRings1.Director = "Peter Jackson";
            lordofTheRings1.Rate = 8.8;
            lordofTheRings1.ReleaseDate = new DateTime(2001, 12, 19);

            var lordofTheRings2 = new Movies<double, DateTime>();
            lordofTheRings2.MovieName = "The Lord of the Rings: The Two Towers";
            lordofTheRings2.Director = "Peter Jackson";
            lordofTheRings2.Rate = 8.7;
            lordofTheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            var lordofTheRings3 = new Movies<double, DateTime>();
            lordofTheRings3.MovieName = "The Lord of the Rings: The Return of the King";
            lordofTheRings3.Director = "Peter Jackson";
            lordofTheRings3.Rate = 8.9;
            lordofTheRings3.ReleaseDate = new DateTime(2003, 12, 17);


            firstList.Add(lordofTheRings1);
            firstList.Add(lordofTheRings2);
            firstList.Add(lordofTheRings3);

            secondList.Add(darkKnight1);
            secondList.Add(darkKnight2);
            secondList.Add(darkKnight3);
        }

        class Movies<T, U> //the U here indicates that this class is a datetime class.
        {
            private string movieName;

            public string MovieName
            {
                get { return movieName; }
                set { movieName = value; }
            }

            private string director;

            public string Director
            {
                get { return director; }
                set { director = value; }
            }

            private U releaseDate;

            public U ReleaseDate
            {
                get { return releaseDate; }
                set { releaseDate = value; }
            }

            private T rate;

            public T Rate
            {
                get { return rate; }
                set { rate = value; }
            }
        }
    }
    class Tuples
    {
        static void Main(string[] args)
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool>(100, "Jack", "William", new DateTime(2017, 10, 15), true);
            //as you can see it can contain different data types.

            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine("---------------");
            Console.WriteLine(((DateTime)(empInfo.Item4)).ToShortDateString()); //all the parenthesis allows me to access datetime methods
            Console.WriteLine("---------------");
            Console.WriteLine(empInfo.Item5);

            var studentInfo = Tuple.Create(5, "John", "Cavin", new DateTime(2003, 10, 27)); //create method creates a quadruple.
            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine("---------------");
            Console.WriteLine(studentInfo.Item4);

            Console.WriteLine("---------------");
            var studentinfo2 = new Tuple<int, string, int, string, DateTime, bool>(100, "kurt", 200, "mack", new DateTime(2019, 7, 8), true);
            Console.WriteLine(studentinfo2.Item1);
            Console.WriteLine(studentinfo2.Item4);
            Console.WriteLine(studentinfo2.Item6);
            Console.WriteLine(studentinfo2.Item5);
        }
        class Tuplets_nested
        {
            static void Main(string[] args)
            {
                /*
                 * 1.int    : employee number
                 * 2.string : first name
                 * 3.string : last name
                 * 4.string : address
                 * 5.string : city
                 * 6.string : job title
                 * 7.string : nationality
                 * 8.tuple  : last 5 salaries
                 */

                var employeeInfo = new Tuple<int, string, string, string, string, string, string,
                    Tuple<decimal, decimal, decimal, decimal, decimal>> //this is the nested tuple, inside the the first tuple.
                    (105, "James", "Watson", "", "", "", "",
                    Tuple.Create(8000m, 3000m, 4000m, 5000m, 5000m)); //create here adds the info into corresponding element.

                Console.WriteLine("Employee name is " + employeeInfo.Item2);
                Console.WriteLine("Employee name is " + employeeInfo.Item3);
                Console.WriteLine();
                Console.WriteLine("Last 5 salaries");
                Console.WriteLine(employeeInfo.Rest.Item1); //rest here is used for accessing the items in the nested tuple.
                Console.WriteLine(employeeInfo.Rest.Item2);
                Console.WriteLine(employeeInfo.Rest.Item3);
                Console.WriteLine(employeeInfo.Rest.Item4);
                Console.WriteLine(employeeInfo.Rest.Item5);
            }
        }
        class Tuplets_with_methods
        {       //this is an interesting lesson cos it uses a number of ways for getting the same work done/displaying the same info.
                //basically it makes use of different statement techniques, to achieve exatly the same output.
            static void Main(string[] args)
            {
                var aria = Tuple.Create("Aria", 12, "Stark", "Winterfell");
                DisplayInformation(aria); //this is a convination. Gets the tuple structure from displainfo method
                                          //aswell as console.write statements and tuplet structure from the variable aria.
                var eli = Tuple.Create("Eli", 15, "Harkonnen", "Hammerstrike");
                DisplayInformation(eli); //this the method object down there.

                Console.WriteLine("------------------");
                Console.WriteLine(HoldInformation().Item1); //this displays whats inside the HoldInformation method.
                Console.WriteLine(HoldInformation().Item2); //you can write the item number that you want.
                Console.WriteLine(HoldInformation().Item3);
                Console.WriteLine(HoldInformation().Item4);
                Console.WriteLine(HoldInformation()); //notice here how if you dont request item, it displays different.
            }
            public static void DisplayInformation(Tuple<string, int, string, string> personInfo)
            //you can create a tuple in the arguments section, the name of the variable is personInfo.
            //void type does not return/hold a value, they are for declaring statements only.
            {
                Console.WriteLine("------------------");
                Console.WriteLine(personInfo.Item1);
                Console.WriteLine(personInfo.Item2);
                Console.WriteLine(personInfo.Item3);
                Console.WriteLine(personInfo.Item4);
                Console.WriteLine(personInfo);
            }
            public static Tuple<string, int, string, string> HoldInformation()
            //this object holds the values. you state of what type, tuple here. thats why theres no void keyword.
            {
                var info = Tuple.Create("Rob", 25, "Bauglir", "Windgast");
                return info; //you gotta use return keyword for methods that will deliver the personal details.
            }
        }
        class Tuplets_Exercise_5
        {
            static void Main(string[] args)
            {
                var employeesInformation = new List<Tuple<int, string, string, DateTime>>(); //you can keep adding records to the list infinite.
                employeesInformation.Add(new Tuple<int, string, string, DateTime>(3, "Zack", "Peterson", new DateTime(2017, 11, 20)));
                employeesInformation.Add(Tuple.Create(1, "Adam", "Green", new DateTime(2015, 01, 01)));
                employeesInformation.Add(Tuple.Create(4, "John", "Smith", new DateTime(2016, 07, 25)));
                employeesInformation.Add(Tuple.Create(2, "Emma", "Watson", new DateTime(2017, 10, 12)));
                employeesInformation.Add(Tuple.Create(5, "Todd", "Helmann", new DateTime(2019, 11, 30)));

                Console.WriteLine("Before sorting");
                foreach (var employee in employeesInformation)
                {
                    Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
                }

                Console.WriteLine("\nAfter sorting");
                employeesInformation.Sort();
                foreach (var employee in employeesInformation)
                {
                    Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
                }

                Console.WriteLine("\nAfter reversing");
                employeesInformation.Reverse();
                foreach (var employee in employeesInformation)
                {
                    Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
                }

                Console.WriteLine("\nThe List inside the variable");
                Console.WriteLine(employeesInformation);
            }
        }
        class Value_Tuples_and_Nested_Value_Tuples
        {
            static void Main(string[] args)
            {
                // Install-Package "System.ValueTuple"

                //Values Tuplets
                Console.WriteLine("-------------");
                Console.WriteLine("Value Tuples");
                Console.WriteLine("-------------");

                int x = 0;

                (int playerNo, string playerName, int playerGoals) ronaldo = (7, "Ronaldo", 55);
                Console.WriteLine(ronaldo.playerNo);
                Console.WriteLine(ronaldo.playerName);
                Console.WriteLine(ronaldo.playerGoals);
                Console.WriteLine();

                var messi = (playerNo: 10, playerName: "Messi", playerGoals: 60); //this is another way of writing it. Its shorter.
                Console.WriteLine(messi.playerNo);
                Console.WriteLine(messi.playerName);
                Console.WriteLine(messi.playerGoals);
                Console.WriteLine();

                //Nested Value Tuples
                Console.WriteLine("-------------");
                Console.WriteLine("Nested Value Tuples");
                Console.WriteLine("-------------");

                var ronaldoGoals = (Year2017: 64, Year2016: 60, Year2015: 50, Year2014: 55);
                var ronaldo2 = (playerNo: 7, playerName: "Ronaldo", playerGoals: ronaldoGoals); //this is like a variable inside another so that
                                                                                                //later you can access the statistics in the methods.

                Console.WriteLine(ronaldo2.playerNo);
                Console.WriteLine(ronaldo2.playerName);
                Console.WriteLine("season 2017 goals: " + ronaldo2.playerGoals.Year2017);
                Console.WriteLine("season 2016 goals: " + ronaldo2.playerGoals.Year2016);
                Console.WriteLine("season 2015 goals: " + ronaldo2.playerGoals.Year2015);
                Console.WriteLine("season 2014 goals: " + ronaldo2.playerGoals.Year2014);
            }

            class ValueTuplesWithMethods
            {
                static void Main(string[] args)
                {
                    var ronaldo = (7, "Ronaldo", 60);
                    var giggs = (10, "Giggs", 40);

                    DisplayPlayerInformation(ronaldo);
                    DisplayPlayerInformation(giggs);

                    DisplayPlayerInformation(DisplayPlayerInformation());
                }

                public static void DisplayPlayerInformation((int playerNo, string playerName, int playerGoal) player)
                {
                    Console.WriteLine(player.playerNo);
                    Console.WriteLine(player.playerName);
                    Console.WriteLine(player.playerGoal);
                    Console.WriteLine("-------------------");
                }

                public static (int, string, int) DisplayPlayerInformation()
                {
                    var messi = (10, "Messi", 60);
                    return messi;
                }
            }
        }
        class Value_tuplets_Exercise_6
        {
            static void Main(string[] args)
            {
                var ListofPlayers = new List<(int PlayerNo, string PlayerName, int PlayerGoals)>();

                ListofPlayers.Add((7, "Ronaldo", 55));
                ListofPlayers.Add((9, "Rooney", 45));
                ListofPlayers.Add((11, "Neymar", 31));
                ListofPlayers.Add((10, "Messi", 73));

                foreach (var player in ListofPlayers)
                {
                    Console.WriteLine($"{player.PlayerNo} - {player.PlayerName} - {player.PlayerGoals}");
                    Console.WriteLine("-------------------");
                }
                Console.WriteLine();
                ListofPlayers.Sort();
                Console.WriteLine("After Sorting");

                foreach (var player in ListofPlayers)
                {
                    Console.WriteLine($"{player.PlayerNo} - {player.PlayerName} - {player.PlayerGoals}");
                }
            }
        }
    }
    class assignment_11
    {
        static void Main(string[] args)
        {
            //Assignment No 11
            var playersList = new List<Tuple<int, string, int>>();
            AddPlayer(Tuple.Create(7, "Ronaldo", 55), ref playersList);
            AddPlayer(Tuple.Create(17, "Rooney", 55), ref playersList);
            AddPlayer(Tuple.Create(10, "Messi", 55), ref playersList, 0);

            RemovePlayer(1, ref playersList);

            foreach (var player in playersList)
            {
                Console.WriteLine(player.Item1);
                Console.WriteLine(player.Item2);
                Console.WriteLine(player.Item3);
                Console.WriteLine("---------");
            }
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list)
        {
            list.Add(player);
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list, int index)
        {
            list.Insert(index, player);
        }

        public static void RemovePlayer(int index, ref List<Tuple<int, string, int>> list)
        {
            list.RemoveAt(index);
        }
    }

    class assignment_12
    {
        static void Main(string[] args)
        {
            /*
             * 1. (The Lord of the Rings: The Fellowship of the Ring) (19 Dec 2001) (8.8) (Peter Jackson)
             * 2. (The Lord of the Rings: The Two Towers) (18 Dec 2002) (8.7) (Peter Jackson)
             * 3. (The Lord of the Rings: The Return of the King) (8.9) (17 Dec 2003) 
             * -------------------------------------------------------------------------------------
             * 1. (Batman Begins) (15 Jun 2005) (8.3) (Christopher Nolan)
             * 2. (The Dark Knight) (18  Jul 2008) (9.0) (Christopher Nolan)
             * 3. (The Dark Knight Rises) (20 Jul 2012) (8.4) (Christopher Nolan)
             */

            var firstList = new List<Movies<double, DateTime>>();
            var secondList = new List<Movies<float, int>>();

            var darkKnight1 = new Movies<float, int>();
            darkKnight1.MovieName = "Batman Begins";
            darkKnight1.Director = "Christopher Nolan";
            darkKnight1.Rate = 8.3f;
            darkKnight1.ReleaseDate = 2005;

            darkKnight1.Genres = new List<Genres>();
            darkKnight1.Genres.Add(Genres.Action);
            darkKnight1.Genres.Add(Genres.Drama);
            darkKnight1.Genres.Add(Genres.Thriller);

            var darkKnight2 = new Movies<float, int>();
            darkKnight2.MovieName = "The Dark Knight";
            darkKnight2.Director = "Christopher Nolan";
            darkKnight2.Rate = 9.0f;
            darkKnight2.ReleaseDate = 2008;


            darkKnight2.Genres = new List<Genres>();
            darkKnight2.Genres.Add(Genres.Action);
            darkKnight2.Genres.Add(Genres.Drama);
            darkKnight2.Genres.Add(Genres.Thriller);

            var darkKnight3 = new Movies<float, int>();
            darkKnight3.MovieName = "The Dark Knight Rises";
            darkKnight3.Director = "Christopher Nolan";
            darkKnight3.Rate = 8.4f;
            darkKnight3.ReleaseDate = 2012;

            darkKnight3.Genres = new List<Genres>();
            darkKnight3.Genres.Add(Genres.Action);
            darkKnight3.Genres.Add(Genres.Drama);
            darkKnight3.Genres.Add(Genres.Thriller);
            darkKnight3.Genres.Add(Genres.Mystery);

            var lordofTheRings1 = new Movies<double, DateTime>();
            lordofTheRings1.MovieName = "The Lord of the Rings: The Fellowship of the Ring";
            lordofTheRings1.Director = "Peter Jackson";
            lordofTheRings1.Rate = 8.8;
            lordofTheRings1.ReleaseDate = new DateTime(2001, 12, 19);

            lordofTheRings1.Genres = new List<Genres>();
            lordofTheRings1.Genres.Add(Genres.Action);
            lordofTheRings1.Genres.Add(Genres.Adventure);
            lordofTheRings1.Genres.Add(Genres.Fantasy);


            var lordofTheRings2 = new Movies<double, DateTime>();
            lordofTheRings2.MovieName = "The Lord of the Rings: The Two Towers";
            lordofTheRings2.Director = "Peter Jackson";
            lordofTheRings2.Rate = 8.7;
            lordofTheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            lordofTheRings2.Genres = new List<Genres>();
            lordofTheRings2.Genres.Add(Genres.Action);
            lordofTheRings2.Genres.Add(Genres.Adventure);
            lordofTheRings2.Genres.Add(Genres.Fantasy);

            var lordofTheRings3 = new Movies<double, DateTime>();
            lordofTheRings3.MovieName = "The Lord of the Rings: The Return of the King";
            lordofTheRings3.Director = "Peter Jackson";
            lordofTheRings3.Rate = 8.9;
            lordofTheRings3.ReleaseDate = new DateTime(2003, 12, 17);

            lordofTheRings3.Genres = new List<Genres>();
            lordofTheRings3.Genres.Add(Genres.Action);
            lordofTheRings3.Genres.Add(Genres.Drama);
            lordofTheRings3.Genres.Add(Genres.Thriller);


            firstList.Add(lordofTheRings1);
            firstList.Add(lordofTheRings2);
            firstList.Add(lordofTheRings3);

            secondList.Add(darkKnight1);
            secondList.Add(darkKnight2);
            secondList.Add(darkKnight3);

            Show(firstList);
            Show(secondList);
        }

        public static void Show<T, V>(List<Movies<T, V>> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Movies name : " + item.MovieName);
                Console.WriteLine("Movie rate : " + item.Rate);
                Console.WriteLine("Release date : " + item.ReleaseDate);
                Console.WriteLine("Director : " + item.Director);
                if (!(item.Genres is null))
                {
                    if (item.Genres.Count > 0)
                    {
                        Console.Write("Genres : ");
                        foreach (var genre in item.Genres)
                        {
                            Console.Write(genre + " ");
                        }
                    }
                }
                Console.WriteLine("\n____________________________\n");
            }
        }
    }

    class Movies<T, U>
    {
        private string movieName;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private U releaseDate;

        public U ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        private T rate;

        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private List<Genres> genres;

        public List<Genres> Genres
        {
            get { return genres; }
            set { genres = value; }
        }
    }

    enum Genres
    {
        Action,
        Adventure,
        Animation,
        Biography,
        Comedy,
        Crime,
        Documentary,
        Drama,
        Family,
        Fantasy,
        History,
        Horror,
        Musical,
        Mystery,
        Romance,
        SciFi,
        Sport,
        Thriller,
        War,
        Western
    }
    class Assignment13
    {       //create a tuplet inside a tuplet inside a tuplet. Access the last tuplet.
        static void Main(string[] args)
        {
            var empInfo = new Tuple<string, string, string, string, string, string, string,
            Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal,
            Tuple<int, int, int, int, int>>>("", "", "", "", "", "", "",
            new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal, 
            Tuple<int, int, int, int, int>>
            (0m, 1m, 2m, 3m, 4m, 5m, 6m, Tuple.Create(100, 200, 300, 400, 500)));

            Console.WriteLine(empInfo.Rest.Rest.Item5); //this is the int value 500.
        }
    }
    class Assignment14
    {
        static void Main(string[] args)
        {
            List<Clubs> ronaldoClubs = new List<Clubs>();
            ronaldoClubs.Add(Clubs.ManchesterUnited);
            ronaldoClubs.Add(Clubs.RealMadrid);

            List<Clubs> rooneyClubs = new List<Clubs>();
            rooneyClubs.Add(Clubs.Everton);
            rooneyClubs.Add(Clubs.ManchesterUnited);

            var listofPlayers = new List<(int playerNo, string playerName, int playerGoals, List<Clubs> clubs, Countries country)>();

            listofPlayers.Add((7, "Ronaldo", 55, ronaldoClubs, Countries.Portugal));
            listofPlayers.Add((10, "Rooney", 35, rooneyClubs, Countries.UnitedKingdom));

            foreach (var player in listofPlayers)
            {
                Console.Write($"\n" +
                    $"Player no : {player.playerNo} \nPlayer name : {player.playerName} " +
                    $"\nPlayer goals : {player.playerGoals} \nCountry : {player.country} \nClubs : ");

                foreach (var club in player.clubs)
                {
                    Console.Write(club + "  ");
                }
                Console.WriteLine("\n___________________________");
            }
        }
    }

    enum Clubs
    {
        RealMadrid,
        Barcelona,
        ManchesterUnited,
        Chelsea,
        Arsenal,
        NewcastleUnited,
        Everton,
        Schalke,
        InterMilan,
        ASRoma,
        TottenhamHotspur,
        AtleticoMadrid,
        BorussiaDortmund,
        ManchesterCity,
        Juventus,
        ParisSaintGermain,
        ACMilan,
        Liverpool,
        BayernMunich

    }

    enum Countries
    {
        Afghanistan,
        Albania,
        Algeria,
        Angola,
        Argentina,
        Australia,
        Austria,
        Bahamas,
        Bahrain,
        Bangladesh,
        Belarus,
        Belgium,
        Bolivia,
        Botswana,
        Brazil,
        Brunei,
        Bulgaria,
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        Chad,
        Chile,
        China,
        Colombia,
        Comoros,
        CostaRica,
        Croatia,
        Cuba,
        Cyprus,
        CzechRepublic,
        Denmark,
        Ecuador,
        Egypt,
        ElSalvador,
        Estonia,
        Ethiopia,
        Finland,
        France,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Greece,
        Greenland,
        Guatemala,
        Haiti,
        Honduras,
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jordan,
        Kazakhstan,
        Kenya,
        Kosovo,
        Kuwait,
        Latvia,
        Lebanon,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        Mauritius,
        Mexico,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Morocco,
        Mozambique,
        Namibia,
        Nepal,
        Netherlands,
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        NorthKorea,
        Norway,
        Oman,
        Pakistan,
        Palestine,
        Panama,
        Paraguay,
        Peru,
        Philippines,
        Poland,
        Portugal,
        PuertoRico,
        Qatar,
        Romania,
        Russia,
        Rwanda,
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        Somalia,
        SouthAfrica,
        SouthKorea,
        SouthSudan,
        Spain,
        SriLanka,
        Sudan,
        Swaziland,
        Sweden,
        Switzerland,
        Syria,
        Taiwan,
        Tanzania,
        Thailand,
        Togo,
        Tonga,
        Tunisia,
        Turkey,
        Uganda,
        Ukraine,
        UnitedArabEmirates,
        UnitedKingdom,
        UnitedStatesofAmerica,
        Uruguay,
        Uzbekistan,
        VaticanCity,
        Venezuela,
        Vietnam,
        Yemen,
        Zambia,
        Zimbabwe
    }
    class Assignment15
    {
        static void Main(string[] args)
        {
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
        }
    }
    class Employees
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private decimal salary;
        private int age;
        private List<int> appraisal;

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
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<int> Appraisal
        {
            get { return appraisal; }
            set { appraisal = value; }
        }
    }
}
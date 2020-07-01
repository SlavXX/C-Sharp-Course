using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace _06_Advanced_C___Part_1
{
    class debug
    {
        static int a = 0;
        static int b = 0;
        static void Main(string[] args)
        {
            a = 2;
            b = 2;
            Console.WriteLine("inside main");
            ChangeValues();
            a = 10;
            b = 20;
            Console.WriteLine("inside main again");
        }
        public static void ChangeValues()
        {
            a = 4;
            b = 5;
            Console.WriteLine("Inside changed values");
            //this whole block is about using the debug built-in facilities,thats in visul studio, just watch video to get it.
        }
    }
    //debbugging_writeline is used for when compiling and using the debug run-time up there in the build drop down menu. thats it.
    //its for debugging purposes.
    class debug_writeline
    {
        static void Main(string[] args)
        {
            int c = 5;
            int d = 10;
            Debug.WriteLine("hello from the debug writeline");
            Debug.WriteLineIf(c == 50, "c = " + c);
            Debug.WriteLine("d = " + d);
            c = 50;
            d = 100;
            Debug.WriteLineIf(c == 50, "c = " + c);
            Debug.WriteLine("d = " + d);
            Debug.WriteLine("the program has been terminated");
        }
    }
    //build, rebuild and clean tutorial here, it goes about what build rebuilt and clean do up there on the build menu.
    // string Vs String. Notice the capital S difference, just watch the video for the explanation.

    class Documentation
        //this is about adding descriptions to the classes and methods that you create.
    {
        static void Main(string[] args)
        {
            Dogs max = new Dogs();
            max.Sit(); //here you would see descriptions for the method strings down there, if you actually use them.
            
        }
    }
    /// <summary>
    /// DogCommands will the interface for the methods to be applied.
    /// </summary>
    interface DogCommands
    {
        void Sit();
        void Sit(string dogName, string trainerName);
    }

    /// <summary>
    /// class Animal will be a base class for the child clases like Dogs.
    /// </summary>
    // this is how you add descriptions to classes by using triple /.
    class Animal
    {

    }
    class Dogs : Animal, DogCommands
    {
        /// <summary>
        /// Sit will make the dog sit.
        /// </summary>
        public void Sit()
        {

        }
        /// <summary>
        /// Overlaoded method will take parameters of type string.
        /// </summary>
        /// <param name="dogName">string to hold the dogname</param>
        /// <param name="trainerName">string to hold the trainername</param>
        public void Sit(string dogName, string trainerName)
        {

        }
    }
    class Snippets
        //this are for demostrating snippets stuff. Pressing double tab key will inmediantly bring the snipet text. Saves time.
    {
        static void Main(string[] args)
        {
            //for
            for (int e = 0; e < 10; e++)
            {

            }

            //foreach

            //cw
            Console.WriteLine();
            //switch

            //do
            do
            {

            } while (true);

            //while
            while(true)
            {

            }
           
            //if
            if(true)
            {

            }
        }
        //ctor
        public Snippets()
        {

        }
        //prop
        public int MyProperty { get; set; }

        //propfull
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime birthdate;

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        //enum
        enum Languages
        {

        }

        //svn

        //class
        class Animals
        {

        }

        //struct
        struct MyStruct
        {

        }
        //custom snippet does what the title says. I think you'll hardly use custom snippets, theres files that store the text.
    }

    class FilesWrite
        //this is an interesting lecture, this is how you create files and directories from inside visual studio c#.
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Salv\source\repos\C Sharp Course\06 Advanced C - Part 1\06 Advanced C - Part 1\Names.txt";
            //here you gotta add the directory root and name of the files you wanna create, in this case, "names.txt.
            Directory.CreateDirectory(@"C:\Users\Salv\source\repos\C Sharp Course\06 Advanced C - Part 1\06 Advanced C - Part 1\males");
            //previous line creates a directory folder. called males.
            StreamWriter sw = new StreamWriter(file,true); //streamwriter is like a typewriter that writes text inside the txt file given.
            // the true boolean here allows it to add to it without erasing previous entries.
            sw.WriteLine("James");//here you telling it what to write inside the streamwriter variable sw. The Text inside the file.
            sw.WriteLine("David");
            sw.Close();
        }
    }

    class FilesRead
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Salv\source\repos\C Sharp Course\06 Advanced C - Part 1\06 Advanced C - Part 1\Names.txt";
            StreamReader sr = new StreamReader(file); //this reads from any txt file you specify.
            Console.WriteLine(sr.ReadToEnd()); //this tells it to read whats inside the txt itself and display it.
            Console.WriteLine("File ended");
            sr.Close();
        }
    }

    class FileCreator_Exercise1
    {
        static void Main(string[] args)
        {
            StreamWriter sw2;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Languages_Exercise1)).Length; //gets the Length of enum?
            for (int e = 0; e < count; e++)
            {
                language = Enum.GetValues(typeof(Languages_Exercise1)).GetValue(e).ToString();
                Console.WriteLine(language);
                Directory.CreateDirectory(@"C:\Users\Salv\source\repos\C Sharp Course\06 Advanced C - Part 1\06 Advanced C - Part 1\Exercise1_file_creator");
                Directory.CreateDirectory("C:\\Users\\Salv\\source\\repos\\C Sharp Course\\06 Advanced C - Part 1\\06 Advanced C - Part 1\\Exercise1_file_creator\\" + language);
                sw2 = new StreamWriter("C:\\Users\\Salv\\source\\repos\\C Sharp Course\\06 Advanced C - Part 1\\06 Advanced C - Part 1\\Exercise1_file_creator\\" + language + "\\log.txt");
                sw2.WriteLine("File no " + e + " created on " + DateTime.Now);
                sw2.Close();
            }
        }
    }
    enum Languages_Exercise1
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
    class Cryptography
    {
        static void Main(string[]args)
        {
            string plainText = "attack at night with all forces";
            string cipherText = "dwwdfn dw qljkw zlwk doo irufhv";

            string plainText2 = "the wind blows where the pines are";
            string cipherText2 = "wkh zlqg eorzv zkhuh wkh slqhv duh";

            //char[] cipher; //creates an array called cipher. not sure why he added this.
            //char[] cipher2;

            Console.WriteLine("Cipher Text : ");
            foreach (var item in cipherText)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("Plain text: ");
            //cipher = CaesarCipher.Encrypt(plainText, 3); //this line can be omitted cos its just to get out the cipher text.
            foreach (var item in CaesarCipher.Decrypt(cipherText, 3))//number of places moved up or down the array.
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("part2");

            Console.WriteLine("plain Text 2: ");
            foreach (var item in plainText2)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("Cipher text 2: ");
            //cipher2 = CaesarCipher.Encrypt(plainText2, 3);
            foreach (var item in CaesarCipher.Encrypt(cipherText2, 3))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        class CaesarCipher
        {
            public static char[] Encrypt(string plainText, int shift)
            {
                char[] plainArray = plainText.ToLower().ToCharArray(); //converts the string, into an array of characters. places it.
                char[] cipherArray = new char[plainArray.Length]; //grabs plainArray, does lentgh method and assigns it to cipherArray.

                for (int f = 0; f < plainArray.Length; f++) //im not what the length method does here really.
                {
                    char letter = plainArray[f];
                    if (letter != ' ') //if string has a space it would leave it like it is. thats what this line does.
                    {
                        letter = (char)(letter + shift); //this is where the magic happens.
                        if (letter > 'z') //this is to keep characters out, it makes it go back to the beggining of the alphabet.
                        {
                            letter = (char)(letter - 26); //goes back 26 places in the ascii code. after adding 3 places.
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26); //goes foward 26 spaces in the ascii code after adding the first 3.
                        }
                        cipherArray[f] = letter; //tells it to fill up the cipher array with the characters from letter variable.
                    }
                }
                return cipherArray; //return closes erases the Encrypt variable up there so its necesary.
            }
            public static char[] Decrypt(string cipherText, int shift) //decription here, is basically the reverse.
            {
                char[] cipherArray = cipherText.ToLower().ToCharArray(); //converts the string, into an array of characters. places it.
                char[] plainArray = new char[cipherArray.Length]; //grabs cipherArray, does lentgh method and assigns it to plainArray.

                for (int f = 0; f < cipherArray.Length; f++) //im not what the length method does here really.
                {
                    char letter = cipherArray[f];
                    if (letter != ' ') //if string has a space it would leave it like it is. thats what this line does.
                    {
                        letter = (char)(letter - shift); //this is minus istead of plus.
                        if (letter > 'z') //this is to keep characters out, it makes it go back to the beggining of the alphabet.
                        {
                            letter = (char)(letter - 26); //goes back 26 places in the ascii code. after adding 3 places.
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26); //goes foward 26 spaces in the ascii code after adding the first 3.
                        }
                        plainArray[f] = letter; //tells it to fill up the cipher array with the characters from letter variable.
                    }
                }
                return plainArray; //return closes erases the decrypt variable up there so its necesary.
            }
        }
    }

    //Foreground color, this is to change the text color, foreground and background.
    class ForegroundColor_DigitSeparator_and_DefaultKeyword
    {
        static void Main(string[]args)
        {
            string greenmessage = "This is the GREEN message";
            string bluemessage = "This is the BLUE message";
            string redmessage = "This is the RED message";

            Console.ForegroundColor = ConsoleColor.Green; //notice that the order when appling colors is important.
            Console.WriteLine(greenmessage);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(bluemessage);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(redmessage);
            Console.ForegroundColor = ConsoleColor.White;


            //Digit Separator
            var DistaceToSunFromEarth = 149_600_000; //you can use lower bar to make it easy to read.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Distance of sun from earth: " + DistaceToSunFromEarth);
            Console.ForegroundColor = ConsoleColor.White;


            //Default Keyword
            long longvar = default; //the default is used here for the default values of the types.
            string stringvar = default;
            DateTime datevar = default;
            int intvar = default;

            Console.WriteLine();
            Console.WriteLine(datevar);
            
        }

    }

}
namespace AssignmentNo9
{
    class AssignmentNo9
    {
        #region Main Method
        static void Main(string[] args)
        {
            string userChoose = string.Empty;
            string filePath = string.Empty;
            string fileName = string.Empty;
            string plainText = string.Empty;
            string cipherText = string.Empty;
            int shift = 0;
            StreamWriter sw = default;
            StreamReader sr = default;

            do
            {
                userChoose = WeclcomeMessage();

                if (userChoose.ToLower() == "e")
                {
                    PerformEncryptOperation(out plainText, out cipherText, out shift);
                }
                else if (userChoose.ToLower() == "d")
                {
                    PerformDecryptOperation(out filePath, out fileName, ref cipherText, out shift, ref sr);
                }
                else if (!(userChoose.ToLower() == "x"))
                {
                    ErrorMessage("Invalid input, please try again");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("----------------------------------------------------");
                Console.WriteLine("\n");
            }
            while (userChoose.ToLower() != "x");
            Console.WriteLine("Thank you for using caesar cipher app.\n\n");
        }
        #endregion

        #region Error Message
        private static void ErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        #endregion

        #region App Message
        private static void AppMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Welcome Message
        private static string WeclcomeMessage()
        {
            string userChoose;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to caesar cipher app, choose \n(E) to encrypt \n(D) to decrypt \n(X) to exit\n");
            Console.ForegroundColor = ConsoleColor.White;
            userChoose = Console.ReadLine();
            return userChoose;
        }
        #endregion

        #region Perform Encrypt Operation
        private static void PerformEncryptOperation(out string plainText, out string cipherText, out int shift)
        {
            AppMessage("Welcome to encryption mode \nEnter message to encrypt");
            plainText = Console.ReadLine();
            shift = 0; cipherText = string.Empty;
            if (plainText != "")
            {
                try
                {
                    AppMessage("Enter the shift");
                    shift = int.Parse(Console.ReadLine());

                    if (shift <= 26 && shift > 0)
                    {
                        AppMessage("Cipher is");

                        cipherText = new string(CaesarCipher.Encrypt(plainText, shift));
                        Console.WriteLine(cipherText);
                    }
                    else
                    {
                        ErrorMessage("Enter a number between 1 to 26");
                    }
                }
                catch (Exception e)
                {
                    ErrorMessage(e.Message);
                }
            }
            else
            {
                ErrorMessage("Invalid input");
            }
        }
        #endregion

        #region Perform Decrypt Operation
        private static void PerformDecryptOperation(out string filePath, out string fileName, ref string cipherText, out int shift, ref StreamReader sr)
        {
            shift = 0; fileName = string.Empty;
            AppMessage("Welcome to decryption mode \nEnter the path of file to decrypt");
            filePath = Console.ReadLine();

            if (filePath != "")
            {
                AppMessage("Enter file name");
                fileName = Console.ReadLine();
                if (fileName != "")
                {
                    filePath = filePath + "\\" + fileName;

                    AppMessage("Enter the shift");

                    try
                    {
                        shift = int.Parse(Console.ReadLine());
                        if (shift <= 26 && shift > 0)
                        {
                            sr = new System.IO.StreamReader(filePath);
                            cipherText = sr.ReadToEnd();

                            cipherText = new string(CaesarCipher.Decrypt(cipherText, shift));
                            AppMessage("Cipher is");
                            Console.WriteLine(cipherText);

                            sr.Close();
                        }
                        else
                        {
                            ErrorMessage("Enter a number between 1 to 26");
                        }

                    }
                    catch (Exception e)
                    {
                        ErrorMessage(e.Message);
                    }
                }
                else
                {
                    ErrorMessage("File name cannot be empty");
                }
            }
            else
            {
                ErrorMessage("Path is invalid");
            }
        }
        #endregion
    }

    class CaesarCipher
    {
        #region Caesar Cipher Encryption
        public static char[] Encrypt(string plainText, int shift)
        {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
            }
            return cipherArray;
        }
        #endregion

        #region Caesar Cipher Decryption
        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherText.Length];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    plainArray[i] = letter;
                }
            }
            return plainArray;
        }
        #endregion
    }
}

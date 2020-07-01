using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class3 file is to show how the get/set thing works.
public class Genre
{
    public string Name { get; set; } //you create a string inside a class and write the "{ get; set; }" line. "get" is "return" and "set" assigns value.
}

public class getSetExample
{
    public static void Main()
    {
        Genre g1 = new Genre(); //this creates a new "instance" of the class "genre".
        Genre g2 = new Genre();
        Genre g3 = new Genre();

        g1.Name = "Hip Hop";
        g2.Name = "Rock";
        g3.Name = "Country";

        Console.WriteLine("Genres: {0}, {1}, {2}", g1.Name, g2.Name, g3.Name); //the 0,1,2 are "placeholders" which are assigned to the following variable names g1.Name, g2.Name, g3.Name.
    }
        private string name;
        public string Name
        {
            get {return this.name;} //this is an example of the "this" instance method at work.
            set {this.name = value;}
        }
}


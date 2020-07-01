using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AssignmentNo8

{

    class AssignmentNo8

    {

        static void Main(string[] args)

        {
            GermanShepard max = new GermanShepard();
            max.Origin = Origions.Germany;
            max.Name = "Max";
            max.BirthDate = new DateTime(2017, 10, 10);
            max.Gender = Gender.Male;
            max.Weight = 32.54;
            max.SecurityGuard = false;
            max.Size = Sizes.Large;
            max.Training = TrainingAbility.Easy;
            max.DisplayDogInformation();
            max.Sit(max.Name);
            max.Eat();
            max.SayHi();
        }
    }
}
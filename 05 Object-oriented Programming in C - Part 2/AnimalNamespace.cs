using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo8
{
    class Animal
    {
        private string name;
        private DateTime birthDate;
        private Origions origin;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public Origions Origin
        {
            get { return origin; }
            set { origin = value; }
        }
    }

    interface Dog
    {
        void Eat();
        void Drink();
        void Sit();
        void Sleep();
        void SayHi();

    }

    class GermanShepard : Animal, Dog
    {
        private Gender gender;
        private double weight;
        private bool securityGuard;
        private TrainingAbility training;
        private Sizes size;


        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public bool SecurityGuard
        {
            get { return securityGuard; }
            set { securityGuard = value; }
        }

        public TrainingAbility Training
        {
            get { return training; }
            set { training = value; }
        }

        public Sizes Size
        {
            get { return size; }
            set { size = value; }
        }

        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public void Eat(string dogName)
        {
            Console.WriteLine($"{dogName} is eating");
        }
        public void Drink()
        {
            Console.WriteLine("Dog is drinking");
        }
        public void Drink(string dogName)
        {
            Console.WriteLine($"{dogName} is drinking");
        }
        public void Sit()
        {
            Console.WriteLine("Dog is sitting");
        }
        public void Sit(string dogName)
        {
            Console.WriteLine($"{dogName} is sitting");
        }
        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
        public void Sleep(string dogName)
        {
            Console.WriteLine($"{dogName} is sleeping");
        }

        public void SayHi()
        {
            Console.WriteLine("Hiii \"in dogs language :D\"");
        }

        public void DisplayDogInformation()
        {
            Console.WriteLine($"The dog name is {Name} from {Origin}, " +
                $"was born on {BirthDate.ToShortDateString()} " +
                $"{Name} is a {Gender} and weights {Weight} kilos and its size is {Size} ");
        }
    }

    enum Gender
    {
        Male,
        Female
    }

    enum Sizes
    {
        Small,
        Medium,
        Large
    }
    enum TrainingAbility
    {
        Easy,
        Medium,
        Hard
    }
    enum Origions
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
}
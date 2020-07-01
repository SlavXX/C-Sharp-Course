using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNamespace

{

    struct Movie

    {

        private string movieName;
        private double rate;
        private DateTime releaseDate;
        private Genres[] genres;
        private Language[] languages;
        private Country[] countries;


        public string MovieName

        {

            get { return movieName; }
            set { movieName = value; }

        }



        public double Rate

        {

            get { return rate; }
            set { rate = value; }

        }



        public DateTime ReleaseDate

        {

            get { return releaseDate; }
            set { releaseDate = value; }

        }



        public Language[] Languages

        {

            get { return languages; }
            set { languages = value; }

        }



        public Country[] Countries2

        {

            get { return countries; }
            set { countries = value; }

        }



        public Genres[] Genres

        {

            get { return genres; }
            set { genres = value; }

        }



        public void DisplayMovieInformation()

        {

            Console.Write($"Movies : {MovieName}" +

                $"\nRate : {Rate} out of 10" +

                $"\nReleased on: {ReleaseDate.ToShortDateString()}" +

                $"\nLanguages: ");



            for (int i = 0; i < Languages.Length; i++)

            {

                Console.Write(Languages[i]);

                if (i < Languages.Length - 1)

                    Console.Write(", ");

                else

                    Console.WriteLine();

            }

            Console.Write("Countries : ");

            for (int i = 0; i <Countries2.Length; i++)

            {

                Console.Write(Countries2[i]);

                if (i < Countries2.Length - 1)

                    Console.Write(", ");

            }

            Console.Write("\nGenres : ");

            for (int i = 0; i < Genres.Length; i++)

            {

                Console.Write(Genres[i]);

                if (i < Genres.Length - 1)

                    Console.Write(", ");

                else

                    Console.WriteLine();

            }

            Console.WriteLine("---------------------------------------");

        }

    }

    #region Lists


    #region Languages List

    enum Language

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

    #endregion



    #region Countries List

    enum Country

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

    #endregion



    #region Genres

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

    #endregion

    #endregion

}
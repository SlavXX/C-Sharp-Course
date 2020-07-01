using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldNamespace;//this is from the country exercise

namespace CountryExercise
{
    class CountryExercise
    {
        static void Main(string[] args)
        {
            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Languages.English.ToString();
            countryLanguages.SecondLanguage = Languages.French.ToString();

            countryOneInstance.CountryLanguages = countryLanguages;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "Canada";
            countryOneInstance.Currency = Currencies.CAD;
            countryOneInstance.Continents = Continents.North_America;

            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.CountryName);

            Console.WriteLine($"Planet {countryOneInstance.PlanetName} and country is {countryOneInstance.CountryName} and currency is {countryOneInstance.Currency} and continent is {countryOneInstance.Continents}");

        }
    }
}

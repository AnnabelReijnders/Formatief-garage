using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefentoets
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Geef opties
            Console.WriteLine("Kies tussen de volgende opties en vul het cijfer van de optie in:");
            Console.WriteLine("Optie 1: Bekijk voertuigen en eigenaren.");
            Console.WriteLine("Optie 2: Voeg eigenaar toe.");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Hieronder de lijst met voertuigen en bijbehorende eigenaren");
                // Voeg hier de code toe om voertuigen en eigenaren te bekijken
            }
            else if (choice == "2")
            {
                Console.WriteLine("Vul de onderstaande gegevens in om een eigenaar toe te voegen");
                // Voeg hier de code toe om een eigenaar toe te voegen
            }
            else
            {
                Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_ver3
{
    abstract class Mammal
    {
        public string MammalType { get; protected set; }
        protected string Species { get; set; }
        protected int AnimalWeight { get; set; }
        protected double SpeciesModifier { get; set; }
        protected string SpeciesFoodPref { get; set; }
        protected virtual void ShowInstructions()
        {
            Console.WriteLine("Instructions: Keep area secure at all times.");
        }

        protected abstract void ShowFoodPreference();
        protected abstract void ShowServing(string species);

       protected void ShowSummaryData()
        {
            Console.WriteLine("Meal Recommendations ");
            Console.WriteLine("--------------------");
            Console.WriteLine("Mammal type: " + MammalType);
            Console.WriteLine("Species type: " + Species);
            Console.WriteLine("Weight  : " + AnimalWeight);
            Console.Write("Serving   : " + (AnimalWeight * SpeciesModifier));
            Console.WriteLine(" " + SpeciesFoodPref);
            Console.WriteLine();
            ShowInstructions();
            Console.WriteLine("\t      Feed at 9AM, 12PM, and 5PM. ");

            

        }
    
    }

}

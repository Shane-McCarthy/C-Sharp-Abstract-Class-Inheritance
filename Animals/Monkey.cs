using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_ver3.Animals
{
     class Monkey : Mammal
    {
        public string MonkeyType { get; set; }
        public Monkey()
        {
            MammalType = "Monkey ";
                    
           
        }
        
       
        protected override void ShowFoodPreference() {
            SpeciesFoodPref = "fresh fruit, vegetables, nuts, insects, berries ";  
        }
        protected override void ShowServing(string species)
        {
            float convertedValue = 0.0f;
            string weight = "";
            do {
            Console.Write("Weight in KG: ");
            weight = Console.ReadLine();
            } while(!float.TryParse(weight, out convertedValue ));
            
            AnimalWeight = int.Parse(weight);
             

            if (species == "Squirrel")
            {
               
                SpeciesModifier = 0.006;
            }
            else if (species == "Howler")
            {
                SpeciesModifier = 0.007;
            }
            else if (species == "Colobus")
            {
                SpeciesModifier = 0.008;
             }
           }

        public void SetMonkeyType(string response)
        {
            bool check  = false;
           
            while (!check)
            if (response == "1")
            {
                Species = "Squirrel";
                ShowServing(Species); 
                ShowFoodPreference();
                check = true; 
                
            }
            else if (response == "2")
            {
                Species = "Howler";
                ShowServing(Species); 
                ShowFoodPreference();
                check = true; 
            }
            else if (response == "3")
            {
                Species = "Colobus";
                ShowServing(Species);
                ShowFoodPreference();
                check = true;
            }
            
            ShowSummaryData();
            
        }
        public void GetMonkeyType()
        {
            string response = "";
            do
            {
                Console.WriteLine("Species");
                Console.WriteLine("-------");
                Console.WriteLine("1. Squirrel");
                Console.WriteLine("2. Howler");
                Console.WriteLine("3. Colobus");
                Console.Write("Selection:      ");
                 response = Console.ReadLine();


                response = response.Trim();
                if (response != "1" && response != "2" && response != "3")
                {
                    Console.WriteLine("Invalid Entry");
                }
            }
            while (response != "1" && response != "2" && response!="3");
            
            SetMonkeyType(response);
        }
    }
}

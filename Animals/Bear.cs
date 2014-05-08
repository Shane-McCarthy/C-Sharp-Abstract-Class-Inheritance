using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_ver3.Animals
{
    class Bear :Mammal
    {
        public string BearType { get; set; }
        public Bear()
        {
           MammalType = "Bear ";
                    
           
        }

        protected override void ShowFoodPreference()
        {
            if (Species == "Black")
            {
                SpeciesFoodPref = "berries, green vegetation, flowers, fruits, fish";
            }
            else if (Species == "Polar")
            {
                SpeciesFoodPref = "berries, fish, seal meat, eggs";
            }
        }

        protected override void ShowServing(string species)
        {
            Console.Write("Weight in KG: ");
            string weight = Console.ReadLine();
            AnimalWeight = int.Parse(weight);
            if (species == "Black")
            {
                SpeciesModifier = 0.014;
               
            }else if(species=="Polar") {
                SpeciesModifier = 0.016;
            }
                

            
        }
        public void SetBearType(string response)
        {
            bool check = false;

            while (!check)
                if (response == "1")
                {
                    Species = "Black";
                    ShowServing(Species); 
                    ShowFoodPreference(); 
                    
                    check = true;

                }
                else if (response == "2")
                {
                    Species = "Polar";
                    ShowServing(Species);
                    ShowFoodPreference();
                    check = true;
                }
                else {
                    check = true;
                    Console.WriteLine("Invalid Response "); 
                    GetBearType();
                    
                }
            ShowSummaryData();

        }
        public void GetBearType()
        {
            string response = "";
            do
            {
                Console.WriteLine("Species");
                Console.WriteLine("-------");
                Console.WriteLine("1. Black");
                Console.WriteLine("2. Polar");
                Console.Write("Selection:      ");
                response = Console.ReadLine();


                response = response.Trim();
                if (response != "1" && response != "2" && response != "3")
                {
                    Console.WriteLine("Invalid Entry");
                }
            }
            while (response != "1" && response != "2" );
            SetBearType(response);
        }
    }
}

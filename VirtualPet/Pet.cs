using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        public string PetName { get; set; }
        public int Hunger { get; set; }
        public int Waste { get; set; }
        public int Play { get; set; }
        //public int TakeToVet { get; set; }

        public Pet()
        {

            Hunger = 5;
            Waste = 5;
            Play = 5;

        }

        public int PetHealthStatus()
        {
            Console.Clear();
            


            Console.WriteLine(PetName + "'s Health Status:");

            Console.WriteLine("Health is full at 10.");

            Console.WriteLine("\nHunger: " + Hunger);
            Console.WriteLine("Waste:  " + Waste);
            Console.WriteLine("Play:   " + Play);

            Console.WriteLine("\nPress enter to hangout with " + PetName);
            Console.ReadKey();
            return MainMenu();


        }

        public int MainMenu()
        {
            Console.Clear();
            int menuChoice = 0;

            Console.WriteLine("\nChoose an option below to interact with " + PetName + "!");
            Console.WriteLine("\n1. Feed");
            Console.WriteLine("2. Bathroom");
            Console.WriteLine("3. Play");
            Console.WriteLine("4. Health Status");



            while (true)
            {
                string userChoice = Console.ReadLine();
                if (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4")
                {
                menuChoice = Convert.ToInt32(userChoice);
                }               
                                           
                if (menuChoice == 1)
                {
                    Feed();
                   
                }
                else if (menuChoice == 2)
                {
                    Bathroom();
                    
                }
                else if (menuChoice == 3)
                {
                    Exercise();
                    
                }
                else if (menuChoice == 4)
                {
                    PetHealthStatus();
                    
                }
                else
                {
                    Console.WriteLine("Invalid entry, please choose number from list above, press any key to continue.");
                    Console.ReadLine();
                    return MainMenu();
                }

            }


        }



        public void Feed()
        {
            Tick();
            for (int i = 1; i <= 1; i++)
            {
                if (Hunger >= 10)
                {
                    Console.WriteLine("Your pet is full!");
                }
                else
                {
                    Hunger += 2;
                    Waste -= 1;
                    PetHealthStatus();
                }
            }
           
        }

        public void Bathroom()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Waste >= 10)
                {
                    Console.WriteLine(PetName + " doesn't need to go out!");
                }
                else
                {
                    Waste++;
                    PetHealthStatus();
                }
            }
            
        
        }
        public void Exercise()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Play >= 10)
                {
                    Console.WriteLine(PetName + " doesn't want to play!");
                }
                else
                {
                    Play += 2;
                    Hunger -= 2;
                    PetHealthStatus();
                }
            }
            
        }

        public int Tick()
        {
            Hunger -= 1;            
            Play += 1;

            return 0;

        }





    }
}

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
        public int MaxHealth { get; set; }
        public int MinHealth { get; set; }
        private int _hunger;
        public int Hunger
        {            
            get
            {
                return _hunger;
            }                                         
           set
            {
                _hunger = value;
                if (_hunger > 10)
                {
                    _hunger = MaxHealth;
                }
                if (_hunger < MinHealth)
                {
                    //_hunger = MinHealth;
                    IsAlive();
                    
                }
            }
        }
        private int _waste;
        public int Waste
        {
            get
            {
                return _waste;
            } 
            set 
            {
                _waste = value;
                if(_waste > 10)
                {
                    _waste = MaxHealth;
                }
                if (_waste < MinHealth)
                {
                    //_waste = MinHealth;
                    IsAlive();
                }
            }
                }
        private int _play;
        public int Play
        {
            get
            {
                return _play;
            }
            set
            {
                _play = value;
                if (_play > 10)
                {
                    _play = MaxHealth;
                }
                if (_play < MinHealth)
                {
                    //_play = MinHealth;
                    IsAlive();
                }
            }
        }


        public Pet()
        {

            Hunger = 5;
            Waste = 5;
            Play = 5;
            MaxHealth = 10;
            MinHealth = 1;

        }

        public void PetHealthStatus()
        {
            
            if(!IsAlive())
            {
                Console.WriteLine("You let your sharks health get to low, so "+PetName+ " escaped into the wild!");
            }

            else
            { Console.Clear();
                Console.WriteLine(PetName + "'s Health Status:");
                Console.WriteLine("           _________         .     .    ");
                Console.WriteLine("          (..       \\_    ,  |\\   /|   ");
                Console.WriteLine("           \\       0  \\  /|    \\\\//   ");
                Console.WriteLine("            \\______    \\/ |   \\   /     ");
                Console.WriteLine("                vvvv\\   \\ |   /   |     ");
                Console.WriteLine("                 ^^^^  ==  \\_/    |     ");
                Console.WriteLine("                 `\\_ ===   \\.     |    ");
                Console.WriteLine("                 / /\\_   \\ /      |    ");
                Console.WriteLine("                 |/   \\_  \\|      /     ");
                Console.WriteLine("                        \\________/      ");



                Console.WriteLine("Health is full at 10.");
                Console.WriteLine("\nDon't let your sharks health reach 0 or they will return to the wild!");

                Console.WriteLine("\nHunger: " + Hunger);
                Console.WriteLine("Waste:  " + Waste);
                Console.WriteLine("Play:   " + Play);

                Console.WriteLine("\nPress enter to hangout with " + PetName);
            }
            Console.ReadKey();
            MainMenu();


        }

        public void MainMenu()
        {
            Console.Clear();
            int menuChoice = 0;
                    
            Console.WriteLine("           _________         .     .    ");
            Console.WriteLine("          (..       \\_    ,  |\\   /|   ");
            Console.WriteLine("           \\       0  \\  /|    \\\\//   ");
            Console.WriteLine("            \\______    \\/ |   \\   /     ");
            Console.WriteLine("                vvvv\\   \\ |   /   |     ");
            Console.WriteLine("                 ^^^^  ==  \\_/    |     ");
            Console.WriteLine("                 `\\_ ===   \\.     |    ");
            Console.WriteLine("                 / /\\_   \\ /      |    ");
            Console.WriteLine("                 |/   \\_  \\|      /     ");
            Console.WriteLine("                        \\________/      ");






            Console.WriteLine("\nChoose an option below to interact with " + PetName + "!");
            Console.WriteLine("\n1. Feed");
            Console.WriteLine("2. Bathroom");
            Console.WriteLine("3. Play");
            Console.WriteLine("4. Health Status");



            while (IsAlive())
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
                    MainMenu();
                }
            }
            
        }

        public void Feed()
        {// Tick goes off everytime animal is fed
            Tick();
            for (int i = 1; i <= 1; i++)
            {
                if (Hunger >= 10)
                {
                    Console.WriteLine("Your pet is full!");
                    Console.WriteLine("Check " + PetName + "'s Health Status by selecting option 4.");
                }
                else
                {
                    Hunger += 2;
                    Waste -= 1;
                    Play -= 1;
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
                    Console.WriteLine("Check " + PetName + "'s Health Status by selecting option 4.");
                }
                else
                {
                    Waste++;
                    Play -= 1;
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
                    Console.WriteLine("Check " + PetName + "'s Health Status by selecting option 4.");
                }
                else
                {
                    Play += 2;
                    Hunger -= 1;
                    PetHealthStatus();                   
                }
            }
            
        }

        public bool IsAlive()
        {
            if (Hunger >= MinHealth && Waste >= MinHealth && Play >= MinHealth)
            {                         
                return true;                
            }
            else
            {             
                return false;
            }
        }


        public int Tick()
        {// Put Tick in Feed()
            Hunger -= 1;            
            Play -= 1;

            return 0;

        }





    }
}

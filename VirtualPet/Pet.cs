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
        public int Feed { get; set; }
        public int Bathroom { get; set; }
        public int Play { get; set; }
        //public int TakeToVet { get; set; }

        public Pet()
        {

            Feed = 10;
            Bathroom = 10;
            Play = 10;
            //TakeToVet = 10;
        }



        public int MainMenu()
        {
            Console.Clear();
            int menuChoice = 0;

            Console.WriteLine("\nChoose an option below to interact with " + PetName + "!");
            Console.WriteLine("\n1. Feed");
            Console.WriteLine("2. Bathroom");
            Console.WriteLine("3. Play");
            Console.WriteLine("4. Take to Vet");

            while (menuChoice < 1 || menuChoice > 4)
            {
                try
                {
                    string userChoice = Console.ReadLine();
                    menuChoice = Convert.ToInt32(userChoice);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter number 1-4");
                }
            }

            while(true)
            {
                if( menuChoice == 1)
                {
                    Hunger();
                    
                }
              else if (menuChoice == 2)
                {
                    Waste();
                }
               else if (menuChoice == 3)
                {
                    Exercise();
                    
                }
                
            }
            return menuChoice;
        }

        public int Hunger()
        {
            Console.WriteLine(PetName + "'s hunger level is at {0}", Feed);
            return 0;
        }

        public int Waste()
        {
            return 0; 
        }
        public int Exercise()
        {
            return 0;
        }
       //public int VetVisit()
       // {
       //  return 0;
       // }
        private int Tick()
        {
            return 0;
        }

       



    }
}

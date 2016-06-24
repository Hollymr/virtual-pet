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

            Hunger = 0;
            Waste = 0;
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



            while (true)
            {
                string userChoice = Console.ReadLine();
                menuChoice = Convert.ToInt32(userChoice);

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
                    else
                    {
                        Console.WriteLine("Invalid entry, please choose number from list above.");
                    }

                } 
       
        }
            
        

        public void Feed()
        {
            Hunger += 1;
            Console.WriteLine(PetName + "'s hunger level is now at {0}", Hunger);
            if (Hunger == 10)
            {
                Console.WriteLine("Your pet is full!");
            }
           
              
        }

        public void Bathroom()
        {
            
        }
        public void Exercise()
        {
            
        }
       //public int VetVisit()
       // {
       //  return 0;
       // }
        private void Tick()
        {
            
        }

       



    }
}

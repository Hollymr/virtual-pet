using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        /* Meet your new pet Shark
         * Name your pet
         * Display
         *
         */
        


        static void Main(string[] args)
        {
            Pet myPet = new Pet();

            Console.WriteLine("Welcome, meet your new pet shark!");
            Console.WriteLine("\nPlease name your pet.");
            myPet.PetName = Console.ReadLine();
            myPet.MainMenu();

            
            //Console.WriteLine("\nChoose an option below to interact with " + myPet.PetName + "!");
            //Console.WriteLine("\n1. Feed");
            //Console.WriteLine("2. Waste");
            //Console.WriteLine("3. Play");
            //Console.WriteLine("4. Take for a swim");




            while (true)
            {

                









            }

            Console.ReadKey();
        }
    }
}

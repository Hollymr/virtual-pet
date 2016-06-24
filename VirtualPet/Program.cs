using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Pet myPet = new Pet();

            Console.WriteLine("Welcome, meet your new pet shark!");
            Console.WriteLine("\nPlease name your pet.");
            myPet.PetName = Console.ReadLine();
           
            while (true)
            {
                myPet.MainMenu();
                
                //feed pet
                //take pet to restroom
                //play with pet

                
            }

            Console.ReadKey();
        }
    }
}

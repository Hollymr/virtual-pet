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


            // Stretch task
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
   

            Console.WriteLine("\nPlease name your pet.");
            myPet.PetName = Console.ReadLine();


            while (myPet.IsAlive())
            {
               myPet.PetHealthStatus();                             
            }

            Console.ReadKey();
        }
    }
}

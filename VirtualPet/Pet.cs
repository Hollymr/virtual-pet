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
        public int TakeForSwim { get; set; }


        public void MainMenu()
        {
            Pet myPet = new Pet();

            Console.WriteLine("\nChoose an option below to interact with " + myPet.PetName + "!");
            Console.WriteLine("\n1. Feed");
            Console.WriteLine("2. Waste");
            Console.WriteLine("3. Play");
            Console.WriteLine("4. Take for a swim");
        }












    }
}

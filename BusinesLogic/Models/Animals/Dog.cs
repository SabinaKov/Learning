using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic.Models.Animals
{
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Here is a dog!");
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }
        public void MavatOcasem()
        {
            Console.WriteLine("Pes mává ocasem!");
        }
    }
}

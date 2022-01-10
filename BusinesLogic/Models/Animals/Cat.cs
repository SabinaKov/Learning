using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic.Models.Animals
{
    public class Cat : Animal
    {

        public Cat()
        {
            Console.WriteLine("Here is a cat!");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
        public void CatchMouse()
        {
            Console.WriteLine("Catching mouse!");
        }
    }
}

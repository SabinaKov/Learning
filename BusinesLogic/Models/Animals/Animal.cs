using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic.Models.Animals
{
    public class Animal
    {
        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
        public virtual void MakeNoise()
        {

        }
    }
}

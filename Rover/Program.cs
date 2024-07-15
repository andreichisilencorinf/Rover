using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rover rover = new Rover(0, 0, 'N');
            rover.Move("LMLMLMLMM");
            rover.PrintPosition();
        }
    }
}

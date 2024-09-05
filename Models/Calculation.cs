using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34.Models
{
    internal class Calculation
    {
        public Direction Direct { get; set; }
        public CarType Cartipe { get; set; }
        public CrashedCar CrashCar { get; set; }
        public float CalculatePrice()
        {
            var x = Direct.Price * Cartipe.Coificent * CrashCar.Coificent;
            return x;
        }
    }
}

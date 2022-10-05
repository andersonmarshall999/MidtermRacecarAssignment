using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class CozyCoupe : RaceCar
    {
        public CozyCoupe()
        {
            Name = "Little Tikes Cozy Coupe";
            TopSpeed = 4;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is ready to roll!");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} rolls to a halt");
        }
    }
}

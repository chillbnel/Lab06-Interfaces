using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces.Classes
{
    public class InsectArachnidManEatingDeathMonster : InsectArachnid, IScary
    {
        public override string Color { get; set; }
        public bool IsBrianScaredofIt { get; set; }

        public override int NumberOfLegs()
        {
            return 16;
        }

        public int ScaredScale()
        {
            return 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces.Classes
{
    class BirdTurkey : Bird, IEndangered, IScary
    {
        public override bool Migrates { get; set; }
        public bool IsEndangered { get; set; }
        public bool IsBrianScaredofIt { get; set; }

        public override string Sound()
        {
            return "Gobble gobble";
        }

        public string Classification()
        {
            return "Not Endangered";
        }

        public int ScaredScale()
        {
            return 5;
        }
    }
}

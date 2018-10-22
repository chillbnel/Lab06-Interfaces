using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    class BirdTurkey : Bird
    {
        public override bool Migrates { get; set; }
        public bool IsEndangered { get; set; }

        public override string Sound()
        {
            return "Gobble gobble";
        }

        public string Classification()
        {
            return "Not Endangered";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces.Classes
{
    class BirdSwallow : Bird, IEndangered
    {
        public override bool Migrates { get; set; }
        public bool IsEndangered { get; set; }

        public override string Sound()
        {
            return "wok wok";
        }

        public string Classification()
        {
            return "Not Endangered";
        }
    }
}

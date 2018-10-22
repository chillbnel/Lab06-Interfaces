using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces.Classes
{
    class FishGoldfish : Fish
    {
        public override bool Migrates { get; set; }
        public bool IsEndangered { get; set; }

        public override string Sound()
        {
            return "don't flush me in the toilet";
        }

        public string Classification()
        {
            return "Not Endangered";
        }
    }
}

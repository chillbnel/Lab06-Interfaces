using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces.Classes
{
    class FishGobidine : Fish, IEndangered, IScary
    {
        public override bool Migrates { get; set; }
        public bool IsEndangered { get; set; }
        public bool IsBrianScaredofIt { get; set; }

        public override string Sound()
        {
            return "i'm colorful but small!";
        }

        public string Classification()
        {
            return "Endangered";
        }

        public int ScaredScale()
        {
            return 5;
        }
    }
}

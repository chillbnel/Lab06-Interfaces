using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interfaces;

namespace Lab06_Interfaces.Classes
{
    class InsectArachnidWolfSpider : InsectArachnid, IScary
    {
        public override string Color { get; set; }
        public bool IsBrianScaredofIt { get; set; }

        public override int NumberOfLegs()
        {
            return 8;
        }

        public int ScaredScale()
        {
            return 7;
        }
    }
}

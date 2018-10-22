using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    public abstract class Bird : Animal
    {
        public override bool livesOnLand { get; set; }
        public override bool livesInWater { get; set; }
        public virtual bool Migrates { get; set; }


        public override string FavoriteFood()
        {
            return "berries and leaves";
        }
        public override string Habitat()
        {
            return "nests";
        }

        public virtual string Sound()
        {
            return "chirp chirp";
        }
    }
}

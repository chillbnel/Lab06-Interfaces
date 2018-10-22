using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    public abstract class Fish : Animal
    {
        public override bool livesOnLand { get; set; }
        public override bool livesInWater { get; set; }
        public virtual bool Migrates { get; set; }


        public override string FavoriteFood()
        {
            return "worms on a hook";
        }
        public override string Habitat()
        {
            return "fish tank";
        }

        public virtual string Sound()
        {
            return "woosh woosh";
        }
    }
}

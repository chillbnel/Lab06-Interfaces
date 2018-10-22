using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    public abstract class InsectArachnid : Insects
    {
        public virtual string Color { get; set; }
        public override bool livesOnLand { get; set; }
        public override bool livesInWater { get; set; }


        public override string FavoriteFood()
        {
            return "insects";
        }
        public override string Habitat()
        {
            return "dark corners";
        }

    }
}

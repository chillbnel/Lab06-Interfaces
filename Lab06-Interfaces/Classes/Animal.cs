using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    public abstract class Animal
    {
        public abstract bool livesOnLand { get; set; }
        public abstract bool livesInWater { get; set; }


        public abstract string FavoriteFood();
        public abstract string Habitat();
    }
}

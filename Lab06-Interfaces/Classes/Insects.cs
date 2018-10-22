using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    public abstract class Insects : Animal
    {
        public virtual int NumberOfLegs()
        {
            return 8;
        }
    }
}

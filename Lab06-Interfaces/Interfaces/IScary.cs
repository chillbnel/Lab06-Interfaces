using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Interfaces
{
    interface IScary
    {
        bool IsBrianScaredofIt { get; set; }

        int ScaredScale();
    }
}

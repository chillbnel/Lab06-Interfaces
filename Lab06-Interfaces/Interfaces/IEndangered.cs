using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Interfaces
{
    interface IEndangered
    {
        bool IsEndangered { get; set; }

        string Classification();
    }
}

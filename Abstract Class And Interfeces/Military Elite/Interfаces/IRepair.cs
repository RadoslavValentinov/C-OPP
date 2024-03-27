using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfeces
{
    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}

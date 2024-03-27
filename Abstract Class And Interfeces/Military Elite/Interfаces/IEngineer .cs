using System.Collections.Generic;

namespace MilitaryElite.Interfeces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyList<IRepair> Repairs { get; }
    }
}
using System.Collections.Generic;

namespace MilitaryElite.Interfeces
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyList<IMission> Missions { get; }
    }

}
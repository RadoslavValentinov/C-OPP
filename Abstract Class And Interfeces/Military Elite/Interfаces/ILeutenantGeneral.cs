using System.Collections.Generic;

namespace MilitaryElite.Interfeces
{
    public interface ILeutenantGeneral : IPrivate
    {
        IReadOnlyList<IPrivate> PrivateSoldiers { get; }
    }
}
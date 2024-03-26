using System.Collections.Generic;

namespace CollectionHierarchy.Interfeces
{
    public interface IMyList<T>: IAddRemoveCollection<T>
    {
        IReadOnlyCollection<T> Used { get; }
    }
}
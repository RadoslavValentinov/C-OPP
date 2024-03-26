namespace CollectionHierarchy.Interfeces
{
    public interface IAddRemoveCollection<T>:IAddCollection<T>
    {
        T Remove();
    }
}
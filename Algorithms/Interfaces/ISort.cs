namespace Algorithms.Interfaces
{
    internal interface ISort<T>
    {
        IEnumerable<T[]> Sort(Comparer<T> comparer);
    }
}

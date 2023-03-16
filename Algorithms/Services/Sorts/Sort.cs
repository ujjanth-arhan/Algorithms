using Algorithms.Interfaces;
using Algorithms.Service.Sorts;

namespace Algorithms.Services.Sorts
{
    internal class Sort<T>
    {
        internal IEnumerable<T[]> InsertionSort(IEnumerable<T> input, Comparer<T> comparer)
        {
            ISort<T> sort = new InsertionSort<T>(input);
            return sort.Sort(comparer);
        }
    }
}

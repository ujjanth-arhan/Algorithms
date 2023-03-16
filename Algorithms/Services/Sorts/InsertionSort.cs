using Algorithms.Interfaces;

namespace Algorithms.Service.Sorts
{
    internal class InsertionSort<T> : ISort<T>
    {
        private T[] _input;
        private int _startIndex;
        private int _endIndex;

        public InsertionSort(IEnumerable<T> input)
        {
            _input = input.ToArray<T>();
            _startIndex = 0;
            _endIndex = input.Count() - 1;
        }

        IEnumerable<T[]> ISort<T>.Sort(Comparer<T> comparer)
        {
            int i = _startIndex;
            while (i <= _endIndex)
            {
                int j = i - 1;
                T comparedValue = _input[i];
                while (j >= 0 && comparer.Compare(comparedValue, _input[j]) < 0)
                {
                    _input[j + 1] = _input[j];
                    j--;
                }

                _input[++j] = comparedValue;
                i++;

                yield return _input;
            }
        }
    }
}

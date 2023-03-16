using Algorithms.Enums;
using Algorithms.Services.Sorts;
using Algorithms.Utilities;

namespace Algorithms
{
    public class Algorithm<T>
    {
        private readonly Sort<T> _sort;
        public Algorithm()
        {
            _sort = new Sort<T>();
        }

        public static List<string> HealthCheck()
        {
            var status = new List<string>
            {
                "Working peacefully"
            };

            return status;
        }

        private static IEnumerable<T> GenerateRandomObjects(int size = 10, int lowerBound = int.MinValue, int upperBound = int.MaxValue, RandomGenerationTypeEnum randomGenerationType = RandomGenerationTypeEnum.Integer)
        {
            return randomGenerationType switch
            {
                RandomGenerationTypeEnum.Integer => (IEnumerable<T>)RandomGeneration.Integers(size, seed: null, lowerBound, upperBound),
                _ => throw new ArgumentException("Illegal random generation type!"),
            };
        }

        public IEnumerable<T[]> InsertionSort(IEnumerable<T>? input = null, Comparer<T>? comparer = null)
        {
            if (input is null || !input.Any()) input = GenerateRandomObjects(10, 0, 20);
            comparer ??= Comparer<T>.Default;
            return _sort.InsertionSort(input, comparer);
        }
    }
}
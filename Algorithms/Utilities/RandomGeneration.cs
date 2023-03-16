using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Utilities
{
    internal class RandomGeneration
    {
        public static List<int> Integers(int size = 10, int? seed = null, int? minValue = null, int? maxValue = null)
        {
            var random = new Random();
            if (seed.HasValue)
            {
                random = new Random((int)seed);
            }

            minValue = minValue.HasValue? minValue: int.MinValue;
            maxValue = maxValue.HasValue? maxValue: int.MaxValue;

            var result = new List<int>();
            var counter = 1;
            while(counter <= size)
            {
                result.Add(random.Next((int)minValue, (int)maxValue));
                counter++;
            }

            return result;
        }
    }
}

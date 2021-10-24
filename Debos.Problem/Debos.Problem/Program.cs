using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Debos.Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool PoolContainsSequence(List<int> pool, List<int> sequence)
        {
            if (pool is null || !pool.Any())
                return false;

            if (sequence is null || !sequence.Any())
                return false;

            var poolDictionary = BuildDictionary(pool);
            var sequenceDictionary = BuildDictionary(sequence);
            var i = 0;
            foreach (var item in sequenceDictionary)
            {
                Console.WriteLine($"Repeats: {++i}");
                if (!poolDictionary.ContainsKey(item.Key))
                    return false;
                if (poolDictionary[item.Key] < item.Value)
                    return false;
            }
            return true;
        }

        private static Dictionary<int, int> BuildDictionary(List<int> pool)
        {
            var poolDictionary = new Dictionary<int, int>();
            var i = 0;
            foreach (var item in pool)
            {
                Console.WriteLine($"Repeats: {++i}");
                if (poolDictionary.ContainsKey(item))
                    poolDictionary[item] += 1;
                else
                    poolDictionary.Add(item, 1);
            }
            return poolDictionary;
        }
    }
}

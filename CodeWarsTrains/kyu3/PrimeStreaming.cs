using System;
using System.Collections.Generic;

namespace kyu3
{
    /// <summary>
    /// Prime Streaming (PG-13)
    /// https://www.codewars.com/kata/prime-streaming-pg-13
    /// </summary>
    public class PrimeStreaming
    {
        public static IEnumerable<int> Stream()
        {
            var primes = new List<int>() { 2 };
            yield return 2;

            for (var i = 3; ; i += 2)
            {
                if (!Check(i, primes)) continue;
                primes.Add(i);
                yield return i;
            }
        }

        private static bool Check(int i, IEnumerable<int> primes)
        {
            var max = Math.Sqrt(i);
            foreach (var p in primes)
            {
                if (i % p == 0) return false;
                if (p > max) break;
            }
            return true;
        }
    }

    public class PrimeStreamingMy
    {
        private const int StreamSize = 1000010;
        private static List<int> _primeList;

        public static IEnumerable<int> Stream()
        {
            if (_primeList != null) return _primeList;
            _primeList = new List<int>() { 2, 3, 5, 7 };
            var currentPrime = 11;
            while (_primeList.Count < StreamSize)
            {
                _primeList.Add(currentPrime);
                currentPrime = FindNextPrime(currentPrime);
            }

            return _primeList;
        }

        private static int FindNextPrime(int current)
        {
            while (true)
            {
                current += 2;
                if (current % 5 == 0) continue;
                if (IsPrime(current)) return current;
            }
        }

        private static bool IsPrime(int number)
        {
            var tmp = Math.Sqrt(number);
            foreach (var prime in _primeList)
            {
                if (prime > tmp) break;
                if (number % prime == 0) return false;
            }

            return true;
        }
    }
}

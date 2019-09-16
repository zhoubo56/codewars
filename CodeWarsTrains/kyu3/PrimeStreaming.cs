using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace kyu3
{
    /// <summary>
    /// Prime Streaming (PG-13)
    /// https://www.codewars.com/kata/prime-streaming-pg-13
    /// </summary>
    public class PrimeStreaming
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

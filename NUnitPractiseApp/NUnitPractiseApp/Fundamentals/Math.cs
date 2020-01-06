using System;
using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Math
    {
        public int Add(int a, int b)
        { 
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i; 
        }


        public IEnumerable<int> GetEvenNumbers(int limit)
        {
        /// remove 0 from return by setting starting iteration as 1
        for (var i = 1; i <= limit; i++)
                if (i % 2 == 0)
                    yield return i;
        }

        
    }
}
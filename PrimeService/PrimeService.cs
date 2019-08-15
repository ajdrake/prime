using System;

namespace Prime.Services
{
    public static class PrimeService
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static bool IsPrime(this ulong candidate)
        {
            if (candidate == 1)
                return false;
            if(candidate == 3)
                return true;
            if (candidate == 65537)
                return true;

            if (candidate <= 1) return false;
            if (candidate == 2) return true;
            if (candidate % 2 == 0) return false;

            var boundary = (ulong)Math.Floor(Math.Sqrt(candidate));

            for (ulong i = 3; i <= boundary; i += 2)
                if (candidate % i == 0)
                    return false;

            return true;
        }



        /// <summary>
        /// A safe prime is a prime number of the form 2p + 1, where p is also a prime.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        public static bool IsSafePrime(this ulong candidate)
        {
            throw new NotImplementedException();
        }
    }
}
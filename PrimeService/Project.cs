using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            for (int i = 1; i*i <= candidate; i++)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
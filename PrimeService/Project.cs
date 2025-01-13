using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate, string res)
        {
            if (candidate < 2)
            {
                if(res == "Not a prime Number")
                {
                    return true;
                }
                return false;
            }
            for (int i = 2; i*i <= candidate; i++)
            {
                if (candidate % i == 0)
                {
                    if (res == "Not a prime Number")
                    {
                        return true;
                    }
                    return false;
                }
            }
            if (res == "Prime Number")
            {
                return true;
            }
            return false;
        }
    }
}
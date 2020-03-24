namespace Lab001.Ex02
{
    public class PrimeAlgorithms
    {
        public int First(int n)
        {
            var max = -1;
            for (var i = 0; i <= n; i++)
            {
                if(IsPrime(i) && i > max)
                {
                    max = i;
                }
            }

            return max;
        }

        public int Second(int n)
        {
            for (var i = n; i >= 1; i--)
            {
                if(IsPrime(i))
                {
                    return i;
                }
            }

            return 2;
        }

        private bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }

            if(n == 2 || n == 3)
            {
                return true;
            }

            for (var i = 3; i * i <= n; i+=2)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

namespace NthFibonacci.App
{
    public class CalculateTheNthFibonacciNumber : ICalculateTheNthFibonacciNumber
    {
        public int NthFib(int n)
        {
            if(n <= 2)
            {
                return n - 1;
            }
            else
            {
                int firstValue = 0;

                int secondValue = 1;

                int nextValue = 0;

                for (int i = 2; i < n; i++)
                {
                    nextValue = firstValue + secondValue;

                    firstValue = secondValue;

                    secondValue = nextValue;
                }

                return nextValue;
            }            
        }
    }
}

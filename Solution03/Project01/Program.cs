namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1:Switch Statements

            #endregion

            #region Task 5: Sum of Even and Odd Numbers
            Console.WriteLine("Enter a positive integer N:");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Please enter a positive number");
            }
            else
            {
                int evenSum = 0;
                int oddSum = 0;

                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += i; // even number
                    }
                    else
                    {
                        oddSum += i; // odd number
                    }
                }

                Console.WriteLine("Sum of even numbers: " + evenSum);
                Console.WriteLine("Sum of odd numbers: " + oddSum);
            }
            #endregion

            #region 

            #endregion
        }
    }
}
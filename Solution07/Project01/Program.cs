namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2D Array:

            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of cols: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("_____________________\n");

            int[,] num = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Console.Write($"plz Enter element at [{i},{x}]: ");
                    num[i, x] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n2D Array values:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}]={num[i, j]}\t");
                }
                Console.WriteLine();
            }

            #endregion


        }
    }
}

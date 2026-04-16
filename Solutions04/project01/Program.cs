namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("My Age is 20");
            }



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Number:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("My Age is 20");
            }
            #endregion

            #region Insted Loop
            for (int x = 1; x < 6; x++)
            {
                for (int y = 1; y < 6; y++)
                {
                    Console.WriteLine($"({x},{y})");
                }
            }
            #endregion



        }
    }
    }


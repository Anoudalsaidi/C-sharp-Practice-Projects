namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Function Task
            bool again = true;

            while (again)
            {
                Calculate();

                Console.Write("\nDo you want to calculate again? (y/n): ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "y")
                    again = false;
            }
        }

        static void Calculate()
        {
            Console.Write("plz Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("plz Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose operation:");
            Console.WriteLine("1 )  +");
            Console.WriteLine("2 ) -");
            Console.WriteLine("3 ) *");
            Console.WriteLine("4 ) /");

            Console.Write("Your choice: ");
            int op = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine("Result Calculate = " + result);
            #endregion

        }
    }
}

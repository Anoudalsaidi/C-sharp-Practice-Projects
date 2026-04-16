namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1:Switch Statements

            Console.WriteLine("Enter a number from 1 to 7:");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number, Try Agin!");
                    break;
            }
            #endregion

            #region Task 2: For Loop Statements
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num1} x {i} = {num1 * i}");
            }
            #endregion

        }
    }
}
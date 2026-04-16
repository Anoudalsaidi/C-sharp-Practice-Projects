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

            #region Task 3: while Loop Statements
            Console.WriteLine("Enter a positive number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 <= 0)
            {
                Console.WriteLine("Please enter a positive number");
            }
            else
            {
                while (num2 >= 1)
                {
                    Console.WriteLine(num2);
                    num2--;
                }

                Console.WriteLine("Go!");
            }
            #endregion

            #region Task 4: Season Detector with Month Validation

            Console.WriteLine("Enter a month number (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;

                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
            #endregion
        }
    }
}
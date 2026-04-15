using System.ComponentModel.Design;

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Task-1 Conditions and If Statements : Positive - Negative - Zero Numbers

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            #endregion


            #region Task-2 IF CONDITION : Even or Odd
            Console.WriteLine("Enter an integer number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }


            #endregion



            #region Task-3 IF CONDITION :Syudent Grade System 
            Console.WriteLine("Enter student score (0 - 100):");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (score >= 75 && score <= 89)
            {
                Console.WriteLine("Very Good");
            }
            else if (score >= 60 && score <= 74)
            {
                Console.WriteLine("Good");
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine("Pass");
            }
            else if (score >= 0 && score < 50)
            {
                Console.WriteLine("Below Fail");
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
            #endregion




            #region Task-4 IF CONDITION :Simple Login System
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            int password = Convert.ToInt32(Console.ReadLine());

            if (username == "admin" && password == 1234)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
            #endregion



            #region // Task-5 IF CONDITION :Simple ATM System
            int balance = 1000;

            Console.WriteLine("Enter withdrawal amount:");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Grater than Balance");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine(" Balance Now : " + balance);
            }
            #endregion


        }
    }
}

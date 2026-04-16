namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Arithmetic Operators: 

            Console.WriteLine("plz enter first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("plz enter second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
    }
}

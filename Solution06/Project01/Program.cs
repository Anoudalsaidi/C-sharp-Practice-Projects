namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array:

            int[] number = new int[4];

            for(int i=0; i<number.Length; i++)
            {
                Console.WriteLine("Enter 4 numbers");
                number[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            Console.WriteLine("___________________");
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}

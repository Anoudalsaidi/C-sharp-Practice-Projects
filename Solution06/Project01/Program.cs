namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Array using For Loop

            //int[] number = { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < number.Length; i++)
            //{

            //    Console.WriteLine(number[i]);

            //}
            #endregion

            #region Q2:Array using Foreach

            int[] numbers = { 10, 20, 30, 40, 50 };


            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            #endregion

        }
    }
}

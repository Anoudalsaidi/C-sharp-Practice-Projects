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

            //int[] numbers = { 10, 20, 30, 40, 50 };


            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Q3:Array with user input

            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number :");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("_____Numbers______");
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Q4:Array with calculate total input numbers

            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number :");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //Console.WriteLine("_____Numbers______");
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //    sum += i;
            //}
            //Console.WriteLine("_____Sum Numbers______");
            //Console.WriteLine(sum);

            #endregion

            #region Q5:Array with calculate MAX input numbers

            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number :");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //int max = num[0];

            //Console.WriteLine("_____Numbers______");

            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //    sum += i;

            //    if (i > max) 
            //    {
            //        max = i;
            //    }
            //}

            //Console.WriteLine("_____Sum Number______");
            //Console.WriteLine(sum);

            //Console.WriteLine("_____Max Number______");
            //Console.WriteLine(max);
            #endregion

            #region Q6:Array with calculate MIN input numbers

            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter Number :");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            int max = num[0];
            int min = num[0];

            Console.WriteLine("_____Numbers______");

            foreach (int i in num)
            {
                Console.WriteLine(i);
                sum += i;

                if (i > max)
                {
                    max = i;
                }

                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("_____Sum Number______");
            Console.WriteLine(sum);


            Console.WriteLine("_____Min Number______");
            Console.WriteLine(min);

            #endregion

        }
    }
}

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

            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number :");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //int min = num[0];

            //Console.WriteLine("_____Numbers______");

            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //    sum += i;

            //    if (i < min)
            //    {
            //        min = i;
            //    }
            //}

            //Console.WriteLine("_____Sum Number______");
            //Console.WriteLine(sum);


            //Console.WriteLine("_____Min Number______");
            //Console.WriteLine(min);

            #endregion

            #region Q7:Array with ONLY SHOW EVEN NUMBERS 
            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number :");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("_____Even Numbers______");

            //foreach (int i in num)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q8:Array with calculate AVERAGE input numbers
            //int[] num = new int[5];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number :");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;

            //foreach (int i in num)
            //{
            //    sum += i;
            //}

            //double avg = (double)sum / num.Length;
            //Console.WriteLine("--------------");
            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("--------------");
            //Console.WriteLine("Average = " + avg);
            #endregion

            #region Q9:Array with SORT input numbers

            //int[] num = new int[5];


            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number :");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Console.WriteLine("_____Reversed Numbers______");

            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(num[i]);
            //}
            #endregion

            #region Q10:Array with Search array numbers

            int[] num = new int[5];

         
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter Number :");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

          
            Console.WriteLine("Enter number to search:");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;

           
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == search)
                {
                    Console.WriteLine("Number Found at Index " + i);
                    found = true;
                    break; 
                }
            }

          
            if (!found)
            {
                Console.WriteLine("Number Not Found");
            }

            #endregion

        }
    }
}

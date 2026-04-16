namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region For Loop

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("My Age is 20");
            //}

            //#endregion

            //#region Input Loop

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter Number:");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //}

            //#endregion

            //#region Nested Loop

            //for (int x = 1; x < 6; x++)
            //{
            //    for (int y = 1; y < 6; y++)
            //    {
            //        Console.WriteLine($"({x},{y})");
            //    }
            //}

            //#endregion

            //#region Prime Number

            //Console.WriteLine("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //bool Prime = true;

            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Prime = false;
            //        break;
            //    }
            //}

            //if (num > 1 && Prime)
            //{
            //    Console.WriteLine("Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime Number");
            //}

            // #endregion
            //#region While Loop
            //Console.WriteLine("Enter any Number");
            //int numm = Convert.ToInt32(Console.ReadLine());

            //Random rand = new Random();
            //int trynum = 0;

            //while (numm != 0)

            //{
            //    numm = rand.Next(1, 10);
            //    Console.WriteLine(numm);

            //    if (numm == 5 && trynum <3)
            //    {
            //        Console.WriteLine("Stop");
            //        break;
            //    }
            //}

            //#endregion


            #region String:Palindrome
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            #endregion


        }
    }
}
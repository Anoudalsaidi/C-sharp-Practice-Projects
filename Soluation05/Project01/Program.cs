namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Errors Types:

            //#region Syntax Error
            //Console.WriteLine("Hello, World!");
            //#endregion

            //#region Runtime Error
            //int x = 10;
            //int y = 0;
            //int result = x / y; // Runtime Error
            //#endregion

            //#region Logical Error
            //int a = 10;
            //int b = 5;
            //int rresult = a - b; // المفروض جمع لكن كتبنا طرح
            //#endregion

            //#endregion

            #region Error Handling

            Console.WriteLine("Enter Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(num1 / num2);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }

            finally
            {
                int resualt = Convert.ToInt32(Console.ReadLine());
                int final = resualt / num2;
                Console.WriteLine(final);
            }
            #endregion
        }
    }
}

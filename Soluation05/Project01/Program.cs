namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Errors Types:

            #region Syntax Error
            Console.WriteLine("Hello, World!");
            #endregion

            #region Runtime Error
            int x = 10;
            int y = 0;
            int result = x / y; // Runtime Error
            #endregion

            #region Logical Error
            int a = 10;
            int b = 5;
            int rresult = a - b; // المفروض جمع لكن كتبنا طرح
            #endregion

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}

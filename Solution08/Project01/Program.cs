using System.IO;
namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working With Files
            File.Create("test.txt");


            string[] data = { "Anoud", "Ahmed", "Ali" };
            File.WriteAllLines("test.txt", data);


            File.AppendAllText("test.txt", "\nhi");

            string myfile = File.ReadAllText("test.txt");
            Console.WriteLine(myfile);

            string[] myfiles = File.ReadAllLines("test.txt");
            Console.WriteLine(myfiles[1]);


            #endregion
        }
    }
}

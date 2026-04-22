using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working With Files
            //File.Create("test.txt");


            //string[] data = { "Anoud", "Ahmed", "Ali" };
            //File.WriteAllLines("test.txt", data);


            //File.AppendAllText("test.txt", "\nhi");

            //string myfile = File.ReadAllText("test.txt");
            //Console.WriteLine(myfile);

            //string[] myfiles = File.ReadAllLines("test.txt");
            //Console.WriteLine(myfiles[1]);

            #endregion

            #region copy from file to other
            //try
            //{
            //    File.Copy("test.txt", "copy.txt");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region user choose and open one of three text files with error handling
            //File.Create("exam1.txt");
            //File.Create("exam2.txt");
            //File.Create("exam3.txt");



            try
            {
                Console.WriteLine("select Exam File:");
                Console.WriteLine("1 - Exam 1");
                Console.WriteLine("2 - Exam 2");
                Console.WriteLine("3 - Exam 3");

                Console.Write("Enter your choice: ");
                int select = Convert.ToInt32(Console.ReadLine());



                if (select == 1)
                    Process.Start("NotePad.exe", "exam1.txt");

                else if (select == 2)
                    Process.Start("NotePad.exe", "exam2.txt");

                else if (select == 3)
                    Process.Start("NotePad.exe", "exam3.txt");

                else
                {
                    Console.WriteLine("Invalid choice!");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
            }

            #endregion
        }
    }
}

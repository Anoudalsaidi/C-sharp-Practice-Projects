namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2D Array:

            //Console.Write("Enter number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number of cols: ");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //Console.Write("_____________________\n");

            //int[,] num = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int x = 0; x < cols; x++)
            //    {
            //        Console.Write($"plz Enter element at [{i},{x}]: ");
            //        num[i, x] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n2D Array values:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"[{i},{j}]={num[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Student Management System Using Arrays (C#) -Assignment

            #region Part 1 – Student Names (1D Array)

            string[] students = new string[5];


            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Enter Student Name {i + 1}: ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("\nStudent Names:");


            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region Part 2 – Student Grades (2D Array)

            int[,] grades = new int[5, 3];
            string[] subjects = { "Math", "Science", "English" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nEnter grades for {students[i]}:");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter {subjects[j]}: ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            #endregion

            #region Part 3 – Display Grades Table 
            Console.WriteLine("\nGrades Table:");
            Console.WriteLine("______________");
            Console.Write("Student\t");
            foreach (string sutdns in subjects)
                Console.Write(sutdns + "\t");
            
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(students[i] + "\t");

                for (int x= 0; x < 3; x++)
                {
                    Console.Write(grades[i, x] + "\t");
                }

                Console.WriteLine();
            }

            #endregion

            #region Part 4 – Average For each Sudents
            Console.WriteLine("\nStudent Averages:");
            Console.WriteLine("_________________");
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = sum / 3.0;
                Console.WriteLine($"{students[i]} Average = {avg}");
            }
            #endregion

            #region Part 5 – Jagged Array

            int[][] jGrades = new int[5][];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"\nHow many subjects for {students[i]}? ");
               
                int subjectCount = Convert.ToInt32(Console.ReadLine() ?? "0");

               
                jGrades[i] = new int[subjectCount];

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write($"Enter grade {j + 1}: ");
                    jGrades[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged Array Data:");
            Console.WriteLine("------------------");

            for (int i = 0; i < jGrades.Length; i++)
            {
                Console.WriteLine($"\n{students[i]} Subjects: {jGrades[i].Length}");

                foreach (int g in jGrades[i])
                {
                    Console.Write(g + " ");
                }
            }

            #endregion

            #region Part 6 – Search Student

            Console.Write("\n\nEnter student name to search: ");
            string search = Console.ReadLine();

            int index = -1;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == search)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine($"Student found at index {index}");
            else
                Console.WriteLine("Student not found");

            #endregion

            #region Part 7 – Highest Grade

            int max = grades[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grades[i, j] > max)
                    {
                        max = grades[i, j];
                    }
                }
            }

            Console.WriteLine($"\nHighest Grade = {max}");

            Array.Sort(students);
            #endregion

            #region highest average and  passed Students
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = sum / 3.0;

                if (avg >= 50)
                {
                    count++;
                }
            }

            Console.WriteLine("Passed students = " + count);
            #endregion
            #endregion


        }
    }
}

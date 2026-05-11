using System.Threading.Channels;

namespace project01
{

    #region objects Relationship (Assocoation)
    class student
    {
        public string name;
    }

    class study
    {
        public string course;

        public void teach(student std)
        {
            Console.WriteLine(std.name + " is studying " + course);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "Anoud";

            study sub = new study();
            sub.course = "C#";

            sub.teach(s1);
        }
    }
    #endregion


    }
    


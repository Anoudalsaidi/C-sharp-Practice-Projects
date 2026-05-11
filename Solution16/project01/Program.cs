using System.Threading.Channels;

namespace project01
{

    #region objects Relationship (Assocoation)
    //class student
    //{
    //    public string name;
    //}

    //class study
    //{
    //    public string course;

    //    public void teach(student std)
    //    {
    //        Console.WriteLine(std.name + " is studying " + course);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        student s1 = new student();
    //        s1.name = "Anoud";

    //        study sub = new study();
    //        sub.course = "C#";

    //        sub.teach(s1);
    //    }
    //}
    #endregion

    #region objects Relationship ( Aggregation )
    //class Employee
    //{
    //    public string Name;
    //}

    //class Department
    //{
    //    public string DepartmentName;

    //    // Aggregation
    //    public List<Employee> Employees = new List<Employee>();
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee emp1 = new Employee();
    //        emp1.Name = "Anoud";

    //        Department dept = new Department();
    //        dept.DepartmentName = "IT";

    //        dept.Employees.Add(emp1);

    //        Console.WriteLine(emp1.Name + " works in " + dept.DepartmentName);
    //    }
    //}

    #endregion

    #region objects Relationship(Composition) 
    class Room
    {
        public string Name;

        public Room(string name)
        {
            Name = name;
        }
    }

    class House
    {
        // Composition: House owns Rooms
        private List<Room> rooms;

        public House()
        {
            rooms = new List<Room>
        {
            new Room("Bedroom"),
            new Room("Kitchen"),
            new Room("saloon")
        };
        }

        public void ShowRooms()
        {
            foreach (var room in rooms)
            {
                Console.WriteLine(room.Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.ShowRooms();
        }
    }
}
    #endregion

    



namespace project01
{
    internal class Program
    {
        #region properties (Gitter & Setter)
        class car
        {
            public int model;
            public string color;
            private int speed;
            public int Speed
            {

                get { return speed; }
                set { if (value > 0)
                        speed = value; }
            }
            static void Main(string[] args)
            {
                car myob = new car();
                myob.color = "red";
                myob.model = 2000;


                Console.WriteLine("enter speed value");
                myob.Speed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(myob.Speed);
            }
        #endregion

        }
    }
}

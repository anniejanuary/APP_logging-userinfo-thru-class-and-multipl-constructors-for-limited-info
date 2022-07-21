using System;

namespace UsingMultipleConstructors2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human eve = new Human("Eve", "Polastri");
            eve.introduceMyself();
            Human vilanelle = new Human("Oksana", "Ostankova", 28, "green");
            vilanelle.introduceMyself();
            Human catherine = new Human("Catherine");
            catherine.introduceMyself();

            Console.Read();
        }
    }
}

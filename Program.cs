using System;

namespace การบ้านวันเสาร์ครั้งที่5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xtime, Yprice;
            string mode;

            Console.WriteLine();
            mode = Console.ReadLine();
            Console.WriteLine();
            Xtime = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Yprice = double.Parse(Console.ReadLine());

            if (mode == "time" || mode == "price")
            {
                if (Xtime <= 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
                else if (mode == "time")
                {
                    Yprice = Math.Pow((Xtime - 1), 2);
                    Console.WriteLine("{0}, {1}", Xtime, Yprice);
                }
                else if (mode == "price")
                {
                    Xtime = Math.Sqrt(Yprice)+1;
                    Console.WriteLine("{0}, {1}", Xtime, Yprice);
                }
            }
            else 
            {
                Console.WriteLine("Invalid mode");
            }
            Console.ReadLine();
        }
    }
}

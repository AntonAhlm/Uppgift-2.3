
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många meter kan du hoppa i höjdhopp? ");
            double höjd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Världsrekordet i höjdhopp är " + (2.45 - höjd) + "meter högre.");

        }
    }
}

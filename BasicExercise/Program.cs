using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Factorial Program");
            Console.WriteLine("Enter a Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Pattern pattern = new Pattern();
                    pattern.Number();
                    break;
            }
            Console.ReadLine();
        }
    }
}

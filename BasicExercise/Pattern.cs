using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class Pattern
    {
        public void Number()
        {
            int k = 1;
            Console.WriteLine("Enter The Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= Number; i++)
            {
                k = k * i;
            }
            Console.WriteLine("The Factorial of {0} is {1}", Number, k);
        }
    }
}

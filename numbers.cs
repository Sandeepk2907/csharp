using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class numbers
    {
        public numbers()
        {
        }

        public void num(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The number is Positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine("The number is Negative.");
            }
            else
            {
                Console.WriteLine("The number is Zero.");
            }
        }
    }
}

    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    public class reverse2
    {
        int number;
        int reverse = 0;
        public void rev()
        {
            Console.Write("Enter a number: ");
            
            number = Convert.ToInt32(Console.ReadLine());
          

            while (number != 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number = number / 10;
            }
        }
        public void display()
        {
            Console.Write("Reversed Number:" + reverse);
        }

        }
    }

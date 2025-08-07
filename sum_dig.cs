using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digit
{
    public class sum_dig
    {
       
        int num = Convert.ToInt32(Console.ReadLine());
        int s = 0;
        public void sum()
        {
             int temp = num;
            while (temp != 0)
            {
                int digit = temp % 10;
                s += digit;
                temp /= 10;
            }
        }
        public void display()
        {
            Console.WriteLine("Sum of digits: " + s);
        }
    }
}
    
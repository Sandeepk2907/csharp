using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class encap
    {
        public void de()
        { }
            private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age Should be between 0 And 100");
                }
            }
        }

        public void display()
        {
            Console.WriteLine($"Name :{name}");
            Console.WriteLine($"Age:{age}");
        }
    }

  }





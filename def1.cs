using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class def1
    {
        public string name;
        public int age;
        public def1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age:{age}");
        }
    }
}

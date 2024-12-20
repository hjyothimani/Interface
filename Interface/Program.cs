using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ij k = new A();
            var h=k.add(10,30);
            Console.WriteLine(h.Item1);
            Console.WriteLine(h.Item2);
            Console.WriteLine("hi");
        }
    }
}

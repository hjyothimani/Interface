using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //interface Ijothi
    //{
    //    void add();
    //}
    //public class Interface : Ijothi
    //{
    //    public void add()
    //    {
    //        int a = 10;
    //        int b = 20;
    //        Console.WriteLine(a + b);

    //    }
    //}

    interface Imani
    {
        int add();
        int add(int a,int b);
    }
    
    public class A:Imani
    {
        public int add()
        {
            int a = 10;
           return a;

        }
        public int add(int a,int b)
        {
            return a + b;
        }
    }
}

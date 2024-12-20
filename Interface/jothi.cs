using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
        public interface Ij
        {
            int add();
            (int, int) add(int a, int b);

        }

        public class A : Ij
        {
            public int add()
            {
                int a = 10;
                return a;

            }
            public (int, int) add(int a, int b)
            {
                return (a, b);
            }

        }
    
}

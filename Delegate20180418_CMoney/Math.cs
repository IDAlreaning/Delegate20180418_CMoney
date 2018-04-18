using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate20180418_CMoney
{
    class Math
    {
        public void Add(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public void Minus(int i, int j)
        {
            Console.WriteLine(i - j);
        }
        public void Mutiple(int i, int j)
        {
            Console.WriteLine(i * j);
        }
        public void Divide(int i, int j)
        {
            Console.WriteLine(i / j);
        }
    }
}

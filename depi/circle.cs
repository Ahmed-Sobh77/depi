using System;
using System.Collections.Generic;
using System.Text;

namespace depi
{
    internal class circle : shape
    {
        public int x;
        public circle(int x)
        {
            this.x = x;
           
        }
        public override double calcArea()
        {
            return x * x * 3.14;
        }
    }
}

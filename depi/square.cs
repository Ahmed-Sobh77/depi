using System;
using System.Collections.Generic;
using System.Text;

namespace depi
{
    internal class Square : rectangle
    {
    
        public Square(int x):base(x,x)
        {
            this.x = x;
            this.y = x;
        }
    }
}

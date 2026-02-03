using System;
using System.Collections.Generic;
using System.Text;

namespace depi
{
    internal class Square : rectangle
    {
        public int x,y;
        public Square(int x)
        {
            this.x = x;
            this.y = x;
        }
    }
}

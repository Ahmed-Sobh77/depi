using System;
using System.Collections.Generic;
using System.Text;

namespace depi
{
    internal class rectangle : shape
    {
       public rectangle(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override double calcArea()
        {
            return x * y;
        }
    }
}

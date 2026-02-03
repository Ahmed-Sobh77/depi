using System;
using System.Collections.Generic;
using System.Text;

namespace depi
{
    internal class picture
    {

        public double calcArea(shape[] arr)
        {
            double ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                ans += arr[i].calcArea();
            }
            return ans;

        }
    }
}

using System;
namespace Calculator
{
    public class CalcManager
    {
        public double Add(double x, double y)
        {
            return x+y;
        }
        public double Sub(Double x, double y)
        {
            return x-y;

        }
        public double mul(Double x, double y)
        {
            return x*y;
        }
        public double del(Double x, double y)
        {
            if (y!=0)
            {
                return x/y;
            }
            else 
            {
                return 0;
            }

        }

    }
}
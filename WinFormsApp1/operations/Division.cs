using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.operations
{
    public class Division
    {
        public double Calculate(double a, double b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}

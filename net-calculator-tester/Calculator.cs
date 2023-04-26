using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
     public static float Add(float num1, float num2)=> num1 + num2;
     public static float Subtract(float num1, float num2) => num1 - num2;
     public static float Divide(float num1, float num2)
        {
            if (num2 == 0) return 0;
            else return (num1/num2);
        }

     public static float Multiply(float num1, float num2)=>num1 * num2;

      
    public static double pow(this int n, double esp)
    {
       if (n == 0) return 0;
       if (esp == 0) return 1;

       double nPow =n;
       if (esp > 0)
          for (int i = 1; i < esp; i++)
             nPow *=  n;
       else
       {
           nPow = (1.0 / n);
           for (int i = 1; i < Math.Abs(esp); i++)
           nPow *= (1.0 / n);
       }
       return nPow;
     }



    }
}

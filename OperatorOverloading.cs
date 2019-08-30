using System;
class p
{
    public static void Main()
    {
        Complex num1 = new Complex(1, 2);
        Complex num2 = new Complex(3, 2);
        Console.WriteLine((num1 + num2).ToString());
        Console.Read();
    }
}

class Complex
{
      public double r, i;
      public double length
      {
            get
            {
                  return System.Math.Sqrt(r*r+i*i);
            }
      }
      public Complex(double dR, double dI)
      {
            r = dR;
            i = dI;
      }

      public static Complex operator +(Complex num1, Complex num2)
      {
            Complex ret = new Complex(num1.r + num2.r, num1.i + num2.i);
            return ret;
      }
      public override string ToString()
      {
          return "(" + this.r + "," + this.i + ")";
      }
}
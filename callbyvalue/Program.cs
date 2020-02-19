using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbyvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
           
            a = 10;
            b = 20;
            ShowData(a, b);
        }
        static void ShowData(int m,int n)
        {
            
            double sum = m + n;
            Console.WriteLine("sum={0}", sum);
            m = m + 1;
            n = n + 1;
        }
    }
}

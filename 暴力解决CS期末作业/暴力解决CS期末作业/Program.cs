using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 暴力解决CS期末作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x1 = 0;
            //double x2 = 0;
            //double max = 0;
            //double precision = 0.001;

            //for(double i=-3.0 ; i<12.1 ; i+= precision)
            //    for (double j = 4.1; j < 5.8; j += precision)
            //    {
            //        double temp = 21.5 + i * Math.Sin(4 * Math.PI * i) + j * Math.Sin(20 * Math.PI * j);
            //        if(temp > max)
            //        {
            //            max = temp;
            //            x1 = i;
            //            x2 = j;
            //        }
            //    }
            //Console.WriteLine(x1+" "+x2+" "+max);
            //Console.ReadKey();

            //double i = 11.6259999999988; double j = 5.72500000000054;
            double i = 2.55224317890496; double j = 4.5476306790425;
            double temp = 21.5 + i * Math.Sin(4 * Math.PI * i) + j * Math.Sin(20 * Math.PI * j);
            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}

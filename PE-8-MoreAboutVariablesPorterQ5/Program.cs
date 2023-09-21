using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_MoreAboutVariablesPorterQ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,,] dTripArray = new double[5,5,5];
            //double y = 0.0;
            //double x = 0.0;
            //double z = (3.0 * (Math.Pow(y, 2.0) + (2.0 * x) - 1.0);
            for(double x = 0; x>= -1 && x <= 1; x+= 0.1)
            {
                Console.WriteLine(x);
                for(double y = 0; y >= 1 && y<= 4; y += 0.1)
                {
                    Console.WriteLine(y);
                    double z = (3.0 * (Math.Pow(y, 2) + (x * 2.0) - 1.0);
                    double z = z;
                }
            }
        }
    }
}

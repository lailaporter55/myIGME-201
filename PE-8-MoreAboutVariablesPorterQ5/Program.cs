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
            while (true)
            {
                for(int i = 0; i < dTripArray.GetLength(0); i++)
                {
                    for (double x = 0; x >= -1 && x <= 1; x += 0.1)
                    {
                        Console.WriteLine(x);
                        for (double y = 0; y >= 1 && y <= 4; y += 0.1)
                        {
                            Console.WriteLine(y);
                            double z = (3.0 * (Math.Pow(y, 2) + (x * 2.0) - 1.0);
                            dTripArray.SetValue(x, i);
                            dTripArray.SetValue(y, i);
                            dTripArray.SetValue(z, i);
                        }
                    }
                }
                
            }
        }
    }
}

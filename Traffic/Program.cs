using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    internal class ProgramBase1
    {
        public void AddPassanger( Vehicles.IPassangerCarrier vehicleObject)
        {
            vehicleObject.LoadPassanger();
            
            if (vehicleObject == null)
            {
                Console.WriteLine(vehicleObject.ToString());
            }
            
        }
    }

    internal class Program : ProgramBase1
    {
        static void Main(string[] args)
        {
        }
    }
}

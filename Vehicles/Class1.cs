using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }
    public abstract class Car: Vehicle
    {

    }
    public abstract class Train: Vehicle { }
    public interface IPassangerCarrier
    {
        void LoadPassanger();
    }
    public interface IHeavyLoadCarrier { }
    public class Compact : Car, IPassangerCarrier
    {
        public void LoadPassanger()
        {
            throw new NotImplementedException();
        }
    }
    public class SUV : Car, IPassangerCarrier
    {
        public void LoadPassanger()
        {
            throw new NotImplementedException();
        }
    }
    public class Pickup : Car, IPassangerCarrier, IHeavyLoadCarrier
    {
        public void LoadPassanger()
        {
            throw new NotImplementedException();
        }
    }
    public class PassengerTrain : Train, IPassangerCarrier
    {
        public void LoadPassanger()
        {
            throw new NotImplementedException();
        }
    }
    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }
    public class __424DoubleBogey : Train, IHeavyLoadCarrier { }
}

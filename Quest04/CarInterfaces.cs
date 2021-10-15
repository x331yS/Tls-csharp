using System;

namespace CSharpDiscovery.Quest04
{
    public interface IThermalCar
    {
        public int FuelLevel {set; get;}
		public void FillUp();

        public int GetFuelLevel()
        {
            var x = 0;
            return x;
        }
    }

    public interface IElectricCar
    {
        public int BatteryLevel { set; get; }
        public void Recharge();

        public int GetBatteryLevel()
        {
            var x = 0;
            return x;
        }
    }

}
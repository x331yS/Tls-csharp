using System;

namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car
    {
        public interface IThermalCar
        {

        }
        public interface IElectricCar
        {

        }
        

        public HybridCar(): base()
        {
            
        }

        public HybridCar(string model,string brand,string color, int currentSpeed = 0): base(model,brand,color,currentSpeed)
        {
           
        }
    }
}
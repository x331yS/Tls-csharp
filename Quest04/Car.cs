using System;

namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule

    {
        public string Model {set; get;}

        public override string ToString() { return string.Format($"{Color} {Brand} {Model}"); }
        public override void Accelerate(int Speed)
        {
            CurrentSpeed = CurrentSpeed + Speed;
            if (CurrentSpeed> 180)
            {
                CurrentSpeed = 180;
            }
            
        }

        public override void Brake(int BrakePower)
        {
            CurrentSpeed = CurrentSpeed - BrakePower;
            if (CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
        }

        public Car()
        {
            Brand = "Unknown";
            Model = "Unknown";
        }
        public Car(string model,string brand,string color, int currentSpeed = 0)
        {
            Model = model;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
        }

    }

}
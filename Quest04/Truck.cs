using System;

namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule

    {
        public int Tonnage {set; get;}

        public override string ToString() { return string.Format($"{Color} {Brand} {Tonnage}T Truck"); }
        public override void Accelerate(int Speed)
        {
            CurrentSpeed = CurrentSpeed + Speed;
            if (CurrentSpeed> 100)
            {
                CurrentSpeed = 100;
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

        public Truck()
        {
            Tonnage = 0;
        }
        public Truck(int tonnage,string brand,string color, int currentSpeed = 0)
        {
            Tonnage = tonnage;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
        }

    }

}
using System;

namespace CSharpDiscovery.Quest03
{
    public class Campus : PointOfInterest

    {
        public int Capacity { get; set; }
        public override string ToString() { return string.Format($"{Name} is a campus with a capacity of {Capacity} students"); }


    }

}
using System;

using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            if (currentColor == TrafficLightColor.Red)
            {
                return TrafficLightColor.Green;
            }
            if (currentColor == TrafficLightColor.None)
            {
                return TrafficLightColor.None;
            }
            if (currentColor == TrafficLightColor.Orange)
            {
                return TrafficLightColor.Red;
            }

            return TrafficLightColor.Orange;
        }
    }
}
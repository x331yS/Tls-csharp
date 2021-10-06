using System;

namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if (tab == null)
            {
                return false;
            }
            if (Array.Exists(tab, x => x == value))
            {
                return true;
            }
            return false;
        }
    }
}
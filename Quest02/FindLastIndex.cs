using System;
namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (tab == null)
            {
                return null;
            }
            int number = Array.LastIndexOf(tab, a);
            if (number < 0)
            {
                return null;
            }

            return number;
        }
    }
}
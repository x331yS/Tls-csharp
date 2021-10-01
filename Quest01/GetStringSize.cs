using System;

namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
            if (str == null)
            {
                return 0;
            }
            int x = 0;
            for (int i = 0; i < str.Length; i++) {
                x++;
            }
            return (x);
        }
    }
}
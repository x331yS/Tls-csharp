using System;

namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            string result = String.Join("",str );
            return result;
        }
    }
}
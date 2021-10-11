using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            // Your code
        }
    }
}
// Generate a random derangement.
private int[] SecretSantaAssignment(int N, out int num_tries)
{
    // Make an array to hold the assignment.
    int[] assignments = new int[N];
    for (int i = 0; i < N; i++)
        assignments[i] = i;

    // Try random permutations until we find one that works.
    //Console.WriteLine();
    num_tries = 0;
    for (; ; )
    {
        // Randomize the assignment array.
        num_tries++;
        assignments.Randomize();

        // Display this permutation.
        //for (int i = 0; i < N; i++)
        //    Console.Write(assignments[i].ToString() + " ");
        //Console.WriteLine();

        // If this is an invalid assignment, try again.
        bool is_valid = true;
        for (int i = 0; i < N; i++)
        {
            if (assignments[i] == i)
            {
                is_valid = false;
                break;
            }
        }

        // See if this is a valid assignment.
        if (is_valid) break;
    }

    return assignments;
}
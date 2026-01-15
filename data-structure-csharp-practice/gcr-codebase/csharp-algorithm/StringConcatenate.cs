using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.access
{
    class StringCompare
    {
        static void Main()
        {
            int n = 100000; 
            Console.WriteLine($"Concatenate {n} strings:\n");

            // --- StringBuilder Approach ---
            Stopwatch sw = new Stopwatch();
            sw.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("X");
            }
            string resultSb = sb.ToString();
            sw.Stop();
            Console.WriteLine($"StringBuilder (O(N)): {sw.ElapsedMilliseconds} ms");

            // --- String (Immutable) Approach ---
           
            sw.Restart();
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += "X";

            }
            sw.Stop();
            Console.WriteLine($" String += (O(N²)):    {sw.Elapsed.TotalMilliseconds} ms");
        }
    }
}
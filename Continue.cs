using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraekContinueCsharp
{
    internal class Continue
    {
        public static void Main(string[] args)
        {
            for (int A = 0; A < 11; A++)
            {
                if (A == 7)
                {
                    continue;
                }
                Console.WriteLine(A);
            }
        }
    }
}

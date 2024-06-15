using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraekContinueCsharp
{
    internal class WhileContinue
    {
        public static void Main(string[] args)
        {
            int A = 0;
            while (A < 21)
            {
                if (A == 10)
                {
                    A++;
                    continue;
                }
                Console.WriteLine(A);
                A++;
            }
        }
    }
}

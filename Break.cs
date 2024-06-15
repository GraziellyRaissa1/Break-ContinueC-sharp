using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraekContinueCsharp
{
    internal class Break
    {
        public static void Main(string[] args)
        {
            for (int A = 0; A < 11; A++)
            {
                if (A == 9)
                {
                    break;
                }
                Console.WriteLine(A);
            }
        }
    }
}

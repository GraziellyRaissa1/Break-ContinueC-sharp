using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraekContinueCsharp
{
    internal class WhileBreak
    {
        public static void Main(string[] args)
        {
            int A = 0;
            while (A < 10)
            {
                Console.WriteLine(A);
                A++;
                if (A == 3)
                {
                    break;
                }
            }
}   }   }

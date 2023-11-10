using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Method_Overriding
{
    internal class Cat:Animal
    {
        public override void speak()
        {
            Console.WriteLine("The cat goes miao...");
        }
    }
}

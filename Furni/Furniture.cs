using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatEX
{
    internal class Furniture : Product
    {
        public override void use()
        {
            Console.WriteLine("I am using " + Name);

        }

        public Furniture(string Name, int Price, string Description) : base(Name, Price, Description)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatEX
{
    internal class Food : Product
    {
        public override void use()
        {
            Console.WriteLine("I am Eating " + Name);

        }

        public Food(string Name, int Price, string Description) : base(Name, Price, Description)
        {

        }
    }
}

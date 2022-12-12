using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatEX
{
    internal class Drink : Product
    {
        public override void use() //metod
        {
            Console.WriteLine("I am drinking " + Name);

        }
        //konstruktor 
        public Drink(string Name, int Price, string Description):base(Name, Price, Description)
        {

        }

    }
}

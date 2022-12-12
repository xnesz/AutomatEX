using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatEX
{
    internal interface IProduct
    {
        //funktioner för buy descrip, use
        //interface = vad som kommer finnnas
        void Description();
        void use();
        void buy(SortedDictionary<Product, int> inventory);


    }


}

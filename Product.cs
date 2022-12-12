using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatEX
{
    internal abstract class Product : IProduct, IComparable
    {
        public string Name { get; }
        public int Price { get; }

        private string _description;
        public void Description() //hämtar data för olika produkter
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Description: " + _description);
        }
        public abstract void use();
        
        public void buy(SortedDictionary<Product, int> inventory) //lägger till item i inventory, finns den redan så ökar siffran med 1
        {
            if (inventory.ContainsKey(this))
            {
                inventory[this] += 1;
            }
            else
            {
                inventory.Add(this, 1);
            }
        }

        //konstruktor alltid samma namn som klassen
        public Product(string Name, int Price, string Description) //konstruktor för Namn, pris och beskrivning på produkt
        {
            this.Name = Name;
            this.Price = Price;
            this._description = Description;
        }

        public int CompareTo(object obj) //Måste kunna jämföra produkter för sortedDictionary, jämför baserat på namn. 
        {
            if (obj == null) return 1;

            Product product = obj as Product;
            if (product != null)
            {
                return this.Name.CompareTo(product.Name);
            }
            return -1;
        }
    }
}

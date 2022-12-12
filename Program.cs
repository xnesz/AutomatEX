using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatEX
{
    internal class Program
    {
        List<Product> Products = new List<Product>();
        SortedDictionary<Product,int> Inventory = new SortedDictionary<Product, int>();

        static public void Main(String[] args)
        {
            Program program = new Program();
            program.Run();
        }

        //Lista på vad som finns att köpa
        public Program()
        {
            Products.Add(new Cola());
            Products.Add(new Fanta());
            Products.Add(new Redbull());
            Products.Add(new Pizza());
            Products.Add(new Burger());
            Products.Add(new Spaghetti());
            Products.Add(new Table());
            Products.Add(new Sofa());
            Products.Add(new Rug());

        }

        //Kör programmet
        public void Run()
        {
            bool exit = false;

            while (!exit)
            {
                exit = menu();
            }
        }

        //Main meny,  saker du kan göra i programmet. mata in x nummer för z val.
        public bool menu()
        {
            Console.WriteLine("1. Browse all products.");
            Console.WriteLine("2. View inventory");
            Console.WriteLine("3. Exit");
            string inputChoice = Console.ReadLine();
            int input;
            
            try
            {
                input = int.Parse(inputChoice);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown value, try again.");
                return false;
            }

            switch (input)
            {
                case 1:
                    showProducts();
                    break;
                case 2:
                    showInventory();
                    break;
                case 3:
                    return true;

            }
            return false;
        }

        //Kod för att visa alla produkter som finns, även numrerade.
        public void showProducts()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine("Product " + (i + 1) + ":");
                Products[i].Description();
                Console.WriteLine("");
            }
            productMenu();
        }

        //En meny för alla produkter, där man kan välja att köpa en sak eller gå tillbaka. 
        //Error om input inte är samma som något av numren på listan. 
        public void productMenu()
        {
            Console.WriteLine("Choose which product you want to buy.");
            Console.WriteLine("Enter 0 to go back.");
            string inputChoice = Console.ReadLine();
            int input;

            try
            {
                input = int.Parse(inputChoice);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Unknown value, try again.");
                productMenu();
                return;
            }

           if (input == 0)
            {
                return;
            }

            Products[input - 1].buy(Inventory);
            Console.WriteLine("You have purchased 1 " + Products[input - 1].Name);
            Console.WriteLine("Returning to main menu...");

        }
        
        //Här visas inventory på det man har köpt, hur många saker man har av varje.
        public void showInventory()
        {

            Console.WriteLine("Inventory contains:");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine((i+1) + ": " + Inventory.ElementAt(i).Value+ " " + Inventory.ElementAt(i).Key.Name);
                
            }
            inventoryMenu();
        }

        //En meny för inventory där man kan välja en av produkterna att antingen dricka, äta eller använda.
        //Matar man in fel värde får man upp ett meddelande "unknown value"
        public void inventoryMenu()
        {
            Console.WriteLine("Choose a product to use");
            Console.WriteLine("Enter 0 to go back.");
            string inputChoice = Console.ReadLine();
            int input;

            try
            {
                input = int.Parse(inputChoice);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Unknown value, try again.");
                inventoryMenu();
                return;
            }

            if (input == 0)
            {
                return;
            }
            Inventory.ElementAt(input - 1).Key.use(); //hämta produkt du valt o användt
        }

    }
}

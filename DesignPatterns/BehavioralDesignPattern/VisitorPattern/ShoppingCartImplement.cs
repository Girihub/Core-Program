using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    public class ShoppingCartImplement : ShopingCartVisitor
    {        
        public int Visit(Book book)
        {
            int cost = 0;
            if (book.GetPrice() > 100)
            {
                cost = book.GetPrice() - 10;
            }
            else
            {
                cost = book.GetPrice();
            }
            Console.WriteLine("Book ISBN is: " + book.GetIsbnNumber() + " and cost is: " + cost);
            return cost;
        }

        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetWeight() * fruit.GetPricePerKg();
            Console.WriteLine("Fruit cost is " + cost);
            return cost;
        }

        public void ShoppingCartDisplay()
        {
            ItemElement[] itemElements = new ItemElement[] { new Book(150,"NHDS456"), new Book(45,"ISBNJG6"), new Fruit(20,2,"Orange"), new Fruit(130,4,"Apple") };
            int total = this.CalculateCost(itemElements);
            Console.WriteLine("Total cost: " + total);
        }

        private int CalculateCost(ItemElement[] itemElements)
        {
            ShopingCartVisitor visitor = new ShoppingCartImplement();
            int total = 0;
            foreach(ItemElement item in itemElements)
            {
                total += item.Accept(visitor);
            }
            return total;
        }
    }
}

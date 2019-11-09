//----------------------------------------------------
// <copyright file="ShoppingCartImplement.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ShoppingCartImplement implements ShopingCartVisitor interface
    /// </summary>
    public class ShoppingCartImplement : IShopingCartVisitor
    {        
        /// <summary>
        /// Function to display book information
        /// </summary>
        /// <param name="book">book as a parameter</param>
        /// <returns>returns cost</returns>
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

        /// <summary>
        /// Function to return cost of fruit
        /// </summary>
        /// <param name="fruit">fruit as a parameter</param>
        /// <returns>returns cost of fruit</returns>
        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetWeight() * fruit.GetPricePerKg();
            Console.WriteLine("Fruit cost is " + cost);
            return cost;
        }

        /// <summary>
        /// Function to display shopping cart
        /// </summary>
        public void ShoppingCartDisplay()
        {
            ItemElement[] itemElements = new ItemElement[] { new Book(150, "NHDS456"), new Book(45, "ISBNJG6"), new Fruit(20, 2, "Orange"), new Fruit(130, 4, "Apple") };
            int total = this.CalculateCost(itemElements);
            Console.WriteLine("Total cost: " + total);
        }

        /// <summary>
        /// Function to calculate items cost
        /// </summary>
        /// <param name="itemElements">items to calculate costs of</param>
        /// <returns>returns total cost</returns>
        private int CalculateCost(ItemElement[] itemElements)
        {
            IShopingCartVisitor visitor = new ShoppingCartImplement();
            int total = 0;
            foreach (ItemElement item in itemElements)
            {
                total += item.Accept(visitor);
            }

            return total;
        }
    }
}

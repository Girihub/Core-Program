//----------------------------------------------------
// <copyright file="Book.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    /// <summary>
    /// class book implements interface ItemElement
    /// </summary>
    public class Book : ItemElement
    {
        /// <summary>
        /// private field price
        /// </summary>
        private int price;

        /// <summary>
        /// private field isbnNumber
        /// </summary>
        private string isbnNumber;

        /// <summary>
        /// define constructor
        /// </summary>
        /// <param name="cost">cost as a parameter</param>
        /// <param name="isbn">isbn as a parameter</param>
        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        /// <summary>
        /// Function to get price of book
        /// </summary>
        /// <returns>returns price in integer value</returns>
        public int GetPrice()
        {
            return this.price;
        }

        /// <summary>
        /// Function to get isbn of book
        /// </summary>
        /// <returns>returns isbn code of book</returns>
        public string GetIsbnNumber()
        {
            return this.isbnNumber;
        }

        /// <summary>
        /// Function to add visitor
        /// </summary>
        /// <param name="visitor">visitor as a parameter</param>
        /// <returns>returns book</returns>
        public int Accept(IShopingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
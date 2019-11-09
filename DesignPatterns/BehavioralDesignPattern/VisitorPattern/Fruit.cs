//----------------------------------------------------
// <copyright file="Fruit.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    /// <summary>
    /// class Fruit implements interface ItemElement
    /// </summary>
    public class Fruit : ItemElement
    {
        /// <summary>
        /// private field pricePerKg
        /// </summary>
        private int pricePerKg;

        /// <summary>
        /// private field weight
        /// </summary>
        private int weight;

        /// <summary>
        /// private field name
        /// </summary>
        private string name;

        /// <summary>
        /// constructor for class
        /// </summary>
        /// <param name="pricePerKg">pricePerKg as a parameter</param>
        /// <param name="weight">weight as a parameter</param>
        /// <param name="name">name as a parameter</param>
        public Fruit(int pricePerKg, int weight, string name)
        {
            this.pricePerKg = pricePerKg;
            this.weight = weight;
            this.name = name;
        }

        /// <summary>
        /// Function to get price of fruit per kg
        /// </summary>
        /// <returns>returns price in integer</returns>
        public int GetPricePerKg()
        {
            return this.pricePerKg;
        }

        /// <summary>
        /// Function to get weight of fruit
        /// </summary>
        /// <returns>returns weight of fruit</returns>
        public int GetWeight()
        {
            return this.weight;
        }

        /// <summary>
        /// Function to return name of fruit
        /// </summary>
        /// <returns>returns fruit name</returns>
        public string GetName()
        {
            return this.name;
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
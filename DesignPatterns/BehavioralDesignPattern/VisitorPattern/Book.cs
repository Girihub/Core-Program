namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    public class Book:ItemElement
    {
        private int price;
        private string isbnNumber;

        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetIsbnNumber()
        {
            return this.isbnNumber;
        }

        public int Accept(ShopingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
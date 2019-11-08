namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    public class Fruit : ItemElement
    {
        private int pricePerKg;
        private int weight;
        private string name;

        public Fruit(int pricePerKg, int weight, string name)
        {
            this.pricePerKg = pricePerKg;
            this.weight = weight;
            this.name = name;
        }

        public int GetPricePerKg()
        {
            return this.pricePerKg;
        }

        public int GetWeight()
        {
            return this.weight;
        }

        public string GetName()
        {
            return this.name;
        }

        public int Accept(ShopingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
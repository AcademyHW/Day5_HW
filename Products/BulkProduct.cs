namespace Day5_HW.Products
{
    internal class BulkProduct : Product
    {
        public double Weight { get; private set; }
        public BulkProduct(string name, string description, double weight, double purchasePrice, double salePrice) : base(name, description, purchasePrice, salePrice)
        {
            Weight = weight;
            PurchasePrice = CalculatePrice(purchasePrice);
            SalePrice = CalculatePrice(salePrice);
        }
        public override double CalculatePrice(double price)
        {
            return price * Weight;
        }
    }
}

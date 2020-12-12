namespace Day5_HW.Products
{
    internal class PhysicalProduct : Product
    {
        public PhysicalProduct(string name, string description, double purchasePrice, double salePrice) : base(name, description, purchasePrice, salePrice) {}

        public override double CalculatePrice(double price)
        {
            return price;
        }
    }
}

namespace Day5_HW.Products
{
    internal class DigitProduct : Product
    {
        public DigitProduct(string name, string description, double purchasePrice, double salePrice) : base(name, description, purchasePrice, salePrice) 
        {
            PurchasePrice = CalculatePrice(purchasePrice);
            SalePrice = CalculatePrice(salePrice);
        }
        public override double CalculatePrice(double price)
        {
            return price / 2;
        }
    }
}

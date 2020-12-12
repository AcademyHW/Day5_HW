using System;

namespace Day5_HW.Products
{
    abstract class Product
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        abstract public double CalculatePrice(double price);
        public double CalculateProfit()
        {
            return SalePrice - PurchasePrice;
        }
        public Product(string name, string description, double purchasePrice, double salePrice)
        {
            Name = name;
            Description = description;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
        }
        public void GetInfo()
        {
            Console.WriteLine
                (
                $"Name = {Name};\nDescription = {Description};\nFinally Purchase Price = {PurchasePrice};\n" +
                $"Finally Sale Price = {SalePrice};\nProfit from the deal = {CalculateProfit()}\n"
                );
        }
    }
}

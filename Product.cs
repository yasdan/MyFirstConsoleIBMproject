using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class Product
    {
        //data members
        private string productName;
        private double productPrice;
        private int productQuantity;
        //constructor
        public Product()    //default constructor
        {
        }

        //parameterized constructor (overloaded constructor)
        public Product(string name, double price, int quantity)
        {
            productName = name;
            productPrice = price;
            productQuantity = quantity;
        }
        //properties

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public int ProductQuantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        //method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Product Price: {productPrice:C}");
            Console.WriteLine($"Product Quantity: {productQuantity}");
        }
        //method to calculate total price
        public double CalculateTotalPrice()
        {
            return productPrice * productQuantity;
        }

        //method to apply discount
        public double ApplyDiscount(double discountPercentage)
        {
            double discountAmount = (discountPercentage / 100) * productPrice;
            return productPrice - discountAmount;
        }
        //method to check stock availability
        public bool IsInStock()
        {
            return productQuantity > 0;
        }

        //method to restock product
        public void Restock(int additionalQuantity)
        {
            if (additionalQuantity > 0)
            {
                productQuantity += additionalQuantity;
                Console.WriteLine($"{additionalQuantity} units added to stock.");
            }
            else
            {
                Console.WriteLine("Invalid quantity for restocking.");
            }
        }
        //method to sell product
        public void Sell(int quantityToSell)
        {
            if (quantityToSell > 0 && quantityToSell <= productQuantity)
            {
                productQuantity -= quantityToSell;
                Console.WriteLine($"{quantityToSell} units sold.");
            }
            else if (quantityToSell > productQuantity)
            {
                Console.WriteLine("Insufficient stock to sell the requested quantity.");
            }
            else
            {
                Console.WriteLine("Invalid quantity for selling.");
            }
        }
        //method to update product price
        public void UpdatePrice(double newPrice)
        {
            if (newPrice >= 0)
            {
                productPrice = newPrice;
                Console.WriteLine($"Product price updated to {productPrice:C}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }

        }
    }       

}

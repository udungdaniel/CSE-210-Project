using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Product
    {
        private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal TotalCost()
    {
        return price * quantity;
    }

    public string GetName() => name;
    public string GetProductId() => productId;
    }
}
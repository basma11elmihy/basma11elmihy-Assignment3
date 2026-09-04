using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsAssignment
{
    internal class Order
    {
            public int OrderId;
            public string CustomerName;
            public int Quantity;
            public decimal UnitPrice;
            public decimal TotalPrice;
            public bool IsPaid;
            public double DiscountPercent;
            public string ShippingCity;
            public char Priority;
            public long ItemCode;

            // Method 1
            public void CalculateTotal()
            {
                TotalPrice = Quantity * UnitPrice * (decimal)(1 - DiscountPercent / 100);
            }

            // Method 2
            public void PrintSummary()
            {
                Console.WriteLine(
                    $"OrderId: {OrderId}, Customer: {CustomerName}, " +
                    $"TotalPrice: {TotalPrice}, IsPaid: {IsPaid}"
                );
            }

        
    }
}

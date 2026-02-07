using System;
using System.Collections.Generic;


public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public string Item { get; set; }
    public Stack<Order> AddOrderDetails(int orderId, string customerName, string item)
    {
        Order newo = new Order();
        newo.OrderId = orderId;
        newo.CustomerName = customerName;
        newo.Item = item;

        Ecom.OrderStack.Push(newo);
        return Ecom.OrderStack;
    }
    public string GetOrderDetails()
    {
        if (Ecom.OrderStack.Count > 0)
        {
            Order latestOrder = Ecom.OrderStack.Peek();
            return latestOrder.OrderId + " " + latestOrder.CustomerName + " " + latestOrder.Item;
        }
        return "";
    }
    public Stack<Order> RemoveOrderDetails()
    {
        if (Ecom.OrderStack.Count > 0)
        {
            Ecom.OrderStack.Pop();
        }
        return Ecom.OrderStack;
    }

//     public void GetAllOrders()
// {
//     if (Ecom.OrderStack.Count == 0)
//     {
//         Console.WriteLine("No orders available");
//         return;
//     }

//     Console.WriteLine("All Orders:");
//     foreach (Order o in Ecom.OrderStack)
//     {
//         Console.WriteLine(o.OrderId + " " + o.CustomerName + " " + o.Item);
//     }
// }

}

public class Ecom
{
    public static Stack<Order> OrderStack { get; set; } = new Stack<Order>();
    public static void ecom()
    {
        Order order = new Order();
        Console.WriteLine("OrderId:");
        int orderId = int.Parse(Console.ReadLine());

        Console.WriteLine("Customer Name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Item Name:");
        string item = Console.ReadLine();

        order.AddOrderDetails(orderId, customerName, item);
        Console.WriteLine("Most Recent Order:");
        Console.WriteLine(order.GetOrderDetails());

        order.RemoveOrderDetails();

        Console.WriteLine("Order processed successfully");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10257201_PRG2Assignment
{
    public static class AdvancedPartA
    {
        //method to call the AdvancedPartA
        public static void ProcessOrderCheckout(Dictionary<int, Customer> customerDict, Queue<Order> goldQueue, Queue<Order> regQueue)
        {
            Order orderTocheckout = new Order();
            if (goldQueue.Count > 0) //If there are orders in the Goldqueue
            {
                orderTocheckout = goldQueue.Dequeue();

            }
            else
            {
                orderTocheckout = regQueue.Dequeue();
            }
            //display order
            BasicReq2.DisplayDetails(orderTocheckout);
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
            Customer orderCustomer = RetrieveCustomer(orderTocheckout, customerDict);
            Console.WriteLine($"Membership Status: {orderCustomer.Rewards.Tier}");
            Console.WriteLine($"Points: {orderCustomer.Rewards.Points}");
        }
        public static Customer RetrieveCustomer(Order order, Dictionary<int, Customer> CustomerDict)
        {
            foreach (KeyValuePair<int, Customer> kvp in CustomerDict)
            {
                if (kvp.Value.CurrentOrder == order)
                {
                    return kvp.Value;
                }
            }
            return null;
        }
    }
}

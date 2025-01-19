using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//==========================================================
// Student Number : S10257201
// Student Name : Balakrishnan Rubanaasri
// Partner Name : Bryan Lim Aik Sian
//==========================================================

namespace S10257201_PRG2Assignment
{
    public class Customer
    {
        //properties
        public string Name { get; set; }
        public int Memberid { get; set; }
        public DateTime Dob {  get; set; }
        public Order CurrentOrder { get; set; }
        public List<Order> OrderHistory { get; set;} = new List<Order>();
        public PointCard Rewards { get; set; }

        //constructors
        public Customer () { }  
        public Customer(string name, int memberid, DateTime dob)
        {
            Name = name;
            Memberid = memberid;
            Dob = dob;
        }

        //methods
        public Order MakeOrder(List<int> orderIdList, DateTime timeReceived) 
        {
            int latestId = orderIdList.Last();
            Order order = new Order(latestId+1, timeReceived);
            return order;
        }

        public bool IsBirthday() 
        {
            return CurrentOrder.TimeReceived.ToString("M") == Dob.ToString("M");
        }

        public override string ToString()
        {
            return "Name: " + Name + "\t" + "Member ID: " + Memberid + "\t" + "Date of Birth: "  + Dob.ToString("dd/mm/yyyy") + 
                "\t" + "Current Order: \n" + CurrentOrder + "\n" + "Order History:\n" + string.Join('|', OrderHistory) + "\n" + "Rewards:\n" + Rewards;
        }

    }
}

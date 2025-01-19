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
    public class PointCard
    {
        //properties
        public int Points { get; set; }
        public int PunchCard {  get; set; }
        public string Tier { get; set; } = "Ordinary"; // added this in 
        
        //constructor
        public PointCard() { }
        public PointCard(int points, int punchCard)
        {
            Points = points;
            PunchCard = punchCard;
        }

        //methods
        public void AddPoints(int points)
        {
            Points += points;
        }

        public void RedeemPoints(int points)
        {
            Points -= points;
        }

        public void Punch() // RECHK!!!!
        {
            //PunchCard++;
            if (PunchCard == 11) // 11th icecream free & resets to 0
            {
                PunchCard = 0;
            }
            else if(PunchCard > 11) // if punchard goes above 11, deduct 11 & set punchcard accd
            {
                PunchCard = PunchCard - 11;
                if(PunchCard == 11)
                {
                    PunchCard = 0;
                }
                else
                {
                    PunchCard++;
                }              
            }
            else
            {
                PunchCard++; // punchcard less than 11, continue adding
            }
        }
        
        public override string ToString()
        {
            return "Points: " + Points + "\t" + "Punch Card: " + PunchCard + "\t" + "Tier: " + Tier;
        }

    }
}

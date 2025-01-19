using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10257201_PRG2Assignment
{
    //TO DELETE BEFORE SUBMISSION
    public static class ValidationFramework
    {
        public static void ValidationFrame()
        {
            while (true)
            {
                try
                {

                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please try again. ");
                    continue;
                }
                break;
            }
        }
    }
}

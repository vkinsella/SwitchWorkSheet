using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product Code    Cost
            //ASD 67.95
            //THF 68.90
            //TYG 34.95
            //GHT 88.90
            //YUR 23.80
            //UIT 9.90
            //HIT,UIP,RRT,JJk,IOP These are all 10

            string productCode;
            double productCost;
            int Qty;
            double totalCost;

            Console.Write("Enter the product code : ");
            productCode = Console.ReadLine();

            Console.Write("Enter the number of products you wish to buy : ");
            int qty = int.Parse(Console.ReadLine());


            switch (productCode.ToUpper())
            {
                case "ASH":
                    productCost = 67.95;
                    break;
                case "THF":
                    productCost = 68.90;
                    break;
                case "TYG":
                    productCost = 34.95;
                    break;
                case "GHT":
                    productCost = 88.90;
                    break;
                case "YUR":
                    productCost = 23.80;
                    break;
                case "UIT":
                    productCost = 9.90;
                    break;
                case "HIT":
                case "UIP":
                case "RRT":
                case "IOP":
                    productCost = 10.0;
                    break;
                default:
                    productCost = 0;
                    break;
           } // end switch

            if (productCost == 0)
                Console.WriteLine("Invalid code");
            else
            {
                totalCost = qty * productCost;
                Console.WriteLine("The total cost of order is {0:f2}", totalCost);
            }


        }
    }
}

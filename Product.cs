using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsTask
{
    internal class Product
    {
        string BrandName;
        double Price;
        string Model;
        double Cost;
        double Income;
        int Count;

        public Product(string brandName,  string model, double price, double cost, int count)
        {
            BrandName = brandName;
            Price = price;
            Model = model;
            Cost = cost;
           
            Income = 0;
            if (count < 0)
            {
                Count = 0;
            }
            else
            {
                Count=count;
            }
            

        }
        public void PrintInfo()
        {
            Console.WriteLine($"BrandName:{BrandName}, Price:{Price}, Model:{Model}, Cost:{Cost}, Income:{Income}, Count:{Count}");
        }
        public void Sale(int amount)
        {
            if (Count>=amount)
            {
                Count-=amount;
                double profit = (Price - Cost) * amount;
                Income += profit;
                Console.WriteLine($"Qazanc:{Income}, Geride qalan mehsul sayi:{Count}");
                
            }
        }
        public void Refill(int count)
        {
            Count += count;
            Console.WriteLine($"{count} mehsul elave olundu, Stokda {Count}");
        }
    }
}

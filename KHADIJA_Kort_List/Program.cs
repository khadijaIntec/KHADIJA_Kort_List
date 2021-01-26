using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KHADIJA_Kort_List.Interfaces;
using KHADIJA_Kort_List.Models;

namespace KHADIJA_Kort_List
{
    class Program
    {
        static void Main(string[] args)
        {

            IProduct Product1 = new Product()
            {
                Merk = "Cola",
                Naam = "Zero",
                Volume = "150 ml"
            };
            IProduct Product2 = new Product()
            {
                Merk = "Fanta",
                Naam = "Lemon",
                Volume = "1000 ml"
            };
            IProduct Product3 = new Product()
            {
                Merk = "Soda",
                Naam = "Gas",
                Volume = "150 ml"
            };
            List<IProduct> products = new List<IProduct>
            {
                Product1,
                Product2,
                Product3,
            };
            foreach (var item in products)
            {
                Console.WriteLine(item.GetCode());
                Console.ReadKey();
            }
        }
    }
}

using KHADIJA_Kort_List.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHADIJA_Kort_List.Models
{
   public class Product : IProduct
    {
        public string Merk { get; set; }
        public string Naam { get; set; }
        public string Volume { get; set; }

        public string GetCode()
        {
            return (Merk.Substring(0, 3) + Naam.Substring(0, 3) + Volume.Replace(' ', '_')).ToUpper();
        }
    }
}


    
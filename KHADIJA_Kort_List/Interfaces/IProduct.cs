using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHADIJA_Kort_List.Interfaces
{
   interface IProduct
    {
        string Merk { get; set; }
        string Naam { get; set; }
        string Volume { get; set; }
        string GetCode();
    }
}

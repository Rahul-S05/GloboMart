using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.Core.DomainModels
{
    public class Product : EntityBaseExtended
    {
        public double Price { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; }

    }
}

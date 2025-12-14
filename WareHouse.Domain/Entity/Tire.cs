using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public  class Tire
    {
        public int TireId { get; set; }
        public int CategoryId { get; set; }
        public int TireSizeId { get; set; }
        public int ModelId { get; set; }


        public Category category { get; set; }
        public TireSize TireSize { get; set; }  
        public Model Model { get; set; }


        public ICollection<Stock> Stocks { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public  class Stock
    {
        public int StockId { get; set; }
        public int Amount { get; set; }
        public string Dot { get; set; }
        public int TireId { get; set; }
        public int LocationId { get; set; }

        public Tire Tire { get; set; }
        public Location Location { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public class Location
    {
        public int LocationId { get; set; }
        public string  LocationName { get; set; }
        public int WareHouseId { get; set; }
        public WareHouse WareHouse { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}

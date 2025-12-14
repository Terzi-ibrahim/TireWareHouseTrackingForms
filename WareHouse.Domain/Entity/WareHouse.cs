using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public class WareHouse
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseAdress { get; set; }

        public ICollection<Location> locations { get; set; } 
        public ICollection<UserWareHouse> UserWareHouses { get; set; }
    }
}

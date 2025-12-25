using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Application.DTOs
{
    public  class LocationDTO
    {
        public int WareHouseId { get; set; }
        public int LocationId { get; set; }
        public string  LocationName { get; set; }
        public string  WareHouseName { get; set; }
    }
}

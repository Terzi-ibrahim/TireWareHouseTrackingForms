using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public  class UserWareHouse
    {
        public int UserId { get; set; }
        public int WareHouseId { get; set; }

        public Users Users { get; set; }
        public WareHouse WareHouse { get; set; }
    }
}

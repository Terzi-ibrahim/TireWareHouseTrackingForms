using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public  class TireSize
    {
        public int TireSizeId { get; set; }
        public string TireSizeName { get; set; }

        public ICollection<Tire> Tires { get; set; }
    }
}

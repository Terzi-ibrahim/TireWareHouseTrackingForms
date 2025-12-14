using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public  class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}

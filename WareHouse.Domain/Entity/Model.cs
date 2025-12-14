using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public class Model
    {
        public int ModelId { get; set; }
        public string  ModelName { get; set; }
        public int BrandId { get; set; }

        public Brand Brand { get; set; }
        public ICollection<Tire> Tires { get; set; }
    }
}

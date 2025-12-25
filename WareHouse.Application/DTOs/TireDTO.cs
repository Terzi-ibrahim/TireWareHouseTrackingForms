using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Application.DTOs
{
    public class TireDTO
    {
        public int SeasonId { get; set; }
        public string SeasonName { get; set; }
        public int TireId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string TireSizeName { get; set; }
        public int TireSizeId { get; set; }
        public string ModelName { get; set; }
        public int ModelId { get; set; }
        public int BrandId { get; set; }
        public string  BrandName { get; set; }  

        public string TireFullInfo => $"{TireSizeName}  - {BrandName}-{ModelName}-{CategoryName})";
    }
}

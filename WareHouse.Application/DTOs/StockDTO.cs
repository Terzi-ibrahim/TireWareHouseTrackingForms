namespace WareHouse.Application.DTOs
{
    public class StockDTO
    {
        public int StockId { get; set; }
        public string Dot { get; set; }
        public int Amount { get; set; }

       
        public int TireId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string TireSizeName { get; set; }
        public string SeasonName { get; set; }
        public string CategoryName { get; set; }

      
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string WarehouseName { get; set; }
        public int WareHouseId { get; set; }
    }
}

using WareHouse.Domain.Entity;
using WareHouse.Infrastructure.Reposityory;
namespace WareHouse.Application.Services
{
    public class StockService
    {
        private readonly StockRepository _stock = new StockRepository();

        public bool View(string tiresize)
        {
            if (string.IsNullOrEmpty(tiresize))
            {
                throw new Exception("Lütfen boş ebat yazmayın");
            }
            Stock stock = _stock.
            if(stock == null)
            {
                return false;
            }

            
        }
    }
}

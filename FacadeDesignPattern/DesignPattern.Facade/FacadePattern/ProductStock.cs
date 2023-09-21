using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context context = new Context();

        public void StockDecrease(int productId, int amount)
        {
            var value = context.Products.Find(productId);
            value.Stock -= amount;
            context.SaveChanges();
        }
    }
}

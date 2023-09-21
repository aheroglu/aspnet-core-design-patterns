using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void CompleteOrderDetail(int customerId, int productId, int orderId, int amount, decimal price)
        {
            orderDetail.OrderId = orderId;
            orderDetail.CustomerId = customerId;
            orderDetail.ProductId = productId;
            orderDetail.ProductCount = amount;
            orderDetail.Total = (amount * price);

            addOrderDetail.AddNewOrderDetail(orderDetail);
            productStock.StockDecrease(productId, amount);
        }

        public void CompleteOrder(int customerId)
        {
            order.CustomerId = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}

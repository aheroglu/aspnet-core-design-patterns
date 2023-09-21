using System.ComponentModel.DataAnnotations.Schema;

namespace DesignPattern.Facade.DAL
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}

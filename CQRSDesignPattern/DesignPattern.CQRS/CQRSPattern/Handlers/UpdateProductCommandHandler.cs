using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdatedProductCommand updatedProductCommand)
        {
            var values = _context.Products.Find(updatedProductCommand.Id);

            values.Name = updatedProductCommand.Name;
            values.Price = updatedProductCommand.Price;
            values.Description = updatedProductCommand.Description;
            values.Stock = updatedProductCommand.Stock;

            _context.SaveChanges();
        }
    }
}

using DesignPattern.Mediator.Data;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class UpdateProductByIdCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductByIdCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            values.Name = request.Name;
            values.Stock = request.Stock;
            values.Price = request.Price;
            values.StockType = request.StockType;
            values.Category = request.Category;
            await _context.SaveChangesAsync();
        }
    }
}

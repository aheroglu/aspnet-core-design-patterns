using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery getProductUpdateByIdQuery)
        {
            var values = _context.Products.Find(getProductUpdateByIdQuery.Id);

            return new GetProductUpdateQueryResult
            {
                Id = values.Id,
                Name = values.Name,
                Description = values.Description,
                Price = values.Price,
                Stock = values.Stock
            };
        }
    }
}

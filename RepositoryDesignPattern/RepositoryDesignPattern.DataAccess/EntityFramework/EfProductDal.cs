using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.DataAccess.Abstract;
using RepositoryDesignPattern.DataAccess.Concrete;
using RepositoryDesignPattern.DataAccess.Repository;
using RepositoryDesignPattern.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;

        public EfProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> ListWithCategory()
        {
            return _context.Products.Include(x => x.Category).ToList();
        }
    }
}

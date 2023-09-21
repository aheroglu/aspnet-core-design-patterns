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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}

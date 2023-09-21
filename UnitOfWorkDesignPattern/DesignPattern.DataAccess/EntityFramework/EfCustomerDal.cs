using DesignPattern.DataAccess.Abstract;
using DesignPattern.DataAccess.Concrete;
using DesignPattern.DataAccess.Repository;
using DesignPattern.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccess.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}

using DesignPattern.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Business.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
    }
}

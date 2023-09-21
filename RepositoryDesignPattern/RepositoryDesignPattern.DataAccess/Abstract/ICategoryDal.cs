using RepositoryDesignPattern.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccess.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
    }
}

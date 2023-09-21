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
    public class EfProcessDal : GenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(Context context) : base(context)
        {
        }
    }
}

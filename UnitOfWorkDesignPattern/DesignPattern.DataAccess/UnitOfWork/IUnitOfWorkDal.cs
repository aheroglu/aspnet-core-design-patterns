using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccess.UnitOfWork
{
    public interface IUnitOfWorkDal
    {
        void Save();
    }
}

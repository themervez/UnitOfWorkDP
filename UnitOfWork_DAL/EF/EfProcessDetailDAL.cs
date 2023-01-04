using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_DAL.Abstract;
using UnitOfWork_DAL.Concrete;
using UnitOfWork_DAL.Repository;
using UnitOfWork_EntityLayer.Concrete;

namespace UnitOfWork_DAL.EF
{
    public class EfProcessDetailDAL:GenericRepository<ProcessDetail>,IProcessDetailDAL
    {
        public EfProcessDetailDAL(Context context):base(context)
        {
        }
    }
}

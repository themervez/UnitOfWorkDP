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
    public class EfAccountDAL:GenericRepository<Account>, IAccountDAL
    {
        public EfAccountDAL(Context context):base(context)//Generic Repository class içinde constructor kullandığımız için bu class içinde de tanımlandı,Context için base olarak belirttik
        {
        }
    }
}

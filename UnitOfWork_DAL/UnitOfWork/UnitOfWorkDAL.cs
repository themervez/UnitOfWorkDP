using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_DAL.Concrete;

namespace UnitOfWork_DAL.UnitOfWork
{
    public class UnitOfWorkDAL : IUnitOfWorkDAL
    {
        private readonly Context _context;

        public UnitOfWorkDAL(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_BusinessLayer.Abstract;
using UnitOfWork_DAL.Abstract;
using UnitOfWork_DAL.UnitOfWork;
using UnitOfWork_EntityLayer.Concrete;

namespace UnitOfWork_BusinessLayer.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDAL _accountDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public AccountManager(IAccountDAL accountDAL, IUnitOfWorkDAL unitOfWorkDAL)
        {
            _accountDAL = accountDAL;
            _unitOfWorkDAL = unitOfWorkDAL;
        }

        public void TDelete(Account t)
        {
            _accountDAL.Delete(t);
            _unitOfWorkDAL.Save();
        }

        public Account TGetByID(int id)
        {
           return _accountDAL.GetByID(id);
        }

        public List<Account> TGetList()
        {
            return _accountDAL.GetList();
        }

        public void TInsert(Account t)
        {
            _accountDAL.Insert(t);  
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDAL.MultiUpdate(t);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDAL.Update(t);
            _unitOfWorkDAL.Save();
        }
    }
}

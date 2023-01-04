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
    public class ProcessDetailManager : IProcessDetailService
    {
        private readonly IProcessDetailDAL _processDetailDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public ProcessDetailManager(IProcessDetailDAL processDetailDAL, IUnitOfWorkDAL unitOfWorkDAL)
        {
            _processDetailDAL = processDetailDAL;
            _unitOfWorkDAL = unitOfWorkDAL;
        }

        public void TInsert(ProcessDetail t)
        {
            _processDetailDAL.Insert(t);    
        }

        public void TDelete(ProcessDetail t)
        {
            _processDetailDAL.Delete(t);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(ProcessDetail t)
        {
            _processDetailDAL.Update(t);
            _unitOfWorkDAL.Save();
        }

        public List<ProcessDetail> TGetList()
        {
            return _processDetailDAL.GetList();
        }

        public ProcessDetail TGetByID(int id)
        {
            return _processDetailDAL.GetByID(id);
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            _processDetailDAL.MultiUpdate(t);
            _unitOfWorkDAL.Save();
        }
    }
}

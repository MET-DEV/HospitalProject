using BusinessLayer.Abstract;
using BusinessLayer.ResultMessage;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DoctorManager:IDoctorService
    {
        private IDoctorDal _doctorDal;
        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public IResult Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
            return new SuccessResult(Messages.DataAdded);
        }

        public IResult Delete(Doctor doctor)
        {
            _doctorDal.Delete(doctor);
            return new SuccessResult(Messages.DataDeleted);
        }

        public IDataResult<List<Doctor>> GetAll()
        {
            return new SuccessDataResult<List<Doctor>>(_doctorDal.GetAll(),Messages.DataListed);
        }

        public IResult Update(Doctor doctor)
        {
            _doctorDal.Update(doctor);
            return new SuccessResult(Messages.DataUpdated);
        }
    }
}

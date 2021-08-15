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
    public class ClinicManager:IClinicService
    {
        private IClinicDal _clinicDal;

        public ClinicManager(IClinicDal clinicDal)
        {
            _clinicDal = clinicDal;
        }

        public IResult Add(Clinic clinic)
        {
            _clinicDal.Add(clinic);
            return new SuccessResult(Messages.DataAdded);
        }

        public IResult Delete(Clinic clinic)
        {
            _clinicDal.Delete(clinic);
            return new SuccessResult(Messages.DataDeleted);
        }

        public IDataResult<List<Clinic>> GetAll()
        {
            return new SuccessDataResult<List<Clinic>>(_clinicDal.GetAll(),Messages.DataListed);
        }

        public IResult Update(Clinic clinic)
        {
            _clinicDal.Update(clinic);
            return new SuccessResult(Messages.DataUpdated);
        }
    }
}

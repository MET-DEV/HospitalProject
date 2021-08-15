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
    public class PatientManager:IPatientService
    {
        private IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult(Messages.DataAdded);
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult(Messages.DataDeleted);
        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll(),Messages.DataListed);
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient) ;
            return new SuccessResult(Messages.DataUpdated);
        }
    }
}

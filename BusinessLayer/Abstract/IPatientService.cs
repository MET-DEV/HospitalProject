using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll();
        IResult Add(Patient patient);
        IResult Update(Patient patient);
        IResult Delete(Patient patient);
    }
}

using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDoctorService
    {
        IDataResult<List<Doctor>> GetAll();
        IResult Add(Doctor doctor);
        IResult Update(Doctor doctor);
        IResult Delete(Doctor doctor);
    }
}

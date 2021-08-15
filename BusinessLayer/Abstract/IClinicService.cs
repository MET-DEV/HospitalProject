using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IClinicService
    {
        IDataResult<List<Clinic>> GetAll();
        IResult Add(Clinic clinic);
        IResult Update(Clinic clinic);
        IResult Delete(Clinic clinic);
    }
}

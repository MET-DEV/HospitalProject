using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EfClinicDal:EfEntityRepositoryBase<Clinic,HospitalContext>,IClinicDal
    {
    }
}

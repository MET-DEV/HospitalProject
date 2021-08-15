using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private IClinicService _clinicService;

        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }
        [HttpGet("getall")]
        public IDataResult<List<Clinic>> GetAll()
        {
            return _clinicService.GetAll();
        }
        [HttpPost("add")]
        public IResult Add(Clinic clinic)
        {
            return _clinicService.Add(clinic);
        }
        [HttpPost("Delete")]
        public IResult Delete(Clinic clinic)
        {
            return _clinicService.Delete(clinic);

        }
        [HttpPost("update")]
        public IResult Update(Clinic clinic)
        {
            return _clinicService.Update(clinic);
        }
    }
}

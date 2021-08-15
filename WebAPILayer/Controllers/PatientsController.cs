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
    public class PatientsController : ControllerBase
    {
        private IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        [HttpGet("getall")]
        public IDataResult<List<Patient>> GetAll()
        {
            return _patientService.GetAll();

        }
        [HttpPost("add")]
        public IResult Add(Patient patient)
        {
            return _patientService.Add(patient);
        }
        [HttpPost("delete")]
        public IResult Delete(Patient patient)
        {
            return _patientService.Delete(patient);
        }
        [HttpPost("update")]
        public IResult Update(Patient patient)
        {
            return _patientService.Update(patient);
        }
    }
}

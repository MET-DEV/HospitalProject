using BusinessLayer.Concrete;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace TestLayer
{
    class Program
    {
        //test
        static void Main(string[] args)
        {
            ClinicManager cManager = new ClinicManager(new EfClinicDal());
            DoctorManager dManager = new DoctorManager(new EfDoctorDal());
            PatientManager pManager = new PatientManager(new EfPatientDal());
            var result1 = cManager.GetAll().Data;
            var result2 = dManager.GetAll().Data;
            var result3 = pManager.GetAll().Data;

            Doctor doctor = new Doctor() {FirstName="Mustafa Enes",LastName="Tepe",Email="met@met.com",ClinicId=2,NationalId="12345678910",Password="12345",PhoneNumber="13214141241" };
            var result=dManager.Add(doctor);
            Console.WriteLine(result.Message);

        }
    }
}

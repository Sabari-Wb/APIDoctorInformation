using APIDoctorInformation.Model;
using APIDoctorInformation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDoctorInformation.Provider
{
    public class DoctorProvider:IDoctorProvider
    {
        private readonly IDoctorRepo _doctorrepo;


        public DoctorProvider(IDoctorRepo doctorrepo)
        {

            _doctorrepo = doctorrepo;
        }
        public Doctor AddNewDoctor(Doctor p)
        {
            return _doctorrepo.AddNewDoctor(p);
        }

        public void DeleteDoctordetail(int id)
        {
            _doctorrepo.DeleteDoctordetail(id);
        }

        public bool DoctordetailExists(int id)
        {
            return _doctorrepo.DoctordetailExists(id);
        }

        public Doctor GetDoctorById(int id)
        {
            return _doctorrepo.GetDoctorById(id);
        }

        public List<Doctor> GetDoctorsdetails()
        {
            return _doctorrepo.GetDoctorsdetails();
        }

        public Doctor UpdateDoctordetail(int id, Doctor p)
        {
            return _doctorrepo.UpdateDoctordetail(id, p);
        }
    }
}

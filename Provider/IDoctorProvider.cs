using APIDoctorInformation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDoctorInformation.Provider
{
    public interface IDoctorProvider
    {
        public List<Doctor> GetDoctorsdetails();
        public Doctor GetDoctorById(int id);
        public Doctor AddNewDoctor(Doctor p);
        public void DeleteDoctordetail(int id);

        public Doctor UpdateDoctordetail(int id, Doctor p);
        public bool DoctordetailExists(int id);
    }
}

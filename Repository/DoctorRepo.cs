using APIDoctorInformation.Data;
using APIDoctorInformation.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDoctorInformation.Repository
{
    public class DoctorRepo:IDoctorRepo
    {
        private readonly DoctorInfoContext _doctorinfocontext;
        public DoctorRepo(DoctorInfoContext doctorinfocontext)
        {
            _doctorinfocontext = doctorinfocontext;
        }
        public Doctor AddNewDoctor(Doctor p)
        {
            _doctorinfocontext.Doctors.Add(p);
            _doctorinfocontext.SaveChanges();
            return p;
        }

        public void DeleteDoctordetail(int id)
        {
            Doctor p = _doctorinfocontext.Doctors.Find(id);
            _doctorinfocontext.Doctors.Remove(p);
            _doctorinfocontext.SaveChanges();
        }

        public bool DoctordetailExists(int id)
        {
            return _doctorinfocontext.Doctors.Any(e => e.DoctorID == id);
        }


        public Doctor GetDoctorById(int id)
        {
            return _doctorinfocontext.Doctors.Find(id);

        }

        public List<Doctor> GetDoctorsdetails()
        {
           
            return _doctorinfocontext.Doctors.ToList();
        }

        public Doctor UpdateDoctordetail(int id, Doctor p)
        {
            _doctorinfocontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _doctorinfocontext.Entry(p).State = EntityState.Modified;
            _doctorinfocontext.SaveChanges();
            return p;
        }

    }
}

using APIDoctorInformation.Model;
using APIDoctorInformation.Provider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDoctorInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorProvider _doctorprovider;

        public DoctorsController(IDoctorProvider doctorprovider)
        {
            _doctorprovider = doctorprovider;
        }

        // GET: api/Doctors
        [HttpGet("Doctorsdetail")]
        public ActionResult<List<Doctor>> GetDoctordetails()
        {
            return _doctorprovider.GetDoctorsdetails();
        }
        //public IActionResult GetDoctorsDetails()                              // for unit test
        //{
        //    return Ok(_doctorprovider.GetDoctorsdetails());
        //}

        // GET: api/Doctors/5
        [HttpGet("{id}")]
        public ActionResult<Doctor> GetDoctordetailbyID(int id)
        {
            return _doctorprovider.GetDoctorById(id);


        }
        //public IActionResult GetDoctorDetailsbyID(int id)                          // for unit test
        //{
        //    return Ok(_doctorprovider.GetDoctorById(id));
        //}

        // PUT: api/Doctors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutDoctor(int id, Doctor p)
        {


            try
            {
                _doctorprovider.UpdateDoctordetail(id, p);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_doctorprovider.DoctordetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Doctors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Doctor> PostDoctor(Doctor p)
        {
            _doctorprovider.AddNewDoctor(p);

            return CreatedAtAction("GetDoctordetails", new { id = p.DoctorID }, p);
        }
        //public IActionResult PostDoctor(Doctor p)                        //unittest
        //{
        //    _doctorprovider.AddNewDoctor(p);

        //    return CreatedAtAction("GetDoctordetails", new { id = p.DoctorID }, p);
        //}

        // DELETE: api/Doctors/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            _doctorprovider.DeleteDoctordetail(id);
            return NoContent();
        }

    }
}

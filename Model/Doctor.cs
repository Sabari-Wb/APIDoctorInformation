using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIDoctorInformation.Model
{
    public class Doctor
    {

        [Key]
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Specialization { get; set; }
        [DataType(DataType.Time)]
        public DateTime VisitingHoursFROM { get; set; }
        [DataType(DataType.Time)]
        public DateTime VisitingHoursTO { get; set; }

        public Doctor()
        {

        }

        public Doctor(int id, string firstname, string lastname, string sex, string specification, DateTime visitinghoursfrom,DateTime visitinghoursto)
        {
            DoctorID = id;
            FirstName = firstname;
            LastName = lastname;
            Sex = sex;
            Specialization = specification;
            VisitingHoursFROM = visitinghoursfrom;
            VisitingHoursTO = visitinghoursto;



        }

    }
}

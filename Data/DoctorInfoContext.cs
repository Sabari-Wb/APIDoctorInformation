using APIDoctorInformation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDoctorInformation.Data
{
    public class DoctorInfoContext:DbContext
    {
        public DoctorInfoContext(DbContextOptions<DoctorInfoContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer(connectionString);
        }


        public DbSet<Doctor> Doctors { get; set; }
    }
}

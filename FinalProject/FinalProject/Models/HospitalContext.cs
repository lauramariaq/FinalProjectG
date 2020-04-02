using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class HospitalContext:DbContext
    {
        public HospitalContext()
            :base("cadena")
        { }

        public DbSet<patient> Patients { get; set; }
        public DbSet<doctor> Doctors { get; set; }
        public DbSet<room> Rooms { get; set; }



    }
}
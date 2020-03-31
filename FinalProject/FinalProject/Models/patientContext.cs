using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class patientContext:DbContext
    {
        public patientContext()
            :base("cadena")
        { }

       public DbSet<patient> Patients { get; set; }
    }
}
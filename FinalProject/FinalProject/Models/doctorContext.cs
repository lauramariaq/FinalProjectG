using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class doctorContext:DbContext
    {

        public doctorContext()
            :base("cadena")
        { }

        public DbSet<doctorContext> doctors { get; set; }
    }
}
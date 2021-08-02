using SistemaWebAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaWebAlumnos.Data
{
    public class AlumnoDbContext: DbContext
    {
        public AlumnoDbContext(): base("KeyDB") {}

        public DbSet<Alumno> Alumnos { get; set; }


    }
}
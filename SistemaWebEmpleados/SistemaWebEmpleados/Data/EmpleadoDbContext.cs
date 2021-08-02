using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SistemaWebEmpleados.Models;

namespace SistemaWebEmpleados.Data
{
    public class EmpleadoDbContext:DbContext
    {
        public EmpleadoDbContext() : base("KeyDB") { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
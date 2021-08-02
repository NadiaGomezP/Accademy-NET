using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebEmpleados.Models
{
    [Table ("Empleados")]
    public class Empleado
    {
        public int ID { get; set; }
        
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
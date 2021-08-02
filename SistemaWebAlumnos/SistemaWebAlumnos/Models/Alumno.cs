using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebAlumnos.Models
{
    public class Alumno
    {
        #region Constructores
        public Alumno() { }

        public Alumno(string nombre, string apellido, string DNI, string Email)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.DNI = DNI;
            this.Email = Email;
        }

        #endregion

        [Required]
        public int AlumnoID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}
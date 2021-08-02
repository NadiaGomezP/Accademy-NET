using SistemaWebVuelos.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Models
{
    [Table("Vuelo")]
    public class Vuelo
    {
        #region Constructor
        public Vuelo() { }

        public Vuelo(DateTime fecha, string destino, string origen, string matricula)
        {
            Fecha = fecha;
            Destino = destino;
            Origen = origen;
            Matricula = matricula;
        }

        #endregion
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        [Column(TypeName ="Date")]
        [CheckValidYear]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Destino { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Origen { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Matricula { get; set; }
    }
}
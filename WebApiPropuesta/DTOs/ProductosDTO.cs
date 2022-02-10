using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data.SqlClient;

namespace WebApiPropuesta.DTOs
{
    public class ProductosDTO
    {
        [Key]
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Codigo")]
        public int Codigo { get; set; }


        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Descripción")]
        public string Descripción { get; set; }


        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha fabricación")]
        public DateTime Fecha_fabricación { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha validez")]
        public DateTime Fecha_validez { get; set; }

        [Display(Name = "Cod proveedor")]
        public int Cod_proveedor { get; set; }

        [Display(Name = "Descripción proveedor")]
        public string Descripción_proveedor { get; set; }

        [Display(Name = "Telefono Proveedor")]
        public string TelefonoProveedor { get; set; }
    }
}

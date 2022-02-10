using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiPropuesta.DTOs
{
    public class ProductoAddDTO
    {
        [Key]
        [Required(ErrorMessage = "{0} es requerido")]
        public int Codigo { get; set; }


        [Required(ErrorMessage = "{0} es requerido")]
        public string Descripción { get; set; }


        [Required(ErrorMessage = "{0} es requerido")]
        public bool Estado { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_fabricación { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_validez { get; set; }
        public int Cod_proveedor { get; set; }
        public string Descripción_proveedor { get; set; }
        public string TelefonoProveedor { get; set; }
    }
}

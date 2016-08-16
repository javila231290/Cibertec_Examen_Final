using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model
{
    public partial class Libros
    {

        [Key]
        [Required]
        public int libro_id { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(15)]
        [Display(Name = "Apellido Autor")]
        public string libro_Nombre { get; set; }
        public string libro_Typo { get; set; }
        [Required]
        [Column(TypeName = "money")]
        [Display(Name = "Precio Libro")]
        public float libro_price { get; set; }

    }
}

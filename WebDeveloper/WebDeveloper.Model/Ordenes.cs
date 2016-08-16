using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model
{
    public partial class Ordenes
    {
        [Key]
        [Required]
        public int au_orden { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(15)]
        [Display(Name = "Seleccionar Autor")]
        public int? au_id { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(15)]
        [Display(Name = "Seleccionar Libro")]
        public int? libro_id { get; set; }
        public string tipo_papel { get; set; }

        public virtual Autores Autores { get; set; }

        public virtual Libros Libros { get; set; }
    }
}

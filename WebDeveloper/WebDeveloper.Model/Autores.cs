using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model
{
    public partial class Autores
    {

        [Key]
        [Required]
        public int au_id { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(15)]
        [Display(Name = "Apellido Autor")]
        public string au_apellido { get; set; }
        [Required(ErrorMessage = "Este dato es requerido.")]
        [StringLength(15)]
        [Display(Name = "Nombre Autor")]
        public string au_nombre { get; set; }
        public string au_telefono { get; set; }
        public string au_ciudad { get; set; }
        [Required]
        [Column(TypeName = "money")]
        [Display(Name = "Salario Autor")]
        public float au_salario { get; set; }
    }
}

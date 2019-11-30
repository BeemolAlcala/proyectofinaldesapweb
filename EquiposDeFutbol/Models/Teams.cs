using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EquiposDeFutbol.Models {

    public class Teams {
        [Key]
        [Display(Name="ID")]
        public int TeamID { get; set;}
        [Display(Name="Name",Prompt="Nombre equipo")]
        [Required(ErrorMessage="El nombre del equipo es obligatorio")]
        [StringLength(80)]
        public string TeamName { get; set;}

        public ICollection<Players> Players { get; set;}

    }
}
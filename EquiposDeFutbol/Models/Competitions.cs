using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EquiposDeFutbol.Models {

    public class Competitions {
        [Key]
        [Display(Name="ID")]
        public int CompetitionID { get; set;}
        [Display(Name="Name",Prompt="Nombre competicion")]
        [Required(ErrorMessage="El nombre de la competicion obligatorio")]
        [StringLength(80)]
        public string CompetitionName { get; set;}

        public ICollection<Fixtures> Fixtures { get; set;}

    }
}
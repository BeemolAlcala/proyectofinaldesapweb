using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EquiposDeFutbol.Models {

    public class PlayerPositions {
        [Key]
        [Display(Name="ID")]
        public int PositionID { get; set;}
        public string PositionDescription { get; set;}

        public ICollection<Players> Players { get; set;}

    }
}
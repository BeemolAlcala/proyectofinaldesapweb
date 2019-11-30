using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EquiposDeFutbol.Models {

    public class Players {
        [Key]
        [Display(Name="ID")]
        public int PlayerID { get; set;}
        public int TeamID { get; set;}
        public string PlayerName { get; set;}
        public int PlayerSquadNumber { get; set;}
        public int PositionID { get; set;}

        public  Teams Team {get; set;}
        public PlayerPositions PlayerPosition {get;set;}
        public ICollection<PlayerFixtures> PlayerFixtures { get; set;}

    }
}
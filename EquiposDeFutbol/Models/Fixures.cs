using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace EquiposDeFutbol.Models {

    public class Fixtures {
        [Key]
        [Display(Name="ID")]
        public int FixtureID { get; set;}
        [Display(Name="Name",Prompt="fecha partido")]
        [Required(ErrorMessage="la fecha es obligatoria")]
        public DateTime FixtureDate  { get; set;}
        
        public DateTime FixtureTime { get; set;}
        public int HomeTeamID { get; set;}
        public int AwayTeamID { get; set;}
        public int CompetitionID { get; set;}

        public  Competitions Competition {get; set;}
        public ICollection<PlayerFixtures> PlayerFixtures { get; set;}

    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EquiposDeFutbol.Models {

    public class PlayerFixtures {
 
        public int FixtureID { get; set;}
        public int PlayerID { get; set;}
        
        public int GoalsScoredID { get; set;}

        public  Players Player {get; set;}
        public Fixtures Fixture {get;set;}

    }
}
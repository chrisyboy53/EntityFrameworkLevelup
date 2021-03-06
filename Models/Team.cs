using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLevelup.Models {

    public class Team {

        [Key]
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public IList<TeamAllocation> TeamAllocation {get;set;}
    }
    
}
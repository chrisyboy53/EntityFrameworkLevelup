using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLevelup.Models {
    public class TeamAllocation {

        [Key()]
        public int TeamAllocationId { get; set; }
        
        public Team Team { get; set; }
                
        public Person Person {get; set;}

    }
}
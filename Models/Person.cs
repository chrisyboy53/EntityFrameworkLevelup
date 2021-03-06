using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLevelup.Models {
    public class Person {

        [Key()]
        public int PersonId { get; set; }
        
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public int Age { get; set; }

        public IList<TeamAllocation> TeamAllocation {get; set;}

    }
}
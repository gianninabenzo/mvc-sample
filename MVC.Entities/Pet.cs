using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Entities
{
    public class Pet

    {
           [Key]
            public int PetID { get; set; }

            public string PetName { get; set; }

            public string Breed { get; set; }

            public string Colour { get; set; }

            public int? PersonID { get; set; }

            public virtual Person Owner { get; set; }

        
    }
}

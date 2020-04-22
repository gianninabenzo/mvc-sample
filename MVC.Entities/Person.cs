using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Entities
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }


        public virtual ICollection<Pet> Pets { get; set; }
    }
}
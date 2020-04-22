using DataAnnotationsExtensions;
using MVC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web;

namespace MVC_Sample.Models
{
    public class PeopleViewModel
    {

        public List<PersonViewModel> Persons { get; set; }

        public PeopleViewModel(List<Person> people)
        {
            Persons = new List<PersonViewModel>();

            StringBuilder petName = new StringBuilder(); 

            foreach (var item in people)
            {
                PersonViewModel person = new PersonViewModel() {

                    PersonID = item.PersonID,
                    LastName = item.LastName,
                    Name = item.Name,
                    Phone = item.Phone,
                    Email = item.Email,
                    PetName = item.Pets.Select(x => x.PetName).ToString()

                    
                 
                };


                Persons.Add(person);
            }
        }

    }

    public class PersonViewModel
    { 
        [Key]
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(8)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Sólo puede ingresar números")]
        public string Phone { get; set; }

        [Email]
        public string Email { get; set; }

        public string PetName { get; set; }
    }
}
using MVC.DataAccess;
using MVC.Entities;
using System.Collections.Generic;

namespace MVC.BusinessLogic
{
    public static class PersonsBL
    {
        public static List<Person> GetPersons()
        {
            return SQLDataAccess.GetPersons();
        }
        public static void Create(Person person)
        {
            SQLDataAccess.Create(person);
        }
        public static void Edit(Person person)
        {
            SQLDataAccess.Edit(person);
        }
        public static void Delete(int id)
        {
            SQLDataAccess.Delete(id);
        }
    }
}


//tengo que hacer los 4 metodos getppl, addpers,deleteps y edit
//pero primeor preciso hacer la referencia de bl a dal (no me deja ahora)
//borrar todo lo de arriba sin que se rompa
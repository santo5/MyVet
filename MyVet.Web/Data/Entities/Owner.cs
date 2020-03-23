using System.Collections.Generic;

namespace MyVet.Web.Data.Entities
{
    //Clase de propietario para la tabla de la base de datos
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}

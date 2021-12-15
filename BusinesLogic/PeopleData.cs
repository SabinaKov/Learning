using BusinesLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class PeopleData
    {
        private List<PersonModel> _people;

        public PeopleData()
        {
           _people = new List<PersonModel>()
            {
                new PersonModel()
                {
                    FirstName = "Sabina", LastName = "Kovarikova", Age = 25, IsAlive = true
                },
                new PersonModel()
                {
                    FirstName = "Miroslav", LastName = "Vaculka", Age = 30, IsAlive = true
                }
            };
        }
        public List<PersonModel> GetPeople()
        {
            PersonModel libor = new PersonModel()
            {
                LastName = "KnowHow"
            };
            PeopleManipulator.Rename(libor);
            _people.Add(libor);
            return _people;

        }
    }
}

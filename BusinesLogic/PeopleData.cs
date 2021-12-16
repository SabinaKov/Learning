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

            DeepAndShallowCopyDifference();

        }

        private void DeepAndShallowCopyDifference()
        {
            // Shallow Copy:
            List<PersonModel> shallowCopyOfPeople;
            shallowCopyOfPeople = _people;

            // Deep Copy:
            List<PersonModel> deepCopyOfPeople = new List<PersonModel>();
            foreach (PersonModel person in _people)
            {
                deepCopyOfPeople.Add(person);
            }

            // Modification of shallow copy:
            shallowCopyOfPeople.Add(
                new PersonModel()
                {
                    FirstName = "David",
                    LastName = "Macháček"
                });

            // Modification of deep copy:
            deepCopyOfPeople.Add(
                new PersonModel()
                {
                    FirstName = "Jakub",
                    LastName = "Klement"
                });


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

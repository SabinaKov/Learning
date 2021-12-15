using BusinesLogic.Models;

namespace BusinesLogic
{
    public static class PeopleManipulator
    {
        public static void Rename(PersonModel personToRename)
        {
            personToRename.LastName = "Nohál";
        }
    }
}

using ZooManagement.Models.Database;

namespace ZooManagement.Models.Response
{
    public class AnimalResponseModel
    {
        private readonly AnimalModel _animal;

        public AnimalResponseModel(AnimalModel animal)
        {
            _animal = animal;
        }

        public int Id =>_animal.Id;
        public int SpeciesId =>_animal.SpeciesId;
        public string Name =>_animal.Name;
        public string Sex =>_animal.Sex;
        public Nullable<DateTime> DateOfBirth =>_animal.DateOfBirth;
        public Nullable<DateTime> DateOfAcquirement =>_animal.DateOfAcquirement;
    }
}
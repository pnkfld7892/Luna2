using Luna2.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luna2.Models
{
    public class AllAnimalViewModel
    {
        public AllAnimalViewModel(List<AnimalModel> animals,List<PersonModel> persons)
        {
            Animals = animals;
            Persons = persons;
        }
        public List<AnimalModel> Animals { get; }
        public List<PersonModel> Persons {get;}
    }
}

using Luna2.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna2.Models
{
    public class AnimalDetailViewModel
    {
        public AnimalDetailViewModel(AnimalModel animal, PersonModel person)
        {
            Animal = animal;
            Person = person;
        }
        public AnimalModel Animal { get; }
        public PersonModel Person { get; }
    }
}

using Luna2.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luna2.Models
{
    public class AnimalViewModel
    {
        public AnimalViewModel(List<AnimalModel> animals)
        {
            Animals = animals;
        }
        public List<AnimalModel> Animals { get; }
    }
}

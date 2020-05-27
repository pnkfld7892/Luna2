using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna2.DataAccess.Models
{
    public class AnimalModel
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        //TODO: possibly move out of the DA and into the front end?
        [DisplayName("Animal Name")]
        public string AnimalName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
    }
}

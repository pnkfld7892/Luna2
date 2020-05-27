using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Luna2.DataAccess.DataAccess;
using Luna2.DataAccess.Models;
using Luna2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Luna2.Controllers
{
    public class AnimalController : Controller
    {
        private AnimalData animalData;
        private PersonData personData;
        public AnimalController()
        {
            animalData = new AnimalData();
            personData = new PersonData();
        }
        public IActionResult Index()
        {

            return View(new AllAnimalViewModel(animalData.GetAllAnimals(),personData.GetAllPersons()));
        }

        public IActionResult AnimalDetail(int id)
        {
            return View(new AnimalDetailViewModel(animalData.GetAnimalById(id),GetAllPersons().FirstOrDefault()));
        }

        //Possibly open up later via API call
       


        private List<PersonModel> GetAllPersons()
        {
            PersonData data = new PersonData();

            return data.GetAllPersons();
        }
    }
}
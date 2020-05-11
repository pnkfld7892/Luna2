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
        public IActionResult Index()
        {

            return View(new AnimalViewModel(GetAllAnimals()));
        }

        //Possibly open up later via API call
        public List<AnimalModel> GetAllAnimals()
        {
            AnimalData data = new AnimalData();
            return data.GetAllAnimals();
        }
    }
}
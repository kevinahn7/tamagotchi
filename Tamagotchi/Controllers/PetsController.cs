using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tamagotchi.Controllers
{
    public class PetsController : Controller
    {
        // GET: /<controller>/

        [HttpGet("/pets")]
        public ActionResult Pets()
        {
            List<Pet> listOfPets = Pet.GetAllPets();
            return View(listOfPets);
        }

        [HttpPost("/pets")]
        public ActionResult Create()
        {
            Pet newPet = new Pet(Request.Form["pet-name"]);
            return RedirectToAction("Pets");
        }

        [HttpPost("/pets/feed/{id}")]
        public ActionResult Feed(int id)
        {
            Pet currentPet = Pet.FindPet(id);
            currentPet.UpdateHunger();
            return RedirectToAction("Pets");
        }

        [HttpPost("/pets/attention/{id}")]
        public ActionResult Attention(int id)
        {
            Pet currentPet = Pet.FindPet(id);
            currentPet.UpdateAttention();
            return RedirectToAction("Pets");
        }

        [HttpPost("/pets/rest/{id}")]
        public ActionResult Rest(int id)
        {
            Pet currentPet = Pet.FindPet(id);
            currentPet.UpdateRest();
            return RedirectToAction("Pets");
        }

        [HttpPost("/pets/clear")]
        public ActionResult Clear()
        {
            Pet.ClearAll();

            return RedirectToAction("Pets");
        }
    }
}

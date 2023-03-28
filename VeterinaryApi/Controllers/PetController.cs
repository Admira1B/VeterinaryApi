using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetController
    {
        [HttpGet]
        public ActionResult<List<Pet>> GetPets()
        {
        }

        [HttpGet("{id}")]
        public ActionResult<Pet> GetPet(int id)
        {
        }

        [HttpPost]
        public ActionResult AddNewPet(Pet pet)
        {
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePet(int id)
        {
        }

        [HttpPut("{id}")]
        public ActionResult<Pet> UpdatePet(Pet pet)
        {
        }
    }
}
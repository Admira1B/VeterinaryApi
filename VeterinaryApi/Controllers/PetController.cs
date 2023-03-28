using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetController
    {
        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetPets()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetPet(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddNewPet(Pet pet)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePet(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Pet>> UpdatePet(Pet pet)
        {
        }
    }
}
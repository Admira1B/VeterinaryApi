using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.PetDto;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetController
    {
        [HttpGet]
        public async Task<ActionResult<List<GetPetDto>>> GetPets()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetPetDto>> GetPet(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GetPetDto>> AddNewPet(AddPetDto petDto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePet(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetPetDto>> UpdatePet(UpdatePetDto petDto)
        {
        }
    }
}
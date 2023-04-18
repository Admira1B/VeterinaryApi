using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.PetDto;
using VeterinaryApi.Services.PetService;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        private readonly IPetService _service;
        public PetController(IPetService petService) { _service = petService; }

        [HttpGet]
        public async Task<ActionResult<List<GetPetDto>>> GetPets()
        {
            return Ok(await _service.GetPets());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetPetDto>> GetPet(int id)
        {
            var pet = await _service.GetPet(id);
            if (pet is null)
                return NotFound();

            return Ok(pet);
        }

        [HttpPost]
        public async Task<ActionResult<GetPetDto>> AddNewPet(AddPetDto petDto)
        {
            var newPet = await _service.AddNewPet(petDto);
            return Ok(newPet);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePet(int id)
        {
            var pet = await _service.GetPet(id);

            if (pet is null)
                return NotFound();

            await _service.DeletePet(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetPetDto>> UpdatePet(int id ,UpdatePetDto petDto)
        {
            var pet = await _service.GetPet(id);

            if(pet is null)
                return NotFound();

            await _service.UpdatePet(id, petDto);

            return Ok(await _service.GetPet(id));
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.PetOwnerDtos;
using VeterinaryApi.Services.PetOwnerService;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetOwnerController : ControllerBase
    {
        private readonly IPetOwnerService _service;
        public PetOwnerController(IPetOwnerService service) { _service = service; }

        [HttpGet]
        public async Task<ActionResult<List<GetPetOwnerDto>>> GetPetOwners()
        {
            return Ok(await _service.GetOwners());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetPetOwnerDto>> GetPetOwner(int id)
        {
            var petOwner = await _service.GetOwner(id);

            if (petOwner is null)
                return NotFound();

            return Ok(petOwner);
        }

        [HttpPost]
        public async Task<ActionResult<GetPetOwnerDto>> AddNewPetOwner(AddPetOwnerDto petOwnerDto)
        {
            var newPetOwner = await _service.AddNewPetOwner(petOwnerDto);
            return Ok(newPetOwner);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePetOwner(int id)
        {
            var petOwner = _service.GetOwner(id);

            if (petOwner is null)
                return NotFound();

            await _service.DeleteOwner(id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetPetOwnerDto>> UpdatePetOwner(int id, UpdatePetOwnerDto petOwnerDto)
        {
            var petOwner = _service.GetOwner(id);

            if (petOwner is null)
                return NotFound();

            await _service.UpdateOwner(id, petOwnerDto);

            return Ok(await _service.GetOwner(id));
        }
    }
}
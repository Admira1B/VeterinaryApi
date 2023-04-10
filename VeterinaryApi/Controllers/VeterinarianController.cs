using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.VeterinarianDtos;
using VeterinaryApi.Services.VeterinarianService;

namespace VeterinaryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeterinarianOwnerController : ControllerBase
    {
        private readonly IVeterinarianService _service;
        public VeterinarianOwnerController(IVeterinarianService service) { _service = service; }

        [HttpGet]
        public async Task<ActionResult<List<GetVeterinarianDto>>> GetTypesOfAnimals()
        {
            return Ok(await _service.GetVeterinarians());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetVeterinarianDto>> GetVeterinarian(int id)
        {
            var veterinarian = await _service.GetVeterinarian(id);

            if (veterinarian is null)
                return NotFound();

            return Ok(veterinarian);
        }

        [HttpPost]
        public async Task<ActionResult<GetVeterinarianDto>> AddNewVeterinarian(AddVeterinarianDto veterinarianDto)
        {
            var newVeterinarian = await _service.AddNewVeterinarian(veterinarianDto);
            return Ok(newVeterinarian);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVeterinarian(int id)
        {
            var veterinarian = _service.GetVeterinarian(id);

            if (veterinarian is null)
                return NotFound();

            await _service.DeleteVeterinarian(id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetVeterinarianDto>> UpdateVeterinarian(int id, UpdateVeterinarianDto veterinarianDto)
        {
            var veterinarian = _service.GetVeterinarian(id);

            if (veterinarian is null)
                return NotFound();

            await _service.UpdateVeterinarian(id, veterinarianDto);

            return Ok(await _service.GetVeterinarian(id));
        }
    }
}
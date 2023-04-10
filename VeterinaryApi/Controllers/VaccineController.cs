using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.VaccineDtos;
using VeterinaryApi.Services.VaccineService;

namespace VeterinaryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VaccineOwnerController : ControllerBase
    {
        private readonly IVaccineService _service;
        public VaccineOwnerController(IVaccineService service) { _service = service; }

        [HttpGet]
        public async Task<ActionResult<List<GetVaccineDto>>> GetTypesOfAnimals()
        {
            return Ok(await _service.GetVaccines());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetVaccineDto>> GetVaccine(int id)
        {
            var vaccine = await _service.GetVaccine(id);

            if (vaccine is null)
                return NotFound();

            return Ok(vaccine);
        }

        [HttpPost]
        public async Task<ActionResult<GetVaccineDto>> AddNewVaccine(AddVaccineDto vaccineDto)
        {
            var newVaccine = await _service.AddNewVaccine(vaccineDto);
            return Ok(newVaccine);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVaccine(int id)
        {
            var vaccine = _service.GetVaccine(id);

            if (vaccine is null)
                return NotFound();

            await _service.DeleteVaccine(id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetVaccineDto>> UpdateVaccine(int id, UpdateVaccineDto vaccineDto)
        {
            var vaccine = _service.GetVaccine(id);

            if (vaccine is null)
                return NotFound();

            await _service.UpdateVaccine(id, vaccineDto);

            return Ok(await _service.GetVaccine(id));
        }
    }
}
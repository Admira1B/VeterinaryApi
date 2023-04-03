using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.IllnessesDto;
using VeterinaryApi.Services.IllnessService;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IllnessController : ControllerBase
    {
        private readonly IIllnessService _service;
        public IllnessController(IIllnessService service) { _service = service; }

        [HttpGet]
        public async Task<ActionResult<List<GetIllnessDto>>> Getillnesses()
        {
            return Ok(await _service.GetIllnesses());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetIllnessDto>> GetIllness(int id)
        {
            var illness = await _service.GetIllness(id);

            if (illness is null)
                return NotFound();

            return Ok(illness);
        }

        [HttpPost]
        public async Task<ActionResult<GetIllnessDto>> AddNewIllness(AddIllnessDto illnessDto)
        {
            var newIllness = await _service.AddNewIllness(illnessDto);
            return Ok(newIllness);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteIllness(int id)
        {
            var illness = await _service.GetIllness(id);

            if (illness is null)
                return NotFound();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetIllnessDto>> UpdateIllness(int id,UpdateIllnessDto illnessDto)
        {
            var illness = await _service.GetIllness(id);

            if (illness is null)
                return NotFound();

            await _service.UpdateIllness(id, illnessDto);

            return Ok(await _service.GetIllness(id));
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.TypeOfAnimalDtos;
using VeterinaryApi.Services.TypeOfAnimalService;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TypeOfAnimalController : ControllerBase
    {
        private readonly ITypeOfAnimalService _service;
        public TypeOfAnimalController(ITypeOfAnimalService service) { _service = service; }

        [HttpGet]
        public async Task<ActionResult<List<GetTypeOfAnimalDto>>> GetTypesOfAnimals()
        {
            return Ok(await _service.GetTypeOfAnimals());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetTypeOfAnimalDto>> GetTypeOfAnimal(int id)
        {
            var typeOfAnimal = await _service.GetTypeOfAnimal(id);

            if (typeOfAnimal is null)
                return NotFound();

            return Ok(typeOfAnimal);
        }

        [HttpPost]
        public async Task<ActionResult<GetTypeOfAnimalDto>> AddNewTypeOfAnimal(AddTypeOfAnimalDto typeOfAnimalDto)
        {
            var newTypeOfAnimal = await _service.AddNewTypeOfAnimal(typeOfAnimalDto);
            return Ok(newTypeOfAnimal);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTypeOfAnimal(int id)
        {
            var typeOfAnimal = _service.GetTypeOfAnimal(id);

            if (typeOfAnimal is null)
                return NotFound();

            await _service.DeleteTypeOfAnimal(id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetTypeOfAnimalDto>> UpdateTypeOfAnimal(int id, UpdateTypeOfAnimalDto typeOfAnimalDto)
        {
            var typeOfAnimal = _service.GetTypeOfAnimal(id);

            if (typeOfAnimal is null)
                return NotFound();

            await _service.UpdateTypeOfAnimal(id, typeOfAnimalDto);

            return Ok(await _service.GetTypeOfAnimal(id));
        }
    }
}
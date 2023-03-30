using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.TypeOfAnimalDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TypeOfAnimalController
    {
        [HttpGet]
        public async Task<ActionResult<List<GetTypeOfAnimalDto>>> GetTypesOfAnimals()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetTypeOfAnimalDto>> GetTypeOfAnimal(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GetTypeOfAnimalDto>> AddNewTypeOfAnimal(AddTypeOfAnimalDto typeDto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTypeOfAnimal(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetTypeOfAnimalDto>> UpdateTypeOfAnimal(UpdateTypeOfAnimalDto typeDto)
        {
        }
    }
}
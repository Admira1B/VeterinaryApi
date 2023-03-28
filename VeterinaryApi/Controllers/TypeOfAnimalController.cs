using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TypeOfAnimalController
    {
        [HttpGet]
        public async Task<ActionResult<List<TypeOfAnimal>>> GetTypesOfAnimals()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TypeOfAnimal>> GetTypeOfAnimal(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddNewTypeOfAnimal(TypeOfAnimal type)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTypeOfAnimal(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TypeOfAnimal>> UpdateTypeOfAnimal(TypeOfAnimal type)
        {
        }
    }
}
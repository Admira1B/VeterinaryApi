using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TypeOfAnimalController
    {
        [HttpGet]
        public ActionResult<List<TypeOfAnimal>> GetTypesOfAnimals()
        {
        }

        [HttpGet("{id}")]
        public ActionResult<TypeOfAnimal> GetTypeOfAnimal(int id)
        {
        }

        [HttpPost]
        public ActionResult AddNewTypeOfAnimal(TypeOfAnimal type)
        {
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTypeOfAnimal(int id)
        {
        }

        [HttpPut("{id}")]
        public ActionResult<TypeOfAnimal> UpdateTypeOfAnimal(TypeOfAnimal type)
        {
        }
    }
}
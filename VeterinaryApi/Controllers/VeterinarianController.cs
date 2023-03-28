using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VeterinarianController
    {
        [HttpGet]
        public ActionResult<List<Veterinarian>> GetVeterinarians()
        {
        }

        [HttpGet("{id}")]
        public ActionResult<Veterinarian> GetVeterinarian(int id)
        {
        }

        [HttpPost]
        public ActionResult AddNewVeterinarian(Veterinarian veterinarian)
        {
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteVeterinarian(int id)
        {
        }

        [HttpPut("{id}")]
        public ActionResult<Veterinarian> UpdateVeterinarian(Veterinarian veterinarian)
        {
        }
    }
}
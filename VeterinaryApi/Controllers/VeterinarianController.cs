using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VeterinarianController
    {
        [HttpGet]
        public async Task<ActionResult<List<Veterinarian>>> GetVeterinarians()
        {
            return null;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Veterinarian>> GetVeterinarian(int id)
        {
            return null;
        }

        [HttpPost]
        public async Task<ActionResult> AddNewVeterinarian(Veterinarian veterinarian)
        {
            return null;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVeterinarian(int id)
        {
            return null;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Veterinarian>> UpdateVeterinarian(Veterinarian veterinarian)
        {
            return null;
        }
    }
}
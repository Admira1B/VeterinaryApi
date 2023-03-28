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
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Veterinarian>> GetVeterinarian(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddNewVeterinarian(Veterinarian veterinarian)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVeterinarian(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Veterinarian>> UpdateVeterinarian(Veterinarian veterinarian)
        {
        }
    }
}
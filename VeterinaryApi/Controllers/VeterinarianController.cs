using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.VeterinarianDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VeterinarianController
    {
        [HttpGet]
        public async Task<ActionResult<List<GetVeterinarianDto>>> GetVeterinarians()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetVeterinarianDto>> GetVeterinarian(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GetVeterinarianDto>> AddNewVeterinarian(AddVeterinarianDto veterinarianDto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVeterinarian(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetVeterinarianDto>> UpdateVeterinarian(UpdateVeterinarianDto veterinarianDto)
        {
        }
    }
}
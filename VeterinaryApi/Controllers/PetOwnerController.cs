using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.PetOwnerDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetOwnerOwnerController
    {
        [HttpGet]
        public async Task<ActionResult<List<GetPetOwnerDto>>> GetPetOwners()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetPetOwnerDto>> GetPetOwner(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GetPetOwnerDto>> AddNewPetOwner(AddPetOwnerDto petOwnerDto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePetOwner(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetPetOwnerDto>> UpdatePetOwner(UpdatePetOwnerDto petOwnerDto)
        {
        }
    }
}
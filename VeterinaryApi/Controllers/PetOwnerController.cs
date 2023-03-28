using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetOwnerOwnerController
    {
        [HttpGet]
        public async Task<ActionResult<List<PetOwner>>> GetPetOwners()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PetOwner>> GetPetOwner(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddNewPetOwner(PetOwner petOwner)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePetOwner(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PetOwner>> UpdatePetOwner(PetOwner petOwner)
        {
        }
    }
}
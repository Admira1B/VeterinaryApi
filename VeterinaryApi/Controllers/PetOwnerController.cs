using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PetOwnerOwnerController
    {
        [HttpGet]
        public ActionResult<List<PetOwner>> GetPetOwners()
        {
        }

        [HttpGet("{id}")]
        public ActionResult<PetOwner> GetPetOwner(int id)
        {
        }

        [HttpPost]
        public ActionResult AddNewPetOwner(PetOwner petOwner)
        {
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePetOwner(int id)
        {
        }

        [HttpPut("{id}")]
        public ActionResult<PetOwner> UpdatePetOwner(PetOwner petOwner)
        {
        }
    }
}
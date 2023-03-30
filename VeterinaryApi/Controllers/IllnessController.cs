using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.IllnessesDto;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IllnessController
    {
        [HttpGet]
        public async Task<ActionResult<List<GetIllnessDto>>> GetIllnesesses()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetIllnessDto>> GetIllness(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GetIllnessDto>> AddNewIllness(AddIllnessDto illnessDto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteIllness(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateIllnessDto>> UpdateIllness(Illness illnessDto)
        {
        }
    }
}
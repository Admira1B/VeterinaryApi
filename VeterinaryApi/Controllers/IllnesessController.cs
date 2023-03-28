using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IllnesessController
    {
        [HttpGet]
        public async Task<ActionResult<List<Illness>>> GetIllnesesses()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Illness>> GetIllness(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddNewIllness(Illness illness)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteIllness(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Illness>> UpdateIllness(Illness illness)
        {
        }
    }
}
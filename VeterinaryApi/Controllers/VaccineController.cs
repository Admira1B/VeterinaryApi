using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VaccineController
    {
        [HttpGet]
        public async Task<ActionResult<List<Vaccine>>> GetVaccines()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vaccine>> GetVaccine(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddNewVaccine(Vaccine vaccine)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVaccine(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Vaccine>> UpdateVaccine(Vaccine vaccine)
        {
        }
    }
}
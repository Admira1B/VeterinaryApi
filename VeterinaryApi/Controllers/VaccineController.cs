using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.VaccineDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VaccineController
    {
        [HttpGet]
        public async Task<ActionResult<List<GetVaccineDto>>> GetVaccines()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetVaccineDto>> GetVaccine(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GetVaccineDto>> AddNewVaccine(AddVaccineDto vaccineDto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVaccine(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetVaccineDto>> UpdateVaccine(UpdateVaccineDto vaccineDto)
        {
        }
    }
}
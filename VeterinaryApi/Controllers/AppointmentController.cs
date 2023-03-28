using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AppointmentController
    {
        [HttpGet]
        public async Task<ActionResult<List<Appointment>>> GetAppointments()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Appointment>> GetAppointment(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddNewAppointment(Appointment appointment)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAppointment(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Pet>> UpdateAppointment(Appointment appointment)
        {
        }
    }
}
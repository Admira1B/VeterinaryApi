using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.AppointmentDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AppointmentController
    {
        [HttpGet]
        public async Task<ActionResult<List<GetAppointmentDto>>> GetAppointments()
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetAppointmentDto>> GetAppointment(int id)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GetAppointmentDto>> AddNewAppointment(AddAppointmentDto appointmentDto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAppointment(int id)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetAppointmentDto>> UpdateAppointment(UpdateAppointmentDto appointmentDto)
        {
        }
    }
}
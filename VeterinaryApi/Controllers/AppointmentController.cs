using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos.AppointmentDtos;
using VeterinaryApi.Services.AppointmentService;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _service;
        public AppointmentController(IAppointmentService service) { _service = service; }

        [HttpGet]
        public async Task<ActionResult<List<GetAppointmentDto>>> GetAppointments()
        {
            return Ok(await _service.GetAppointments());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetAppointmentDto>> GetAppointment(int id)
        {
            var appointment = await _service.GetAppointment(id);

            if (appointment is null)
                return NotFound();

            return Ok(appointment);
        }

        [HttpPost]
        public async Task<ActionResult<GetAppointmentDto>> AddNewAppointment(AddAppointmentDto appointmentDto)
        {
            var newAppointment = await _service.AddNewAppointment(appointmentDto);
            return Ok(newAppointment);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAppointment(int id)
        {
            var appointment = await _service.GetAppointment(id);
            if (appointment is null)
                return NotFound();

            _service.DeleteAppointment(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GetAppointmentDto>> UpdateAppointment(int id, UpdateAppointmentDto appointmentDto)
        {
            var appointment = await _service.GetAppointment(id);

            if (appointment is null)
                return NotFound();

            await _service.UpdateAppointment(id, appointmentDto);

            return Ok(await _service.GetAppointment(id));
        }
    }
}
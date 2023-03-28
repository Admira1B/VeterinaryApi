using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AppointmentController
    {
        [HttpGet]
        public ActionResult<List<Appointment>> GetAppointments()
        {
        }

        [HttpGet("{id}")]
        public ActionResult<Appointment> GetAppointment(int id)
        {
        }

        [HttpPost]
        public ActionResult AddNewAppointment(Appointment appointment)
        {
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteAppointment(int id)
        {
        }

        [HttpPut("{id}")]
        public ActionResult<Pet> UpdateAppointment(Appointment appointment)
        {
        }
    }
}
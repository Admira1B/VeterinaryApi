using VeterinaryApi.Dtos.AppointmentDtos;

namespace VeterinaryApi.Services.AppointmentService
{
    public interface IAppointmentService
    {
        Task<List<GetAppointmentDto>> GetAppointments();
        Task<GetAppointmentDto> GetAppointment(int id);
        Task<GetAppointmentDto> AddNewAppointment(AddAppointmentDto appointmentDto);
        Task DeleteAppointment(int id);
        Task UpdateAppointment(int id, UpdateAppointmentDto appointmentDto);
    }
}
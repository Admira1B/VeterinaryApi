using VeterinaryApi.Dtos.AppointmentDtos;

namespace VeterinaryApi.Services.AppointmentService
{
    public interface IAppointmentService
    {
        Task<List<GetAppointmentDto>> GetAppointments();
        Task<GetAppointmentDto> GetAppointment(int id);
        Task<GetAppointmentDto> AddNewAppointment(AddAppointmentDto appointmentDto);
        void DeleteAppointment(int id);
        Task<GetAppointmentDto> UpdateAppointment(int id, UpdateAppointmentDto appointmentDto);
    }
}
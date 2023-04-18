using AutoMapper;
using VeterinaryApi.Data;
using VeterinaryApi.Dtos.AppointmentDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Services.AppointmentService
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public AppointmentService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<List<GetAppointmentDto>> GetAppointments()
        {
            var dbAppointments = await _dataContext.Appointments.ToListAsync();
            return dbAppointments.Select(appointment => _mapper.Map<GetAppointmentDto>(appointment)).ToList();
        }

        public async Task<GetAppointmentDto> GetAppointment(int id)
        {
            var dbAppointment = await _dataContext.Appointments.FindAsync(id);
            return _mapper.Map<GetAppointmentDto>(dbAppointment);
        }

        public async Task<GetAppointmentDto> AddNewAppointment(AddAppointmentDto appointmentDto)
        {
            var newAppointment = _mapper.Map<Appointment>(appointmentDto);
            await _dataContext.Appointments.AddAsync(newAppointment);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetAppointmentDto>(newAppointment);
        }

        public async Task DeleteAppointment(int id)
        {
            var appointment = await _dataContext.Appointments.FindAsync(id);
            _dataContext.Appointments.Remove(appointment!);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateAppointment(int id, UpdateAppointmentDto appointmentDto)
        {
            var appointment = await _dataContext.Appointments.FindAsync(id);

            _mapper.Map(appointmentDto, appointment);
            appointment!.Id = id;
            await _dataContext.SaveChangesAsync();
        }
    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
            _dataContext.Appointments.Add(newAppointment);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetAppointmentDto>(newAppointment);
        }

        public void DeleteAppointment(int id)
        {
            _dataContext.Remove(id);
        }

        public async Task<GetAppointmentDto> UpdateAppointment(int id, UpdateAppointmentDto appointmentDto)
        {
            var appointment = await _dataContext.Appointments.FindAsync(id);

            _mapper.Map(appointmentDto, appointment);
            appointment.Id = id;
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetAppointmentDto>(appointment);
        }
    }
}

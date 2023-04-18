using AutoMapper;
using VeterinaryApi.Data;
using VeterinaryApi.Dtos.VaccineDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Services.VaccineService
{
    public class VaccineService : IVaccineService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public VaccineService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<List<GetVaccineDto>> GetVaccines()
        {
            var dbVaccines = await _dataContext.Vaccines.ToListAsync();
            return dbVaccines.Select(vaccine => _mapper.Map<GetVaccineDto>(vaccine)).ToList();
        }

        public async Task<GetVaccineDto> GetVaccine(int id)
        {
            var dbVaccine = await _dataContext.Vaccines.FindAsync(id);
            return _mapper.Map<GetVaccineDto>(dbVaccine);
        }

        public async Task<GetVaccineDto> AddNewVaccine(AddVaccineDto vaccineDto)
        {
            var newVaccine = _mapper.Map<Vaccine>(vaccineDto);
            await _dataContext.Vaccines.AddAsync(newVaccine);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetVaccineDto>(newVaccine);
        }

        public async Task DeleteVaccine(int id)
        {
            var vaccine = await _dataContext.Vaccines.FindAsync(id);
            _dataContext.Vaccines.Remove(vaccine!);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateVaccine(int id, UpdateVaccineDto vaccineDto)
        {
            var vaccine = await _dataContext.Vaccines.FindAsync(id);

            _mapper.Map(vaccineDto, vaccine);
            vaccine!.Id = id;
            await _dataContext.SaveChangesAsync();
        }
    }
}

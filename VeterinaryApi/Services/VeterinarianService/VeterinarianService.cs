using AutoMapper;
using VeterinaryApi.Data;
using VeterinaryApi.Dtos.VeterinarianDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Services.VeterinarianService
{
    public class VeterinarianService : IVeterinarianService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public VeterinarianService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<List<GetVeterinarianDto>> GetVeterinarians()
        {
            var dbVeterinarians = await _dataContext.Veterinarians.ToListAsync();
            return dbVeterinarians.Select(veterinarian => _mapper.Map<GetVeterinarianDto>(veterinarian)).ToList();
        }

        public async Task<GetVeterinarianDto> GetVeterinarian(int id)
        {
            var dbVeterinarian = await _dataContext.Veterinarians.FindAsync(id);
            return _mapper.Map<GetVeterinarianDto>(dbVeterinarian);
        }

        public async Task<GetVeterinarianDto> AddNewVeterinarian(AddVeterinarianDto veterinarianDto)
        {
            var newVeterinarian = _mapper.Map<Veterinarian>(veterinarianDto);
            await _dataContext.Veterinarians.AddAsync(newVeterinarian);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetVeterinarianDto>(newVeterinarian);
        }

        public async Task DeleteVeterinarian(int id)
        {
            _dataContext.Veterinarians.Remove(id);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateVeterinarian(int id, UpdateVeterinarianDto veterinarianDto)
        {
            var veterinarian = await _dataContext.Veterinarians.FindAsync(id);

            _mapper.Map(veterinarianDto, veterinarian);
            veterinarian.Id = id;
            await _dataContext.SaveChangesAsync();
        }
    }
}

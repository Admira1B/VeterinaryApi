using AutoMapper;
using VeterinaryApi.Data;
using VeterinaryApi.Dtos.PetDto;
using VeterinaryApi.Models;

namespace VeterinaryApi.Services.PetService
{
    public class PetService : IPetService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public PetService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<List<GetPetDto>> GetPets()
        {
            var dbPets = await _dataContext.Pets.ToListAsync();
            return dbPets.Select(pet => _mapper.Map<GetPetDto>(pet)).ToList();
        }

        public async Task<GetPetDto> GetPet(int id)
        {
            var dbPet = await _dataContext.Pets.FindAsync(id);
            return _mapper.Map<GetPetDto>(dbPet);
        }

        public async Task<GetPetDto> AddNewPet(AddPetDto petDto)
        {
            var newPet = _mapper.Map<Pet>(petDto);
            await _dataContext.Pets.AddAsync(newPet);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetPetDto>(newPet);
        }

        public async Task DeletePet(int id)
        {
            _dataContext.Pets.Remove(id);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdatePet(int id, UpdatePetDto petDto)
        {
            var pet = await _dataContext.Pets.FindAsync(id);

            _mapper.Map(petDto, pet);
            pet.Id = id;
            await _dataContext.SaveChangesAsync();
        }
    }
}

using AutoMapper;
using VeterinaryApi.Data;
using VeterinaryApi.Dtos.PetOwnerDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Services.PetOwnerService
{
    public class PetOwnerService : IPetOwnerService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public PetOwnerService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }
        public async Task<List<GetPetOwnerDto>> GetOwners()
        {
            var dbOwners = await _dataContext.PetOwners.ToListAsync();
            return dbOwners.Select(owner => _mapper.Map<GetPetOwnerDto>(owner)).ToList();
        }

        public async Task<GetPetOwnerDto> GetOwner(int id)
        {
            var dbOwner = await _dataContext.PetOwners.FindAsync(id);
            return _mapper.Map<GetPetOwnerDto>(dbOwner);
        }

        public async Task<GetPetOwnerDto> AddNewPetOwner(AddPetOwnerDto petOwnerDto)
        {
            var newOwner = _mapper.Map<PetOwner>(petOwnerDto);
            await _dataContext.PetOwners.AddAsync(newOwner);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetPetOwnerDto>(newOwner);
        }

        public async Task DeleteOwner(int id)
        {
            var owner = await _dataContext.PetOwners.FindAsync(id);   
            _dataContext.PetOwners.Remove(owner!);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateOwner(int id, UpdatePetOwnerDto ownerDto)
        {
            var owner = await _dataContext.PetOwners.FindAsync(id);

            _mapper.Map(ownerDto, owner);
            owner!.Id = id;
            await _dataContext.SaveChangesAsync();
        }
    }
}
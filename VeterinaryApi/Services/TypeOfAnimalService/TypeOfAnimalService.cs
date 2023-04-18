using AutoMapper;
using VeterinaryApi.Data;
using VeterinaryApi.Dtos.TypeOfAnimalDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Services.TypeOfAnimalService
{
    public class TypeOfAnimalService : ITypeOfAnimalService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public TypeOfAnimalService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<List<GetTypeOfAnimalDto>> GetTypeOfAnimals()
        {
            var dbTypeOfAnimals = await _dataContext.TypesOfAnimals.ToListAsync();
            return dbTypeOfAnimals.Select(typeOfAnimal => _mapper.Map<GetTypeOfAnimalDto>(typeOfAnimal)).ToList();
        }

        public async Task<GetTypeOfAnimalDto> GetTypeOfAnimal(int id)
        {
            var dbTypeOfAnimal = await _dataContext.TypesOfAnimals.FindAsync(id);
            return _mapper.Map<GetTypeOfAnimalDto>(dbTypeOfAnimal);
        }

        public async Task<GetTypeOfAnimalDto> AddNewTypeOfAnimal(AddTypeOfAnimalDto typeOfAnimalDto)
        {
            var newTypeOfAnimal = _mapper.Map<TypeOfAnimal>(typeOfAnimalDto);
            await _dataContext.TypesOfAnimals.AddAsync(newTypeOfAnimal);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetTypeOfAnimalDto>(newTypeOfAnimal);
        }

        public async Task DeleteTypeOfAnimal(int id)
        {
            var type = await _dataContext.TypesOfAnimals.FindAsync(id);
            _dataContext.TypesOfAnimals.Remove(type!);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateTypeOfAnimal(int id, UpdateTypeOfAnimalDto typeOfAnimalDto)
        {
            var typeOfAnimal = await _dataContext.TypesOfAnimals.FindAsync(id);

            _mapper.Map(typeOfAnimalDto, typeOfAnimal);
            typeOfAnimal!.Id = id;
            await _dataContext.SaveChangesAsync();
        }
    }
}

using VeterinaryApi.Dtos.TypeOfAnimalDtos;

namespace VeterinaryApi.Services.TypeOfAnimalService
{
    public interface ITypeOfAnimalService
    {
        Task<List<GetTypeOfAnimalDto>> GetTypeOfAnimals();
        Task<GetTypeOfAnimalDto> GetTypeOfAnimal(int id);
        Task<GetTypeOfAnimalDto> AddNewTypeOfAnimal(AddTypeOfAnimalDto typeOfAnimalDto);
        Task DeleteTypeOfAnimal(int id);
        Task UpdateTypeOfAnimal(int id, UpdateTypeOfAnimalDto typeOfAnimalDto);
    }
}
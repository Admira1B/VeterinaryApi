using VeterinaryApi.Dtos.VeterinarianDtos;

namespace VeterinaryApi.Services.VeterinarianService
{
    public interface IVeterinarianService
    {
        Task<List<GetVeterinarianDto>> GetVeterinarians();
        Task<GetVeterinarianDto> GetVeterinarian(int id);
        Task<GetVeterinarianDto> AddNewVeterinarian(AddVeterinarianDto veterinarianDto);
        Task DeleteVeterinarian(int id);
        Task UpdateVeterinarian(int id, UpdateVeterinarianDto veterinarianDto);
    }
}
using VeterinaryApi.Dtos.VaccineDtos;

namespace VeterinaryApi.Services.VaccineService
{
    public interface IVaccineService
    {
        Task<List<GetVaccineDto>> GetVaccines();
        Task<GetVaccineDto> GetVaccine(int id);
        Task<GetVaccineDto> AddNewVaccine(AddVaccineDto vaccineDto);
        Task DeleteVaccine(int id);
        Task UpdateVaccine(int id, UpdateVaccineDto vaccineDto);
    }
}
using VeterinaryApi.Dtos.IllnessesDto;

namespace VeterinaryApi.Services.IllnessService
{
    public interface IIllnessService
    {
        Task<List<GetIllnessDto>> GetIllnesses();
        Task<GetIllnessDto> GetIllness(int id);
        Task<GetIllnessDto> AddNewIllness(AddIllnessDto illnessDto);
        Task DeleteIllness(int id);
        Task UpdateIllness(int id, UpdateIllnessDto illnessDto);
    }
}
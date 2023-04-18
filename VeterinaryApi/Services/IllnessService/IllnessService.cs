using AutoMapper;
using VeterinaryApi.Data;
using VeterinaryApi.Dtos.IllnessesDto;
using VeterinaryApi.Models;

namespace VeterinaryApi.Services.IllnessService
{
    public class IllnessService : IIllnessService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public IllnessService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<List<GetIllnessDto>> GetIllnesses()
        {
            var dbIllnesses = await _dataContext.Illnesses.ToListAsync();
            return dbIllnesses.Select(illness => _mapper.Map<GetIllnessDto>(illness)).ToList();
        }

        public async Task<GetIllnessDto> GetIllness(int id)
        {
            var dbIllness = await _dataContext.Illnesses.FindAsync(id);
            return _mapper.Map<GetIllnessDto>(dbIllness);
        }

        public async Task<GetIllnessDto> AddNewIllness(AddIllnessDto illnessDto)
        {
            var newIllness = _mapper.Map<Illness>(illnessDto);
            await _dataContext.AddAsync(newIllness);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<GetIllnessDto>(newIllness);
        }

        public async Task DeleteIllness(int id)
        {
            var illness = await _dataContext.Illnesses.FindAsync(id);
            _dataContext.Illnesses.Remove(illness!);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateIllness(int id, UpdateIllnessDto illnessDto)
        {
            var illness = await _dataContext.Illnesses.FindAsync(id);

            _mapper.Map(illnessDto, illness);
            illness!.Id = id;
            await _dataContext.SaveChangesAsync();
        }
    }
}
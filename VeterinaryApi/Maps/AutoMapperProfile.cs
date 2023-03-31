using AutoMapper;
using VeterinaryApi.Dtos.AppointmentDtos;
using VeterinaryApi.Dtos.IllnessesDto;
using VeterinaryApi.Dtos.PetDto;
using VeterinaryApi.Dtos.PetOwnerDtos;
using VeterinaryApi.Dtos.TypeOfAnimalDtos;
using VeterinaryApi.Dtos.VaccineDtos;
using VeterinaryApi.Dtos.VeterinarianDtos;
using VeterinaryApi.Models;

namespace VeterinaryApi.Maps
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region AppointmentMaps
            CreateMap<GetAppointmentDto, Appointment>().ReverseMap();
            CreateMap<UpdateAppointmentDto, Appointment>().
                ForMember(dest => dest.EditDate, option => option.MapFrom(EditDate => DateTimeOffset.UtcNow));
            CreateMap<AddAppointmentDto, Appointment>().
                ForMember(dest => dest.EditDate, option => option.MapFrom(EditDate => DateTimeOffset.UtcNow));
            #endregion

            #region IllnessMaps
            CreateMap<GetIllnessDto, Illness>().ReverseMap();
            CreateMap<UpdateIllnessDto, Illness>();
            CreateMap<AddIllnessDto, Illness>();
            #endregion

            #region PetMaps
            CreateMap<GetPetDto, Pet>().ReverseMap();
            CreateMap<UpdatePetDto, Pet>();
            CreateMap<AddPetDto, Pet>();
            #endregion

            #region PetOwnerMaps
            CreateMap<GetPetOwnerDto, PetOwner>().ReverseMap();
            CreateMap<UpdatePetOwnerDto, PetOwner>();
            CreateMap<AddPetOwnerDto, PetOwner>();
            #endregion

            #region TypeOfAnimalMaps
            CreateMap<GetTypeOfAnimalDto, TypeOfAnimal>().ReverseMap();
            CreateMap<UpdateTypeOfAnimalDto, TypeOfAnimal>();
            CreateMap <AddTypeOfAnimalDto,TypeOfAnimal>();
            #endregion

            #region VaccineMaps
            CreateMap<GetVaccineDto, Vaccine>().ReverseMap();
            CreateMap<UpdateVaccineDto, Vaccine>();
            CreateMap<AddVaccineDto, Vaccine>();
            #endregion

            #region VeterinarianMaps
            CreateMap<GetVeterinarianDto, Veterinarian>();
            CreateMap<UpdateVeterinarianDto, Veterinarian>();
            CreateMap<AddVeterinarianDto, Veterinarian>();
            #endregion
        }
    }
}

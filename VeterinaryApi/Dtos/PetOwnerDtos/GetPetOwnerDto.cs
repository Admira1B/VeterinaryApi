﻿using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.PetOwnerDtos
{
    public class GetPetOwnerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; }
        public List<Pet> Pets { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}

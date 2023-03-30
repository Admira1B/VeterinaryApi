using Microsoft.EntityFrameworkCore;
using VeterinaryApi.Models;

namespace VeterinaryApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<Illness> Illnesses=> Set<Illness>();
        public DbSet<Pet> Pets=> Set<Pet>();
        public DbSet<PetOwner> PetOwners => Set<PetOwner>();
        public DbSet<TypeOfAnimal> TypesOfAnimals => Set<TypeOfAnimal>();
        public DbSet<Vaccine> Vaccines => Set<Vaccine>();
        public DbSet<Veterinarian> Veterinarians => Set<Veterinarian>();
    }
}
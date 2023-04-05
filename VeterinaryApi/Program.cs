global using Microsoft.EntityFrameworkCore;
using VeterinaryApi.Data;
using VeterinaryApi.Services.AppointmentService;
using VeterinaryApi.Services.IllnessService;
using VeterinaryApi.Services.PetOwnerService;
using VeterinaryApi.Services.PetService;
using VeterinaryApi.Services.TypeOfAnimalService;
using VeterinaryApi.Services.VaccineService;
using VeterinaryApi.Services.VeterinarianService;

namespace VeterinaryApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlExpressConnection")));
            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            #region MyServices
            builder.Services.AddScoped<IAppointmentService, AppointmentService>();
            builder.Services.AddScoped<IIllnessService, IllnessService>();
            builder.Services.AddScoped<IPetOwnerService, PetOwnerService>();
            builder.Services.AddScoped<IPetService, PetService>();
            builder.Services.AddScoped<ITypeOfAnimalService, TypeOfAnimalService>();
            builder.Services.AddScoped<IVaccineService, VaccineService>();
            builder.Services.AddScoped<IVeterinarianService, VeterinarianService>();
            #endregion

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
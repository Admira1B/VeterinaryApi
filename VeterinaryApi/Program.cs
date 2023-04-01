global using Microsoft.EntityFrameworkCore;
using VeterinaryApi.Data;
using VeterinaryApi.Services.AppointmentService;

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
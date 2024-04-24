
using CZ.Infrastructure.Repository;
using CZ.Services;

namespace CZ.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ReservationRepository, ReservationRepository>();
            builder.Services.AddScoped<ClientReservationRepository, ClientReservationRepository>();
            builder.Services.AddScoped<ClientReservationService, ClientReservationService>();
            builder.Services.AddScoped<ClientRepository, ClientRepository>();
            builder.Services.AddScoped<TableRepository, TableRepository>();
            builder.Services.AddScoped<DaytimeRepository, DaytimeRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

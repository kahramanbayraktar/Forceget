using Forceget.Data;
using Forceget.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Forceget.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<OfferContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ForcegetDb")));

            builder.Services.AddScoped<IRepository, SqlRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // TODO: move it to an extension class
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<OfferContext>();
                context.Database.Migrate();
                OfferContextSeed.SeedAsync(context).Wait();
            }            

            // Configure the HTTP request pipeline.
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
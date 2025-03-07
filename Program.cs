using Microsoft.EntityFrameworkCore;
using TemplateApplication.Controllers;
using TemplateApplication.Repo;
using TemplateApplication.Services;

namespace TemplateApplication {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Has to be added for every Service in the project
            builder.Services.AddScoped<TemplateService>();

            var app = builder.Build();

            var connectionString =
                builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string"
                                                       + "'DefaultConnection' not found.");

            builder.Services.AddDbContext<InitContext>(options =>
                options.UseSqlServer(connectionString));

            using (var scope = app.Services.CreateScope()) {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<InitContext>();
                context.Database.Migrate();
            }

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
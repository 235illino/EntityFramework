using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolDB;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // Register the DbContext with the configuration
        services.AddDbContext<SchoolDBContext>(options =>
            options.UseSqlServer(context.Configuration.GetConnectionString("SchoolDBLocalConnection")));

        // Add other services
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<SchoolDBContext>();

    // Perform database operations
}

host.Run();


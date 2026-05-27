using BoardGameCafeApp.Data;
using BoardGameCafeApp.Forms;
using BoardGameCafeApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BoardGameCafeApp;

internal static class Program
{
    public static IServiceProvider Services { get; private set; } = default!;

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var services = new ServiceCollection();

        services.AddSingleton<IConfiguration>(configuration);

        services.AddDbContext<CafeDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CafeDb")));

        services.AddScoped<GameService>();
        services.AddScoped<RentalService>();
        services.AddScoped<BookingService>();

        Services = services.BuildServiceProvider();

        using var scope = Services.CreateScope();
        var provider = scope.ServiceProvider;

        Application.Run(new LoginForm(provider));
    }
}
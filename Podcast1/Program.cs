using Microsoft.EntityFrameworkCore;
using Podcast1.DataAccessLayer;

namespace Podcast1;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<AppDbContext>(builder =>
        {
            builder.UseSqlServer(connectionString);
        });

        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoint =>
        {
            endpoint.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
        });

        app.Run();
    }
}

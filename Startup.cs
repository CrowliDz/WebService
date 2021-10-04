using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebService.Extensions;
using WebService.Middleware;

namespace WebService
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public IConfiguration Configuration { get; } //inyeccion de dependencias 

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // ctrl+k+c para comentar lo seleccionado
            // Para modificarlo creamos un metodo de extension, una clase independiente para llamarla aqui.
            // Esta no se modifica, solo se extiende, y al final suelen llamarse extensions.
            services.AddApplicationServices(_config);
            services.AddControllers();
            services.AddIdentityServices(_config);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionMiddleware>(); //Manejo de errores

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

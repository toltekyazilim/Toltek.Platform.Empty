using Toltek.Data;

namespace Toltek.Platform.Empty
{
    public class Startup : AppStartup<Startup>
    {
        public override string Key => "toltek.platform.Empty";
        public override string Version => "1.0.1";
        public Startup(IWebHostEnvironment env, ILoggerFactory factory) : base(env, factory)
        {
        }
        public override void AddDbServices(IServiceCollection services)
        {
            services.AddDbServices(this.Configuration);
            //services.AddSingleton<IResourceRepository, ResourceRepository>();
        }
        public override void AddMapperServices(IServiceCollection services)
        {
            this.AddMapperServices(services, CoreProfile.Profiles, typeof(Startup));
        }
        public override void AddTenancyOptions(IServiceCollection services)
        {
            services.AddThemeServices();
        } 
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Interfaces;
using ServiceLayer.Interfaces.Patient;
using ServiceLayer.Interfaces.Settings;
using ServiceLayer.Services;
using ServiceLayer.Services.Patient;
using ServiceLayer.Services.Settings;

namespace ServiceLayer
{
	public static class ServiceLayerConfig
    {
        public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services, IConfiguration configuration)
        {
			services.AddTransient<IHomeService, HomeService>();
			services.AddTransient<IUserService, UserService>();
			services.AddTransient<IStaffService, StaffService>();

			services.AddTransient<IPatientsService, PatientsService>();
			services.AddTransient<IDiseaseService, DiseaseService>();

			services.AddTransient<IDiseaseTypeService, DiseaseTypeService>();

			return services;
        }
    }
}

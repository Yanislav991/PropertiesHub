using AutoMapper;
using PropertiesHub.Server.Services.Contracts;
using PropertiesHub.Server.Services;
using PropertiesHub.Server.Profiles;

namespace PropertiesHub.Server.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            builder.AddProfiles();
            builder.Services.AddSingleton<IPropertyService, PropertyService>();

            return builder;
        }

        private static WebApplicationBuilder AddProfiles(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton(new MapperConfiguration(mc =>
            {
                mc.AddProfile<PropertiesProfile>();
            }).CreateMapper());

            builder.Services.AddSingleton<IPropertyService, PropertyService>();

            return builder;
        }
    }
}

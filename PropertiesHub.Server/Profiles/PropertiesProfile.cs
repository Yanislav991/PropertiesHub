using AutoMapper;
using PropertiesHub.Server.Data.Models;
using PropertiesHub.Server.Models.Properties;

namespace PropertiesHub.Server.Profiles
{
    public class PropertiesProfile : Profile
    {
        public PropertiesProfile()
        {
            CreateMap<Property, PropertyDTO>().ReverseMap();
        }
    }
}

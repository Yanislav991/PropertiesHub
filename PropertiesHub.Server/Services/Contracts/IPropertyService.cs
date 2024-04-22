using PropertiesHub.Server.Models.Properties;

namespace PropertiesHub.Server.Services.Contracts
{
    public interface IPropertyService
    {
        public Task<List<PropertyDTO>> GetProperties();
        public Task<PropertyDTO> CreateAsync(PropertyDTO property);
        public Task<PropertyDTO?> EditAsync(PropertyDTO property);
        public Task<bool> DeleteAsync(int id);
        public Task<PropertyDTO> GetByIdAsync(int id);
    }
}

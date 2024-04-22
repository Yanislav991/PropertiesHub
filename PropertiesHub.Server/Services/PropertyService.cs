using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PropertiesHub.Server.Data;
using PropertiesHub.Server.Data.Models;
using PropertiesHub.Server.Models.Properties;
using PropertiesHub.Server.Services.Contracts;

namespace PropertiesHub.Server.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly PropertiesHubDbContext _data;
        private readonly IMapper _mapper;

        public PropertyService(PropertiesHubDbContext data, IMapper mapper)
        {
            this._data = data;
            this._mapper = mapper;
        }
        public async Task<PropertyDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<PropertyDTO>(await _data.Properties.FirstOrDefaultAsync(prop => prop.ID == id));
        }
        public async Task<List<PropertyDTO>> GetProperties()
        {
            return _mapper.Map<List<PropertyDTO>>(await _data.Properties.ToListAsync());
        }
        public async Task<PropertyDTO> CreateAsync(PropertyDTO property)
        {
            var newProperty = _mapper.Map<Property>(property);
            await _data.Properties.AddAsync(newProperty);
            await _data.SaveChangesAsync();
            return _mapper.Map<PropertyDTO>(await _data.Properties.FirstOrDefaultAsync(prop => prop.ID == newProperty.ID));
        }
        public async Task<PropertyDTO?> EditAsync(PropertyDTO property)
        {
            var existingProperty = await _data.Properties.FirstOrDefaultAsync(prop => prop.ID == property.ID);
            if (existingProperty == null)
            {
                return null;
            }
            _mapper.Map(property, existingProperty);
            await _data.SaveChangesAsync();
            return _mapper.Map<PropertyDTO>(existingProperty);
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var property = await _data.Properties.FirstOrDefaultAsync(prop => prop.ID == id);
            if (property != null)
            {
                _data.Properties.Remove(property);
                await _data.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}

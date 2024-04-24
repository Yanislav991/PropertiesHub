using Microsoft.AspNetCore.Mvc;
using PropertiesHub.Server.Models.Properties;
using PropertiesHub.Server.Services.Contracts;

namespace PropertiesHub.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertiesController : Controller
    {
        private readonly IPropertyService _propertyService;
        public PropertiesController(IPropertyService propertyService)
        {
            this._propertyService = propertyService;
        }
        [HttpGet]
        public async Task<ActionResult<List<PropertyDTO>>> GetProperties()
        {
            try
            {
                return Ok(await this._propertyService.GetProperties());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyDTO>> GetProperty(int id)
        {
            try
            {
                var property = await this._propertyService.GetByIdAsync(id);
                return property == null ? NotFound() : Ok(property);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
        [HttpPost]
        public async Task<ActionResult<PropertyDTO>> CreateProperty(PropertyDTO propertyData)
        {
            try
            {
                var editedProperty = await this._propertyService.EditAsync(propertyData);
                return editedProperty == null ? NotFound() : CreatedAtAction(nameof(CreateProperty), editedProperty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
        [HttpPut]
        public async Task<ActionResult<PropertyDTO>> EditProperty(PropertyDTO propertyData)
        {
            try
            {
                var propertyToEdit = await this._propertyService.GetByIdAsync(propertyData.ID);
                return propertyToEdit == null ? NotFound() : Ok(propertyToEdit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteProperty(int id)
        {
            try
            {
                return await this._propertyService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}

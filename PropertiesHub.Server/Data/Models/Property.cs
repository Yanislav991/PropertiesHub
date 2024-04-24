using System.ComponentModel.DataAnnotations;

namespace PropertiesHub.Server.Data.Models
{
    public class Property
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public double? Price { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
    }
}

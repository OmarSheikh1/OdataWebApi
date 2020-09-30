using System;
using System.ComponentModel.DataAnnotations;

namespace OdataWebApi
{
    public class WeatherForecast
    {
        [Key]
        public string Id { get; set; }
        public DateTime Date { get; set; }

        [Required]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Use between 4 and 8 characters")]
        public string Summary { get; set; }
    }
}

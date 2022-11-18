using System.ComponentModel.DataAnnotations;

namespace Final_ASP_Assessment.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Vin { get; set; }
        public string? Color { get; set; }

        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
        public int Owner_Id { get; set; }
    }
}

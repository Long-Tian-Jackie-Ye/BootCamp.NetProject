using System.ComponentModel.DataAnnotations;

namespace Final_ASP_Assessment.Models
{
    public class Claims
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Vehicle_Id { get; set; }
    }
}

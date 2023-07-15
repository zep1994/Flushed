using System.ComponentModel.DataAnnotations;

namespace Flushed_API.Dtos
{
    public class NutritionReadDto
    {
        [Key]
        public int Id { get; set; }

        public int Calories { get; set; }

        public int? TotalWeight { get; set; }

        public string[]? DietLabels { get; set; }

        public string[]? HealthLabels { get; set; }

        public string[]? Cautions { get; set; }

        public string[]? Ingredients { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Flushed_API.Dtos
{
    public class NutritionUpdateDto
    {
        public int Calories { get; set; }

        public int? TotalWeight { get; set; }

        public string[]? DietLabels { get; set; }

        public string[]? HealthLabels { get; set; }

        public string[]? Cautions { get; set; }

        public string[]? Ingredients { get; set; }
    }
}


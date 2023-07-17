using System.ComponentModel.DataAnnotations;

namespace Flushed_API.Models
{
    public class Nutrition
    {
        [Key]
        public int Id { get; set; }

        public string? Query { get; set; }

        public int? Calories { get; set; }

        public string? Cuisine { get; set; }

        public string[]? Diet { get; set; }

        public string[]? Intolerance { get; set; }

        public string[]? IncludeIngredients { get; set; }

        public string[]? Ingredients { get; set; }
    }
}


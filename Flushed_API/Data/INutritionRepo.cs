using Flushed_API.Models;

namespace Flushed_API.Data
{
    public interface INutritionRepo
    {
        Task SaveChanges();
        Task<Nutrition> GetNutritionById(int id);
        Task<IEnumerable<Nutrition>> GetAllNutritions();
        Task CreateNutrition(Nutrition nutrition);
        void DeleteNutrition(Nutrition nutrition);
    }
}

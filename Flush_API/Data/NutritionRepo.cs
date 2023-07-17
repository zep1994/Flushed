using Flushed_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Flushed_API.Data
{
    public class NutritionRepo : INutritionRepo
    {
        private readonly AppDbContext _context;

        public NutritionRepo(AppDbContext context) 
        {
            _context = context;
        }
        public async Task CreateNutrition(Nutrition nutrition)
        {
            if (nutrition == null) 
            {
                throw new ArgumentNullException(nameof(nutrition));
            }

            await _context.AddAsync(nutrition);
        }

        public void DeleteNutrition(Nutrition nutrition)
        {
           if (nutrition == null)
            {
                throw new ArgumentNullException(nameof(nutrition));
            }

           _context.Nutritions.Remove(nutrition);
        }

        public async Task<IEnumerable<Nutrition>> GetAllNutritions()
        {
            return await _context.Nutritions.ToListAsync();
        }

        public async Task<Nutrition> GetNutritionById(int id)
        {
            return await _context.Nutritions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveChanges()
        {
           await _context.SaveChangesAsync();
        }
    }
}

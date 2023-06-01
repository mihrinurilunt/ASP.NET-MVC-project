using Microsoft.EntityFrameworkCore;

namespace CupcakeMVC.Models
{
    public class DrinksService : IDrinksService
    {
        private readonly ApplicationDbContext _context;
        public DrinksService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Drinks drinks)
        {
            _context.Drink.Add(drinks);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Drinks>> GetAll()
        {
            var result = await _context.Drink.ToListAsync();
            return result;
        }

        public Drinks GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Drinks Update(int id, Drinks newDrinks)
        {
            throw new NotImplementedException();
        }
    }
}

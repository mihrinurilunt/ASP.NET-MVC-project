using Microsoft.EntityFrameworkCore;

namespace CupcakeMVC.Models
{
    public class DessertService : IDessertService
    {
        private readonly ApplicationDbContext _context;
        public DessertService(ApplicationDbContext context)
        {
            _context =context ;
        }
        public void Add (Dessert dessert)
        {
             _context.Desserts.Add(dessert);
             _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dessert>> GetAll()
        {
            var result =await _context.Desserts.ToListAsync();
            return result;
        }

        public Dessert GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dessert Update(int id, Dessert newDessert)
        {
            throw new NotImplementedException();
        }
    }
}

namespace CupcakeMVC.Models
{
    public interface IDrinksService
    {
        Task<IEnumerable<Drinks>> GetAll();
        Drinks GetById(int id);
        void Add(Drinks drinks);
        Drinks Update(int id, Drinks newDrinks);
        void Delete(int id);
    }
}

namespace CupcakeMVC.Models
{
    public interface IDessertService
    {
        Task<IEnumerable<Dessert>> GetAll();
        Dessert GetById(int id);
        void Add(Dessert dessert);
        Dessert Update(int id, Dessert newDessert);
        void Delete(int id);
    }
}

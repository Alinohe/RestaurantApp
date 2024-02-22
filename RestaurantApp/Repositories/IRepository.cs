namespace RestaurantApp.Repositories;
using RestaurantApp.Entities;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
    where T : class, IEntity
{

}


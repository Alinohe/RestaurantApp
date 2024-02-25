namespace RestaurantApp.Repositories.Extensions;
using RestaurantApp.Entities;
public static class RepositoryExtension
{
    public static void AddBatch<T>(this IRepository<T> repository, T[]items) 
        where T : class, IEntity
    {
        foreach (var item in items)
        {
            repository.Add(item);
        }
        repository.Save();
    }
}


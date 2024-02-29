using RestaurantApp.Data;
using RestaurantApp.Entities;
using RestaurantApp.Repositories;
using RestaurantApp.Repositories.Extensions;
using System.Xml.Linq;


var foodRepository = new SqlRepository<Food>(new RestaurantAppDbContext(), FoodAdded);
foodRepository.ItemAdded += FoodRepositoryOnItemAdded;

static void FoodRepositoryOnItemAdded(object? sender, Food e)
{
    Console.WriteLine($"FoodAdded => {e.Name} from {sender?.GetType().Name}");
}

AddNormal(foodRepository);
AddVegetarian(foodRepository);
AddVegan(foodRepository);
WriteAllToConsole(foodRepository);

static void FoodAdded(object item)
{
    var food = (Food)item;
    Console.WriteLine($"{Food.Name} added");
}

static void AddNormal(IWriteRepository<FoodTypeNormal> foodRepository)
{
    foodRepository.Add(new FoodTypeNormal { Name = "Beef Steak" });
    foodRepository.Add(new FoodTypeNormal { Name = "Pork Stake" });
    foodRepository.Add(new FoodTypeNormal { Name = "Lamb" });
    foodRepository.Save();

}

static void AddVegetarian(IWriteRepository<FoodTypeVegetarian> foodRepository)
{
    foodRepository.Add(new FoodTypeVegetarian { Name = "Eggs" });
    foodRepository.Add(new FoodTypeVegetarian { Name = "Fish" });
    foodRepository.Save();

}

static void AddVegan(IWriteRepository<FoodTypeVegan> foodRepository);
{
    foodRepository.Add(new FoodTypeVegan { Name = "Salad" });
    foodRepository.Add(new FoodTypeVegan { Name = "Avocado" });
    foodRepository.Save();

}
// customerRepository.AddBatch(customer);
static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

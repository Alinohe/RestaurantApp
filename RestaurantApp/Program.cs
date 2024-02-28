using RestaurantApp.Data;
using RestaurantApp.Entities;
using RestaurantApp.Repositories;
using RestaurantApp.Repositories.Extensions;


var customerRepository = new SqlRepository<Customers>(new RestaurantAppDbContext(), CustomerAdded);
customerRepository.ItemAdded += CustomerRepositoryOnItemAdded;

static void CustomerRepositoryOnItemAdded(object? sender, Customers e)
{
    Console.WriteLine($"CustomerAdded => {e.FirstName} from {sender?.GetType().Name}");
}

AddNormal(customerRepository);
AddVegetarian(customerRepository);
AddVegan(customerRepository);
WriteAllToConsole(customerRepository);

static void CustomerAdded(object item)
{
    var customer = (Customers)item;
    Console.WriteLine($"{customer.FirstName} added");
}

    static void AddNormal(IWriteRepository<FoodTypeNormal> customerRepository)
    {
        customerRepository.Add(new FoodTypeNormal { FirstName = "Adam" });
        customerRepository.Add(new FoodTypeNormal { FirstName = "Piotr" });
        customerRepository.Add(new FoodTypeNormal { FirstName = "Zuzia" });
        customerRepository.Save();

    }

    static void AddVegetarian(IWriteRepository<FoodTypeVegetarian> customerRepository)
    {
        customerRepository.Add(new FoodTypeVegetarian { FirstName = "Przemek" });
        customerRepository.Add(new FoodTypeVegetarian { FirstName = "Tomek" });
        customerRepository.Save();

    }

    static void AddVegan(IWriteRepository<FoodTypeVegan> customerRepository)
    {
        customerRepository.Add(new FoodTypeVegan { FirstName = "Brian" });
        customerRepository.Add(new FoodTypeVegan { FirstName = "Jesica" });
        customerRepository.Save();

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

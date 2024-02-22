using RestaurantApp.Data;
using RestaurantApp.Entities;
using RestaurantApp.Repositories;

var customerRepository = new SqlRepository<Customers>(new RestaurantAppDbContext());
AddNormal(customerRepository);
AddVegetarian(customerRepository);
AddVegan(customerRepository);
WriteAllToConsole(customerRepository);

static void AddNormal(IWriteRepository<FTNormal> customerRepository)
{
    customerRepository.Add(new FTNormal { FirstName = "Adam" });
    customerRepository.Add(new FTNormal { FirstName = "Piotr" });
    customerRepository.Add(new FTNormal { FirstName = "Zuzia" });
    customerRepository.Save();

}

static void AddVegetarian(IWriteRepository<FTVegetarian> customerRepository)
{
    customerRepository.Add(new FTVegetarian { FirstName = "Przemek" });
    customerRepository.Add(new FTVegetarian { FirstName = "Tomek" });
    customerRepository.Save();

}

static void AddVegan(IWriteRepository<FTVegan> customerRepository)
{
    customerRepository.Add(new FTVegan { FirstName = "Brian" });
    customerRepository.Add(new FTVegan { FirstName = "Jesica" });
    customerRepository.Save();

}
static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}



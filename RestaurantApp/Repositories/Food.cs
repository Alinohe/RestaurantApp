
using RestaurantApp.Entities;

namespace RestaurantApp.Repositories;


  abstract public class Food : IFood
{

    Food(string name)
    {

    }

    public virtual bool isNormal() => false;
    public virtual bool isVegan() => false;
    public virtual bool isVegetarian() => false;

}



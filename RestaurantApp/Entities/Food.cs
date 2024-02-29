
using RestaurantApp.Entities;

namespace RestaurantApp.Repositories;


  public class Food : EntityBase
{
    public Food() 
    { 
    }
    public Food(string name, string type)
    {

    }

    public string? Name { get; set; }
    public string? Type { get; set; }

    public override string ToString() => $"ID: {Id}, Name: {Name}, FoodType: {Type}";

    public virtual bool isNormal() => false;
    public virtual bool isVegan() => false;
    public virtual bool isVegetarian() => false;

}



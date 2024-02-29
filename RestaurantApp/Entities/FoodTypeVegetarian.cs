namespace RestaurantApp.Entities;
using RestaurantApp.Repositories;
public class FoodTypeVegetarian : Food
{
    public override string ToString() => base.ToString() + "  (Vegetarian)";
    public override bool isVegetarian() => true;
}

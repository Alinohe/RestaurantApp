namespace RestaurantApp.Entities;

public class Customers : EntityBase
{
    public Customers()
    {

    }
    public Customers(string name, string foodtype)
    {

    }
    public string? FirstName { get; set; }
    public string? FoodType { get; set; }

    public override string ToString() => $"ID: {Id}, FirstName: {FirstName}, FoodType: {FoodType}";

}

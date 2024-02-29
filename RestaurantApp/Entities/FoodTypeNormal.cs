namespace RestaurantApp.Entities;
using RestaurantApp.Repositories;
public class FoodTypeNormal : Food
    {
        public override string ToString() => base.ToString() + "  (Normal)";
    public override bool isNormal() => true;
    }


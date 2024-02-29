namespace RestaurantApp.Entities;
    using RestaurantApp.Repositories;

    public class FoodTypeVegan : Food
    {
        public override string ToString() => base.ToString() + "  (Vegan)";

    }


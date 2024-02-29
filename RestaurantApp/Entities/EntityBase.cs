
namespace RestaurantApp.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}


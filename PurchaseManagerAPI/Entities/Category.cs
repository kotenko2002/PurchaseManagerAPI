using PurchaseManagerAPI.Entities.Base;

namespace PurchaseManagerAPI.Entities
{
    public class Category : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public string Name { get; set; }
    }
}

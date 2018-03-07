namespace otherLands.Backend.Models
{
    using Domain;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<otherLands.Domain.User> Users { get; set; }
    }
}
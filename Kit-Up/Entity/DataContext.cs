using Kit_Up.Entity;
using System.Data.Entity;

namespace Kit_Up.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Urun> Urunler { get; set; }
    }
}
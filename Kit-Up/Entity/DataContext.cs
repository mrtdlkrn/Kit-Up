using System.Data.Entity;

namespace Kit_Up.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {

        }

        public DbSet<Urun> Urunler { get; set; }
    }
}
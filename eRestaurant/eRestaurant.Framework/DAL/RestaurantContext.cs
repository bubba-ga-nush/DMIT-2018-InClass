using System;
using System.Collections.Generic;
using System.Data.Entity; // Needed for the DbContext and other EF classes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.Framework.Entities; // Needed for entity classes

namespace eRestaurant.Framework.DAL
{
    // By making our DAL class internal, that means outside project can't directly 
    // access our Data Access Layer (they will have to go through our BLL to do stuff)
    internal class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("DefaultConnection")
        {

        }
        // One property for each Table/Entity in the database
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        // The propety name must match the name of the database table
        public DbSet<Table> Tables { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        // For customizing the model of out entities as we want them to match our
        // database, we would put any details inside the following methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
                       modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("ReservationID");
                    mapping.MapRightKey("TableID");
                });
            base.OnModelCreating(modelBuilder);
        
        }
    }
}

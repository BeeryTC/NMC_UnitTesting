using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Friends.Models.Mapping;

namespace Friends.Models
{
    public partial class AddressBookContext : DbContext
    {
        static AddressBookContext()
        {
            Database.SetInitializer<AddressBookContext>(null);
        }

        public AddressBookContext()
            : base("Name=AddressBookContext")
        {
        }

        public DbSet<Friend> Friends { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FriendMap());
            modelBuilder.Configurations.Add(new StateMap());
        }
    }
}

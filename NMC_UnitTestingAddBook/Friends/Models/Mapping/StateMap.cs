using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Friends.Models.Mapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => t.StateAbbrev);

            // Properties
            this.Property(t => t.StateAbbrev)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("States");
            this.Property(t => t.StateAbbrev).HasColumnName("StateAbbrev");
        }
    }
}

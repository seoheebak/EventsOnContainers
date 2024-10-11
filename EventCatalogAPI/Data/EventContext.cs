using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace EventCatalogAPI.Data
{
    public class EventContext : DbContext
    {
        public DbSet<EventType> EventTypes { get; set; }    
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>(e =>
            {
                e.Property(t => t.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

                e.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);
            });

            modelBuilder.Entity<Event>(e =>
            {
                e.Property(e => e.Type)
                .IsRequired()
                .ValueGeneratedOnAdd();

                e.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

                e.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(300);
               
                e.Property(e => e.Time)
                .IsRequired();

                e.Property(e => e.Duration)
               .IsRequired();

                e.Property(e => e.Ticket)
                .IsRequired();

                e.HasOne(e => e.EventType)
                .WithMany()
                .HasForeignKey(e => e.EventTypeId);


            });
        }

    }
}

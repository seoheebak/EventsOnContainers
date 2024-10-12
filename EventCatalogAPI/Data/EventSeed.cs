using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace EventCatalogAPI.Data
{
    public static class EventSeed
    {
        public static void Seed(EventContext context)
        {
            context.Database.Migrate();

            if (!context.EventTypes.Any())
            {
                context.EventTypes.AddRange(GetEventTypes());
                context.SaveChanges();
            }
        }

        private static IEnumerable<EventType> GetEventTypes()
        {
            return new List<EventType>()
            {
                new EventType { Type = "Music" },
                new EventType { Type = "Comedy" },
                new EventType { Type = "Performimg arts" },
                new EventType { Type = "Educational" },
                new EventType { Type = "Food & Drinks" }
            };
        }
    }
}
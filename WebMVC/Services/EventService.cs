using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.Infrastructer;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class EventService : IEventService
    {
        private readonly string _baseUrl;
        public EventService(IConfiguration config) 
        {
            _baseUrl = $"{config["EventUrl"]}/ api /event";
        }
        public Task<Event> GetEventTypesAsync(int page, int Size, int? Type)
        {
            APIPaths.Event.GetAllTypes()
        }

        public Task<IEnumerable<SelectListItem>> GetTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Services;
using WebMVC.ViewModels;

namespace WebMVC.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _Service;
        public EventController(IEventService service)
        {
            _Service = service;
        }
        public async Task<IActionResult> Index(int? page, int? typeFilterApplied)

        {
            var typesOnpage = 10;
            var Event = await _Service.GetEventTypesAsync(page ?? 0, typesOnpage, typeFilterApplied);
            var vm = new EventIndexViewModel
            {
                Types = await _Service.GetTypesAsync(),
                eventTypes = Event.Data,
                PaginationInfo = new PaginationInfo
                {
                    ActualPage = Event.PageIndex,
                    TotalTypes = Event.Count,
                    TypesPerPage = Event.PageSize,
                    TotalPages = (int)Math.Ceiling((decimal)Event.Count / typesOnpage),
                },
                TypeFilterApplied = typeFilterApplied,

            };

            return View(vm);
        }
    }
}
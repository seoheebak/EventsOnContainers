﻿using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.Models;

namespace WebMVC.ViewModels
{
    public class EventIndexViewModel
    {
        public IEnumerable<SelectListItem> Types { get; set; }
        public  IEnumerable<EventType> eventTypes { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
        
        public  int? TypeFilterApplied { get; set; }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Pages.Events
{
    public class EventsModel : PageModel
    {
        private readonly IService<Event> service;

        public EventsModel(IService<Event> service)
        {
            this.service = service;
        }

        public ICollection<Event> Events { get; set; }

        public async Task OnGetAsync()
        {
            Events = await service.GetAll();
        }
    }
}
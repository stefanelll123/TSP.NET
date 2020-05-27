using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Pages.Places
{
    public class PlacesModel : PageModel
    {
        private readonly IService<Place> service;

        public PlacesModel(IService<Place> service)
        {
            this.service = service;
        }

        public ICollection<Place> Places { get; set; }

        public async Task OnGetAsync()
        {
            Places = await service.GetAll();
        }
    }
}
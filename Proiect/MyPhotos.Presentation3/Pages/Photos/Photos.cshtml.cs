using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Pages.Photos
{
    public class PhotosModel : PageModel
    {
        private readonly IService<Photo> service;

        public PhotosModel(IService<Photo> service)
        {
            this.service = service;
        }

        public ICollection<Photo> Photos { get; set; }

        public async Task OnGetAsync()
        {
            Photos = await service.GetAll();
        }
    }
}
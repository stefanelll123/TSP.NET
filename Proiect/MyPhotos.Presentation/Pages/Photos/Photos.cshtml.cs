using System.Collections.Generic;
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

        public void OnGet()
        {
            Photos = service.GetAll();
        }
    }
}
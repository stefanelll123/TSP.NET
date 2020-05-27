using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Pages.Photos
{
    public class PhotosModel : PageModel
    {
        private readonly IPhotoService service;

        public PhotosModel(IPhotoService service)
        {
            this.service = service;
        }

        public ICollection<Photo> Photos { get; set; }

        public async Task OnGetAsync()
        {
            var name = Request.Query["name"].FirstOrDefault();
            var type = Request.Query["type"].FirstOrDefault();
            var eventName = Request.Query["eventName"].FirstOrDefault();
            var place = Request.Query["place"].FirstOrDefault();
            var person = Request.Query["person"].FirstOrDefault();

            Photos = await service.GetFilterPhotos(name, type, eventName, place, person);
        }

        public IActionResult OnPost()
        {
            var name = Request.Form["name"].FirstOrDefault();
            var type = Request.Form["type"].FirstOrDefault();
            var eventName = Request.Form["eventName"].FirstOrDefault();
            var place = Request.Form["place"].FirstOrDefault();
            var person = Request.Form["person"].FirstOrDefault();

            return new RedirectToPageResult("photos", new {name, type, eventName, place, person});
        }
    }
}
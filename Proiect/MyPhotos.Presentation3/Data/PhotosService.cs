using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;
using ServiceReference1;

namespace MyPhotos.Presentation.Data
{
    public class PhotosService : IService<Photo>
    {
        private readonly IServiceImplementation wcfService;

        public PhotosService(IServiceImplementation wcfService)
        {
            this.wcfService = wcfService;
        }

        public Task<ICollection<Photo>> GetAll()
        {
            return Task.FromResult((ICollection<Photo>)new List<Photo>
            {
                new Photo
                {
                    Id = Guid.NewGuid(),
                    Name = "Photo1",
                    Path = "C:/Users/sturcu/Desktop/facultate/licenta/protein-classification/project/data/chart.PNG"
                }
            });

            //var photos = await wcfService.GetAllPhotosAsync();

            //return photos.Select(x => new Photo
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    Path = x.Path,
            //    Types = x.Types.Select(y => y.Name).ToList(),
            //    Persons = x.People.Select(y => $"{y.FirstName} {y.LastName}").ToList(),
            //    EventName = x.Event.Name,
            //    Places = x.Places.Select(y => y.Name).ToList()
            //}).ToList();
        }
    }
}

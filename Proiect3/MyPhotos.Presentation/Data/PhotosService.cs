using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;
using ServiceReference1;

namespace MyPhotos.Presentation.Data
{
    public class PhotosService : IPhotoService
    {
        private readonly IServiceImplementation wcfService;
        private readonly IMapper mapper;

        public PhotosService(IServiceImplementation wcfService, IMapper mapper)
        {
            this.wcfService = wcfService;
            this.mapper = mapper;
        }

        public async Task<ICollection<Photo>> GetFilterPhotos(string name, string type, string eventName, string place, string person)
        {
            var photos = await wcfService.GetFilterPhotosAsync(name, type, eventName, place, person);

            return photos.Select(x => mapper.Map<Photo>(x)).ToList();
        }
    }
}

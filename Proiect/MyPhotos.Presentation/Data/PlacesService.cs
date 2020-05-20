using System.Collections.Generic;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    public class PlacesService : IService<Place>
    {
        public ICollection<Place> GetAll()
        {
            return new List<Place>();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    public class PlacesService : IService<Place>
    {
        public Task<ICollection<Place>> GetAll()
        {
            //return new List<Place>();

            return Task.FromResult((ICollection<Place>)null);
        }
    }
}

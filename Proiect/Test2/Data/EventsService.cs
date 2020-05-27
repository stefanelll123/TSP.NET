using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    public class EventsService : IService<Event>
    {
        public Task<ICollection<Event>> GetAll()
        {
            //return new List<Event>();
            return Task.FromResult((ICollection<Event>)null);
        }
    }
}

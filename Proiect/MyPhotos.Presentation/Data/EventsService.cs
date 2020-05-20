using System.Collections.Generic;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    public class EventsService : IService<Event>
    {
        public ICollection<Event> GetAll()
        {
            return new List<Event>();
        }
    }
}

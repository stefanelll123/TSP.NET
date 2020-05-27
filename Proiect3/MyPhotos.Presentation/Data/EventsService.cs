using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using ServiceReference1;
using Event = MyPhotos.Presentation.Models.Event;

namespace MyPhotos.Presentation.Data
{
    public class EventsService : IService<Event>
    {
        private readonly IServiceImplementation wcfService;

        public EventsService(IServiceImplementation wcfService)
        {
            this.wcfService = wcfService;
        }

        public async Task<ICollection<string>> GetAllNames()
        {
            return await wcfService.GetAllEventsNameAsync();
        }
    }
}

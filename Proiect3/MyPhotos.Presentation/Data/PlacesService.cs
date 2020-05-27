using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;
using ServiceReference1;

namespace MyPhotos.Presentation.Data
{
    public class PlacesService : IService<Place>
    {
        private readonly IServiceImplementation wcfService;

        public PlacesService(IServiceImplementation wcfService)
        {
            this.wcfService = wcfService;
        }

        public async Task<ICollection<string>> GetAllNames()
        {
            return await wcfService.GetAllPlacesNamesAsync();
        }
    }
}

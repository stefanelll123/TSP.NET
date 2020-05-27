using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using ServiceReference1;
using Type = MyPhotos.Presentation.Models.Type;

namespace MyPhotos.Presentation.Data
{
    public class TypesService : IService<Type>
    {
        private readonly IServiceImplementation wcfService;

        public TypesService(IServiceImplementation wcfService)
        {
            this.wcfService = wcfService;
        }

        public async Task<ICollection<string>> GetAllNames()
        {
            return await wcfService.GetAllTypesNamesAsync();
        }
    }
}

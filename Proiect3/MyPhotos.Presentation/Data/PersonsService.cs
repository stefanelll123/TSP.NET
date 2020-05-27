using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using ServiceReference1;
using Person = MyPhotos.Presentation.Models.Person;

namespace MyPhotos.Presentation.Data
{
    public class PersonsService : IService<Person>
    {
        private readonly IServiceImplementation wcfService;

        public PersonsService(IServiceImplementation wcfService)
        {
            this.wcfService = wcfService;
        }

        public async Task<ICollection<string>> GetAllNames()
        {
            return await wcfService.GetAllPersonsNamesAsync();
        }
    }
}

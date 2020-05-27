using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Pages.Persons
{
    public class PersonsModel : PageModel
    {
        private readonly IService<Person> service;

        public PersonsModel(IService<Person> service)
        {
            this.service = service;
        }

        public ICollection<Person> Persons { get; set; }

        public async Task OnGetAsync()
        {
            Persons = await service.GetAll();
        }
    }
}
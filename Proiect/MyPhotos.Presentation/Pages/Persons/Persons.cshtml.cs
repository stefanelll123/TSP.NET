using System.Collections.Generic;
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

        public void OnGet()
        {
            Persons = service.GetAll();
        }
    }
}
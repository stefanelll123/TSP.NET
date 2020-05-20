using System;
using System.Collections.Generic;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    public class PersonsService : IService<Person>
    {
        public ICollection<Person> GetAll()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Test",
                    LastName = "Test"
                }
            };
        }
    }
}

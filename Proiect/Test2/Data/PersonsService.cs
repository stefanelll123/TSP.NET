using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Data
{
    public class PersonsService : IService<Person>
    {
        public Task<ICollection<Person>> GetAll()
        {
            //return new List<Person>
            //{
            //    new Person
            //    {
            //        Id = Guid.NewGuid(),
            //        FirstName = "Test",
            //        LastName = "Test"
            //    }
            //};

            return Task.FromResult((ICollection<Person>)null);
        }
    }
}

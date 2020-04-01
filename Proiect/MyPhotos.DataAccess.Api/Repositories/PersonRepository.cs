using MyPhotos.DataAccess.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotos.DataAccess.Api.Repositories
{
    public sealed class PersonRepository : IRepository<Person>
    {
        private readonly MyPhotosModelContainer _container;

        public PersonRepository()
        {
            _container = new MyPhotosModelContainer();
        }

        public void Add(Person entity)
        {
            _container.People.Add(entity);
            _container.SaveChanges();
        }

        public ICollection<Person> GetAll()
        {
            return _container.People.ToList();
        }

        public Person GetById(Guid id)
        {
            return _container.People.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Person oldEntity, Person newEntity)
        {
            var old = _container.People.FirstOrDefault(x => x.Id == oldEntity.Id);
            if (old != null)
            {
                old.FirstName = newEntity.FirstName;
                old.LastName = newEntity.LastName;
            }

            _container.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var person = _container.People.FirstOrDefault(x => x.Id == id);
            if(person != null)
            {
                _container.People.Remove(person);
            }

            _container.SaveChanges();
        }
    }
}

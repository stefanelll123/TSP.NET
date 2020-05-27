using System;
using System.Collections.Generic;
using System.Linq;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.WcfServices.Services
{
    public partial class ServiceImplementation
    {
        public void AddPerson(Person entity)
        {
            _personRepository.Add(entity);
        }

        public ICollection<Person> GetAllPersons()
        {
            return _personRepository.GetAll();
        }

        public ICollection<string> GetAllPersonsNames()
        {
            return _personRepository.GetAll().Select(x => $"{x.FirstName} {x.LastName}").ToList();
        }

        public Person GetPersonById(Guid id)
        {
            return _personRepository.GetById(id);
        }

        public void UpdatePerson(Person oldEntity, Person newEntity)
        {
            _personRepository.Update(oldEntity, newEntity);
        }

        public void DeletePerson(Guid id)
        {
            _personRepository.Delete(id);
        }
    }
}